namespace FileCustom
{
    public partial class FileCustomForm : Form
    {
        public NotifyIcon notifyIcon { get; set; }

        public void InitializeFileCustomForm()
        {
            notifyIcon = new NotifyIcon();
            notifyIcon.Text = "FileCustom." + this.Text;
            notifyIcon.Visible = false;
            notifyIcon.Icon = FileCustom.Properties.Resources.IconMain;
            notifyIcon.MouseClick += new MouseEventHandler(this.notifyIcon_MouseClick);

            FileCustomSettings.SetTheme(this);

            this.Deactivate += new EventHandler(this.Form_Deactivate);
        }

        private void Form_Deactivate(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                this.ShowInTaskbar = false;
                notifyIcon.Visible = true;
            }
        }

        private void notifyIcon_MouseClick(object sender, MouseEventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                this.WindowState = FormWindowState.Normal;
                this.ShowInTaskbar = true;
                notifyIcon.Visible = false;
            }
        }
    }
}
