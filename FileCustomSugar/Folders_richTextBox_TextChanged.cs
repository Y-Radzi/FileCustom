using Sugar;

namespace FileCustom
{
    public static partial class FileCustomSugar
    {
        public static void Folders_richTextBox_TextChanged(object sender, EventArgs e)
        {
            int selectionStart = (sender as RichTextBox).SelectionStart;
            (sender as RichTextBox).Text = (sender as RichTextBox).Text
                .RemoveWhileEquals(StringExtra.Side.All, FileCustomSettings.UnallowedSymbolsForFoldersPlainText);
            (sender as RichTextBox).SelectionStart = selectionStart;
        }
    }
}
