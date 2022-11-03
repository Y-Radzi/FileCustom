using Sugar;

namespace FileCustom
{
    public class FileCustomRichTextBox: RichTextBox
    {
        public FileCustomRichTextBox(bool useContextMenu, bool allowDragDrop, bool enableTextChangedEvent)
        {
            if (useContextMenu)
                this.AddDefaultShortContextMenu();

            if (allowDragDrop)
            {
                this.AllowDrop = true;
                this.DragDrop += new DragEventHandler(RichTextBoxExtra.DragDrop_Folder);
                this.DragEnter += new DragEventHandler(RichTextBoxExtra.DragEnter_File);
            }

            if (enableTextChangedEvent)
                this.TextChanged += new System.EventHandler(Folders_richTextBox_TextChanged);
        }

        public void Folders_richTextBox_TextChanged(object sender, EventArgs e)
        {
            int selectionStart = ((RichTextBox)sender).SelectionStart;
            ((RichTextBox)sender).Text = ((RichTextBox)sender).Text
                .RemoveWhileEquals(StringExtra.Side.All, FileCustomSettings.UnallowedSymbolsForFoldersPlainText);
            ((RichTextBox)sender).SelectionStart = selectionStart;
        }

    }
}
