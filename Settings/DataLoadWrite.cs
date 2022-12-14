using Sugar;

namespace FileCustom
{
    public static partial class FileCustomSettings
    {
        /// <summary>
        /// "Settings_FileCustom.txt"
        /// </summary>
        public static string SettingsFileName = "Settings_FileCustom.txt";

        /// <summary>
        /// Encoding.Default
        /// </summary>
        public static System.Text.Encoding SettingsEncoding = System.Text.Encoding.Default;

        /// <summary>
        /// ": "
        /// </summary>
        public static string SettingsKeySplitter = ": ";

        /// <summary>
        /// "\n!"
        /// </summary>
        public static string SettingsVariableSplitter = "\n!";

        /// <summary>
        /// "\n"
        /// </summary>
        public static string InputFoldersSplitter = "\n";

        /// <summary>
        /// 6
        /// </summary>
        public static int DistanceBetweenFormControls = 6;

        /// <summary>
        /// "webp"
        /// </summary>
        public static string WebpExtention = "webp";

        /// <summary>
        /// "jpg", "jpeg", "png", "bmp", "gif", "tiff"
        /// </summary>
        public static List<string> ImageExtentions = new List<string>() { "jpg", "jpeg", "png", "bmp", "gif", "tiff" };

        /// <summary>
        /// "Default", "Dark"
        /// </summary>
        public static string[] Themes = new string[] { "Default", "Dark" };

        /// <summary>
        /// "\n!", "?", "*", "\"", "'", ">", "<"
        /// </summary>
        public static string[] UnallowedSymbolsForFoldersPlainText = new string[] { "\n!", "?", "*", "\"", "'", ">", "<" };
        
        /// <summary>
        /// Settings name | value
        /// </summary>
        public static Dictionary<string, string> Settings = new Dictionary<string, string>() {
            { "Main_theme", "" },
            { "DeleteFilesIfEquals_foldersToCompare", "" },
            { "DeleteFilesIfEquals_foldersToDelete", "" },
            { "FindFilesNonUnique_Folders", "" },
            { "FindFilesNonUnique_Compare_maximumPathSquareSize", "" },
            { "FindFilesNonUnique_Compare_pictureSquareSize", "" },
            { "FindFilesNonUnique_Compare_showMessageAfterDeleting", "" },
            { "DeleteEmptyFolders_folders", "" },
        };

        public static void Load()
        {
            Settings = Sugar.SettingsSimple.Load(Settings, SettingsFileName, SettingsEncoding, SettingsVariableSplitter, SettingsKeySplitter);

            if (Settings["Main_theme"].IsNullOrEmpty())
                Settings["Main_theme"] = "Default";
        }

        public static void Write()
        {
            Sugar.SettingsSimple.Write(Settings, SettingsFileName, SettingsEncoding, SettingsVariableSplitter, SettingsKeySplitter);
        }
    }
}
