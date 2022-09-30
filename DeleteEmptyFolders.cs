using Sugar;

namespace FileCustom
{
    public partial class DeleteEmptyFolders : Form
    {
        public DeleteEmptyFolders()
        {
            InitializeComponent();
            FileCustomSettings.SetTheme(this);
            applySettingsToControls();
            folders_richTextBox.AddDefaultShortContextMenu();
            result_richTextBox.AddDefaultShortContextMenu();

            folders_richTextBox.AllowDrop = true;
            folders_richTextBox.DragDrop += new DragEventHandler(folders_richTextBox_DragDrop);
            folders_richTextBox.DragEnter += new DragEventHandler(folders_richTextBox_DragEnter);
        }

        private void folders_richTextBox_TextChanged(object sender, EventArgs e)
        {
            FileCustomSugar.Folders_richTextBox_TextChanged(sender, e);
        }

        private void folders_richTextBox_DragDrop(object sender, DragEventArgs e)
        {
            folders_richTextBox.DragDrop_Folder(e);
        }

        private void folders_richTextBox_DragEnter(object sender, DragEventArgs e)
        {
            folders_richTextBox.DragEnter_File(e);
        }

        private void applySettingsToControls()
        {
            folders_richTextBox.Text = FileCustomSettings.Settings["DeleteEmptyFolders_folders"];
        }

        private void getSettingsFromControls()
        {
            FileCustomSettings.Settings["DeleteEmptyFolders_folders"] = folders_richTextBox.Text;
        }

        private void go_button_Click(object sender, EventArgs e)
        {
            result_richTextBox.Text = "";
            getSettingsFromControls();

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
