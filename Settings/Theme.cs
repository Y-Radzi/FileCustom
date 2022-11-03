namespace FileCustom
{
    public static partial class FileCustomSettings
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

        public static void SetTheme(Form form)
        {
            var theme = new ThemeStruct();
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
                    
                default: //"Default"
                    break;
            }

            SetControlTheme(form, theme);
        }

        private static void SetControlTheme(Control control, ThemeStruct theme)
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
