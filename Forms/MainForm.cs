namespace FileCustom
{
    public partial class MainForm : FileCustomForm
    {
        public MainForm()
        {
            InitializeComponent();
            InitializeFileCustomForm();
            FileCustomSettings.Load();
            init_themes_comboBox();
        }

        private void init_themes_comboBox()
        {
            themes_comboBox.Items.AddRange(FileCustomSettings.Themes);
            themes_comboBox.SelectedIndex = themes_comboBox.Items.IndexOf(FileCustomSettings.Settings["Main_theme"]);
        }

        private void themes_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            FileCustomSettings.Settings["Main_theme"] = (themes_comboBox.SelectedItem.ToString() ?? "");
            FileCustomSettings.Write();
            FileCustomSettings.SetTheme(this);
        }

        private void DeleteFilesIfEquals_button_Click(object sender, EventArgs e)
        {
            new DeleteFilesIfEquals_Form().Show();
        }

        private void FindFilesNonUnique_button_Click(object sender, EventArgs e)
        {
            new FindFilesNonUnique_Form().Show();
        }

        private void DeleteEmptyFolders_button_Click(object sender, EventArgs e)
        {
            new DeleteEmptyFolders().Show();
        }

    }
}