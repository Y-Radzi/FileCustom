using Sugar;

namespace FileCustom
{
    public partial class FindFilesNonUnique_Form : FileCustomForm
    {
        Sugar.FileCustom.ComparaisonLogOutput logOutput = new();
        string keyCompared = "keyCompared";

        public FindFilesNonUnique_Form()
        {
            InitializeComponent();
            InitializeFileCustomForm();
            getApplySettingsToControls(true);
        }

        private void getApplySettingsToControls(bool isApply)
        {
            FileCustomSettings.GetApplyToControl(isApply, "FindFilesNonUnique_Folders", folders_richTextBox);
        }

        private void go_button_Click(object sender, EventArgs e)
        {
            result_richTextBox.Text = "";
            getApplySettingsToControls(false);
            logOutput = new Sugar.FileCustom.ComparaisonLogOutput();

            if (!FileCustomSettings.Settings.IsNullOrEmpty())
            {
                FileCustomSettings.Write();
                var files = FileExtra.GetFilesAll(
                    FolderExtra.GetFoldersFullnameFromPlainText(
                        FileCustomSettings.Settings["FindFilesNonUnique_Folders"], FileCustomSettings.InputFoldersSplitter));

                if (files.Count > 0)
                {
                    logOutput = Sugar.FileCustom.FindFilesNonUnique(files);
                    result_richTextBox.Text = logOutput.DisplayAll();
                }
                else
                    MessageBox.Show("Error! Files count is 0");
            }
            else
                MessageBox.Show("Error! Settings is empty!");
        }

        private void runCompare_button_Click(object sender, EventArgs e)
        {
            if (logOutput.Groups.ContainsKey(keyCompared))
                new FindFilesNonUnique_Compare_Form(logOutput.Groups[keyCompared]).Show();
        }
    }
}
