using System.Text;
using Sugar;

namespace FileCustom
{
    public static class FileCustomSettings
    {
        public static string SettingsFileName = "Settings_FileCustom.txt";
        public static Encoding SettingsEncoding = Encoding.Default;
        public static string SettingsKeySplitter = ": ";
        public static string SettingsVariableSplitter = "\n!";

        public static string InputFoldersSplitter = "\n";
        public static int DistanceBetweenFormControls = 6;
        public static string WebpExtention = "webp";
        public static List<string> ImageExtentions = new List<string>() { "jpg", "jpeg", "png", "bmp", "gif", "tiff" };
        public static string[] Themes = new string[] { "Default", "Dark" };
        public static string[] UnallowedSymbolsForFoldersPlainText = new string[] { "!", "?", "*", "\"", "'", ">", "<" };
        
        public static Dictionary<string, string> Settings = new Dictionary<string, string>() {
            { "Main_theme", "" },
            { "DeleteFilesIfEquals_foldersToCompare", "" },
            { "DeleteFilesIfEquals_foldersToDelete", "" },
            { "FindFilesNonUnique_Folders", "" },
            { "FindFilesNonUnique_Compare_maximumPathSquareSize", "" },
            { "FindFilesNonUnique_Compare_pictureSquareSize", "" },
            { "FindFilesNonUnique_Compare_showMessageAfterDeleting", "" },
        };

        public static void Load()
        {
            Settings = SettingsSimple.Load(Settings, SettingsFileName, SettingsEncoding, SettingsVariableSplitter, SettingsKeySplitter);
        }

        public static void Write()
        {
            SettingsSimple.Write(Settings, SettingsFileName, SettingsEncoding, SettingsVariableSplitter, SettingsKeySplitter);
        }

        public static void SetTheme(Form form)
        {
            var theme = new FileCustomSugar.ThemeStruct();
            theme.BackColor = SystemColors.Control;
            theme.ForeColor = SystemColors.ControlText;
            theme.TextDefaultFont = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            theme.FlatStyle = FlatStyle.Standard;
            theme.BorderColor = SystemColors.ControlText;
            theme.BorderSize = 1;
            theme.RichTextBoxBackColor = SystemColors.Window;

            switch (Settings["Main_theme"])
            {
                case "Dark":
                    theme.BackColor = Color.Black;
                    theme.ForeColor = Color.LawnGreen;
                    theme.TextDefaultFont = new Font("Consolas", 10F, FontStyle.Regular, GraphicsUnit.Point);
                    theme.FlatStyle = FlatStyle.Flat;
                    theme.BorderColor = Color.LawnGreen;
                    theme.BorderSize = 2;
                    theme.RichTextBoxBackColor = Color.Black;
                    break;
                    
                default:
                    break;
            }

            FileCustomSugar.SetControlTheme(form, theme);
        }

    }
}
