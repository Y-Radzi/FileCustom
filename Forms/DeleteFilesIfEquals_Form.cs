using Sugar;

namespace FileCustom
{
    public partial class DeleteFilesIfEquals_Form : FileCustomForm
    {
        public DeleteFilesIfEquals_Form()
        {
            InitializeComponent();
            InitializeFileCustomForm();
            getApplySettingsToControls(true);
        }

        private void getApplySettingsToControls(bool isApply)
        {
            FileCustomSettings.GetApplyToControl(isApply, "DeleteFilesIfEquals_foldersToCompare", foldersToCompare_richTextBox);
            FileCustomSettings.GetApplyToControl(isApply, "DeleteFilesIfEquals_foldersToDelete", foldersToDelete_richTextBox);
        }

        private void go_button_Click(object sender, EventArgs e)
        {
            result_richTextBox.Text = "";
            getApplySettingsToControls(false);

            if (!FileCustomSettings.Settings.IsNullOrEmpty())
            {
                FileCustomSettings.Write();
                var filesToCompareFull = FileExtra.GetFilesAll(
                    FolderExtra.GetFoldersFullnameFromPlainText(
                        FileCustomSettings.Settings["DeleteFilesIfEquals_foldersToCompare"], FileCustomSettings.InputFoldersSplitter));
                var filesToDeleteFull = FileExtra.GetFilesAll(
                    FolderExtra.GetFoldersFullnameFromPlainText(
                        FileCustomSettings.Settings["DeleteFilesIfEquals_foldersToDelete"], FileCustomSettings.InputFoldersSplitter));

                if (filesToCompareFull.Count > 0 && filesToDeleteFull.Count > 0)
                {
                    var log = Sugar.FileCustom.DeleteFilesIfEqualsData(filesToDeleteFull, filesToCompareFull, false);

                    foreach (var element in log.Groups["Deleted"].Elements)
                        FileCustomSugar.DeleteFile(element.FullNameMain, true);

                    result_richTextBox.Text = log.DisplayAll();
                }
                else
                    MessageBox.Show($"Error! Unable to compare: files to compare count: {filesToCompareFull.Count} and files to delete count: {filesToDeleteFull.Count}");
            }
            else
                MessageBox.Show("Error! Settings is empty!");
        }

    }
}
