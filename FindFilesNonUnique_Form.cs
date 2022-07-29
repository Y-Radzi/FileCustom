using Sugar;

namespace FileCustom
{
    public partial class FindFilesNonUnique_Form : Form
    {
        Sugar.FileCustom.ComparaisonLogOutput logOutput = new();
        string keyCompared = "keyCompared";
        string keyMore2GB = "keyMore2GB";

        public FindFilesNonUnique_Form()
        {
            InitializeComponent();
            FileCustomSettings.SetTheme(this);
            applySettingsToControls();
        }

        private void applySettingsToControls()
        {
            folders_richTextBox.Text = FileCustomSettings.Settings["FindFilesNonUnique_Folders"];
        }

        private void getSettingsFromControls()
        {
            FileCustomSettings.Settings["FindFilesNonUnique_Folders"] = folders_richTextBox.Text;
        }

        private void folders_richTextBox_TextChanged(object sender, EventArgs e)
        {
            int i = folders_richTextBox.SelectionStart;
            folders_richTextBox.Text = folders_richTextBox.Text.RemoveWhileEquals(StringExtra.Side.All, FileCustomSettings.UnallowedSymbolsForFoldersPlainText);
            folders_richTextBox.SelectionStart = i;
        }

        private void go_button_Click(object sender, EventArgs e)
        {
            result_richTextBox.Text = "";
            getSettingsFromControls();
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

        private void runImageCompare_button_Click(object sender, EventArgs e)
        {
            new FindFilesNonUnique_Compare_Form(logOutput.Groups[keyCompared]).Show();
        }
    }
}
