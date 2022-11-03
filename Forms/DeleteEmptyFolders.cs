using Sugar;

namespace FileCustom
{
    public partial class DeleteEmptyFolders : FileCustomForm
    {
        public DeleteEmptyFolders()
        {
            InitializeComponent();
            InitializeFileCustomForm();
            getApplySettingsToControls(true);
        }

        private void getApplySettingsToControls(bool isApply)
        {
            FileCustomSettings.GetApplyToControl(isApply, "DeleteEmptyFolders_folders", folders_richTextBox);
        }

        private void go_button_Click(object sender, EventArgs e)
        {
            result_richTextBox.Text = "";
            getApplySettingsToControls(false);

            if (!FileCustomSettings.Settings.IsNullOrEmpty())
            {
                FileCustomSettings.Write();
                var folders = FolderExtra.GetFoldersFullnameFromPlainText(FileCustomSettings.Settings["DeleteEmptyFolders_folders"], FileCustomSettings.InputFoldersSplitter);
                
                if (folders.Count > 0)
                {
                    var log = Sugar.FileCustom.DeleteEmptyFolders(folders);
                    result_richTextBox.Text = log;
                }
                else
                    MessageBox.Show($"Error! Unable to delete: folders count: {folders.Count}");
            }
            else
                MessageBox.Show("Error! Settings is empty!");
        }

    }
}
