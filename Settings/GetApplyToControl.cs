using Sugar;

namespace FileCustom
{
    public static partial class FileCustomSettings
    {
        public static void GetApplyToControl(bool isApply, string settingName, RichTextBox richTextBox)
        {
            if (isApply)
                richTextBox.Text = Settings[settingName];
            else
                Settings[settingName] = richTextBox.Text;
        }

        public static void GetApplyToControl(bool isApply, string settingName, NumericUpDown numericUpDown)
        {
            if (isApply)
            {
                if (!Settings[settingName].IsNullOrEmpty())
                    numericUpDown.Value = Convert.ToDecimal(Settings[settingName]);
            }
            else
                Settings[settingName] = numericUpDown.Value.ToString();
        }

        public static void GetApplyToControl(bool isApply, string settingName, CheckBox checkBox)
        {
            if (isApply)
            {
                if (!Settings[settingName].IsNullOrEmpty())
                    checkBox.Checked = Settings[settingName].ToBool();
            }
            else
                Settings[settingName] = checkBox.Checked.ToString();
        }

    }
}
