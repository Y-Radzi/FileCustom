using Sugar;

namespace FileCustom
{
    public partial class FindFilesNonUnique_Form : Form
    {
        Sugar.FileCustom.ComparaisonLogOutput logOutput = new();
        string keyCompared = "keyCompared";

        public FindFilesNonUnique_Form()
        {
            InitializeComponent();
            FileCustomSettings.SetTheme(this);
            applySettingsToControls();
            folders_richTextBox.AddDefaultShortContextMenu();
            result_richTextBox.AddDefaultShortContextMenu();

            folders_richTextBox.AllowDrop = true;
            folders_richTextBox.DragDrop += new DragEventHandler(RichTextBoxExtra.DragDrop_Folder);
            folders_richTextBox.DragEnter += new DragEventHandler(RichTextBoxExtra.DragEnter_File);
        }

        private void applySettingsToControls()
        {
            folders_richTextBox.Text = FileCustomSettings.Settings["FindFilesNonUnique_Folders"];
        }

        private void getSettingsFromControls()
        {
            FileCustomSettings.Settings["FindFilesNonUnique_Folders"] = folders_richTextBox.Text;
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

        private void runCompare_button_Click(object sender, EventArgs e)
        {
            if (logOutput.Groups.ContainsKey(keyCompared))
                new FindFilesNonUnique_Compare_Form(logOutput.Groups[keyCompared]).Show();
        }

        private void folders_richTextBox_TextChanged(object sender, EventArgs e)
        {
            FileCustomSugar.Folders_richTextBox_TextChanged(sender, e);
        }
    }
}
