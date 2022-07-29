namespace FileCustom
{
    public static partial class FileCustomSugar
    {
        public struct ThemeStruct
        {
            public Control Control;
            public Color BackColor;
            public Color ForeColor;
            public Font TextDefaultFont;
            public FlatStyle FlatStyle;
            public Color BorderColor;
            public int BorderSize;
            public Color RichTextBoxBackColor;
        }

        public static void SetControlTheme(Control control, ThemeStruct theme)
        {
            control.BackColor = theme.BackColor;
            control.Font = theme.TextDefaultFont;
            control.ForeColor = theme.ForeColor;

            if (control is Button)
            {
                ((Button)control).FlatStyle = theme.FlatStyle;
                ((Button)control).FlatAppearance.BorderColor = theme.BorderColor;
                ((Button)control).FlatAppearance.BorderSize = theme.BorderSize;
            }
            else if (control is RichTextBox)
            {
                if (!((RichTextBox)control).ReadOnly)
                    ((RichTextBox)control).BackColor = theme.RichTextBoxBackColor;
            }

            foreach (Control childControl in control.Controls)
                SetControlTheme(childControl, theme);
        }

    }
}
