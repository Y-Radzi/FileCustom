using Sugar;

namespace FileCustom
{
    public partial class DeleteFilesIfEquals_Form : Form
    {
        public DeleteFilesIfEquals_Form()
        {
            InitializeComponent();
            FileCustomSettings.SetTheme(this);
            applySettingsToControls();
            foldersToCompare_richTextBox.AddDefaultShortContextMenu();
            foldersToDelete_richTextBox.AddDefaultShortContextMenu();
            result_richTextBox.AddDefaultShortContextMenu();

            foldersToCompare_richTextBox.AllowDrop = true;
            foldersToCompare_richTextBox.DragDrop += new DragEventHandler(RichTextBoxExtra.DragDrop_Folder);
            foldersToCompare_richTextBox.DragEnter += new DragEventHandler(RichTextBoxExtra.DragEnter_File);
            foldersToDelete_richTextBox.AllowDrop = true;
            foldersToDelete_richTextBox.DragDrop += new DragEventHandler(RichTextBoxExtra.DragDrop_Folder);
            foldersToDelete_richTextBox.DragEnter += new DragEventHandler(RichTextBoxExtra.DragEnter_File);
        }

        private void foldersToCompare_richTextBox_TextChanged(object sender, EventArgs e)
        {
            FileCustomSugar.Folders_richTextBox_TextChanged(sender, e);
        }

        private void foldersToDelete_richTextBox_TextChanged(object sender, EventArgs e)
        {
            FileCustomSugar.Folders_richTextBox_TextChanged(sender, e);
        }

        private void applySettingsToControls()
        {
            foldersToCompare_richTextBox.Text = FileCustomSettings.Settings["DeleteFilesIfEquals_foldersToCompare"];
            foldersToDelete_richTextBox.Text = FileCustomSettings.Settings["DeleteFilesIfEquals_foldersToDelete"];
        }

        private void getSettingsFromControls()
        {
            FileCustomSettings.Settings["DeleteFilesIfEquals_foldersToCompare"] = foldersToCompare_richTextBox.Text;
            FileCustomSettings.Settings["DeleteFilesIfEquals_foldersToDelete"] = foldersToDelete_richTextBox.Text;
        }

        private void go_button_Click(object sender, EventArgs e)
        {
            result_richTextBox.Text = "";
            getSettingsFromControls();

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
