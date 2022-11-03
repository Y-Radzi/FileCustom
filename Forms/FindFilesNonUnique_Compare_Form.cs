using Sugar;

namespace FileCustom
{
    public partial class FindFilesNonUnique_Compare_Form : FileCustomForm
    {
        private Sugar.FileCustom.ComparaisonLogGroup groupFiles = new();
        private bool isSettingsComtrolsActionsDisabled = false;

        public FindFilesNonUnique_Compare_Form(Sugar.FileCustom.ComparaisonLogGroup groupFilesInput)
        {
            InitializeComponent();
            InitializeFileCustomForm();

            showSettings_checkBox_CheckedChanged(null, null);

            if (!groupFilesInput.IsEmpty())
                foreach (var element in groupFilesInput.Elements)
                    if (!element.IsEmpty())
                        groupFiles.Elements.Add(element);

            getApplySettingsToControls(true);
            ifGroupFilesChanged();
            updatePage();
        }

        private void getApplySettingsToControls(bool isApply)
        {
            isSettingsComtrolsActionsDisabled = true;
            FileCustomSettings.GetApplyToControl(isApply, "FindFilesNonUnique_Compare_maximumPathSquareSize", maximumPathSquareSize_numericUpDown);
            FileCustomSettings.GetApplyToControl(isApply, "FindFilesNonUnique_Compare_pictureSquareSize", maximumPictureSquareSize_numericUpDown);
            FileCustomSettings.GetApplyToControl(isApply, "FindFilesNonUnique_Compare_showMessageAfterDeleting", showMessageAfterDeleting_checkBox);
            isSettingsComtrolsActionsDisabled = false;
        }

        private void ifGroupFilesChanged()
        {
            if (!groupFiles.IsEmpty())
            {
                groupFiles.RemoveIfNotExists();
                groupFiles.RemoveIfSingle();
            }
            int count = (groupFiles.IsEmpty()) ? 1 : groupFiles.Elements.Count;
            int page_numericMinimum = 1;

            page_label.Text = $"Page of {count}";

            if (page_numericUpDown.Value > count)
                page_numericUpDown.Value = count;
            else if (page_numericUpDown.Value < page_numericMinimum)
                page_numericUpDown.Value = page_numericMinimum;

            page_numericUpDown.Maximum = count;
            page_numericUpDown.Minimum = page_numericMinimum;
            updatePage();
        }

        private void updatePage()
        {
            main_panel.Controls.Clear();
            getApplySettingsToControls(false);
            if (!groupFiles.IsEmpty())
            {
                var files = groupFiles.Elements[page_numericUpDown.Value.ToInt32() - 1].GetMainAndCompared();
                int maximumPathSquareSize = FileCustomSettings.Settings["FindFilesNonUnique_Compare_maximumPathSquareSize"].ToInt32();
                int pictureSquareSize = FileCustomSettings.Settings["FindFilesNonUnique_Compare_pictureSquareSize"].ToInt32();

                var bitmap = FileCustomSugar.GetFileBitmap(
                    files[0], //first file, files are same
                    FileExtra.IsAnyFileHasExtention(files, FileCustomSettings.ImageExtentions),
                    FileExtra.IsAnyFileHasExtention(files, new List<string>() { FileCustomSettings.WebpExtention })
                    );

                for (int i = 0; i < files.Count; i++)
                {
                    ///////////////////////////////////////////Element panel
                    var panel = new Panel()
                    {
                        Name = files[i],
                        AutoScroll = true,
                        AutoSize = true,
                        AutoSizeMode = AutoSizeMode.GrowAndShrink,
                    };

                    ///////////////////////////////////////////Label
                    string linkLabelLink = (true) ? FileExtra.GetFileFolder(files[i]) : files[i]; //(true) - replace in future

                    var linkLabel = new LinkLabel()
                    {
                        MaximumSize = new Size(maximumPathSquareSize, maximumPathSquareSize),
                        AutoSize = true,
                        Name = "path_label",
                        Text = files[i],
                        Font = this.Font,
                        ForeColor = this.ForeColor,
                    };
                    linkLabel.Links.Add(0, linkLabelLink.Length, linkLabelLink);
                    linkLabel.AddFileNameCopyContextMenu();
                    linkLabel.LinkClicked += new LinkLabelLinkClickedEventHandler(LinkLabelExtra.LinkLabelClickedSimple);
                    panel.Controls.Add(linkLabel);
                        
                    ///////////////////////////////////////////Radio buttons
                    var groupBox = new GroupBox()
                    {
                        Name = "groupBox",
                        AutoSize = true,
                        Text = "Action",
                        Font = this.Font,
                        ForeColor = this.ForeColor
                    };
                    groupBox.Controls.Add(new RadioButton()
                    {
                        Location = new Point(31, 20),
                        Name = "keep_RadioButton",
                        AutoSize = true,
                        Text = "Keep",
                        Checked = true,
                        Font = this.Font,
                        ForeColor = this.ForeColor
                    });
                    groupBox.Controls.Add(new RadioButton()
                    {
                        Location = new Point(31, 53),
                        Name = "delete_RadioButton",
                        AutoSize = true,
                        Text = "Delete",
                        Checked = false,
                        Font = this.Font,
                        ForeColor = this.ForeColor
                    });
                    panel.Controls.Add(groupBox);

                    ///////////////////////////////////////////Image
                    if (bitmap != null)
                    {
                        var pictureBox = new PictureBox()
                        {
                            Size = new Size(pictureSquareSize, pictureSquareSize),
                            SizeMode = PictureBoxSizeMode.Zoom,
                            Name = "pictureBox",
                            Image = bitmap
                        };

                        pictureBox.DoubleClick += new System.EventHandler(openFile);

                        panel.Controls.Add(pictureBox);
                    }
                    panel.AlignChildControlsVertical(FileCustomSettings.DistanceBetweenFormControls);
                    main_panel.Controls.Add(panel);
                }
            }
            main_panel.AlignChildControlsByMaxSizeGrid(FileCustomSettings.DistanceBetweenFormControls, true);
        }

        private void openFile(object sender, EventArgs e)
        {
            using System.Diagnostics.Process fileopener = new System.Diagnostics.Process();
            string filepath = (sender as PictureBox).Parent.Controls.Find("path_label", false)[0].Text;
            fileopener.StartInfo.FileName = "explorer.exe";
            fileopener.StartInfo.Arguments = "\"" + filepath + "\"";
            fileopener.Start();
            //MessageBox.Show(filepath);
        }

        private void applyNonLoadableSetting()
        {
            getApplySettingsToControls(false);
            int maximumPathSquareSize = FileCustomSettings.Settings["FindFilesNonUnique_Compare_maximumPathSquareSize"].ToInt32();
            int pictureSquareSize = FileCustomSettings.Settings["FindFilesNonUnique_Compare_pictureSquareSize"].ToInt32();
            var newMaxPathSize = new Size(maximumPathSquareSize, maximumPathSquareSize);
            var newPictureSize = new Size(pictureSquareSize, pictureSquareSize);
            foreach (Panel panel in main_panel.Controls)
            {
                panel.Controls["path_label"].MaximumSize = newMaxPathSize;
                panel.Controls["pictureBox"].Size = newPictureSize;
                panel.AlignChildControlsVertical(FileCustomSettings.DistanceBetweenFormControls);
            }
            main_panel.AlignChildControlsByMaxSizeGrid(FileCustomSettings.DistanceBetweenFormControls, true);
        }

        private void page_numericUpDown_ValueChanged(object sender, EventArgs e)
        {
            ifGroupFilesChanged();
        }

        private void applyActions_button_Click(object sender, EventArgs e)
        {
            var index = page_numericUpDown.Value.ToInt32() - 1;
            var deletedFiles = new List<string>();
            foreach (Panel panel in main_panel.Controls)
            {
                if (
                    ((RadioButton)((GroupBox)panel.Controls["groupBox"]).Controls["delete_RadioButton"]).Checked
                    && !((RadioButton)((GroupBox)panel.Controls["groupBox"]).Controls["keep_RadioButton"]).Checked
                )
                {
                    FileCustomSugar.DeleteFile(panel.Name, true);
                    deletedFiles.Add(panel.Name);
                }
            }

            bool isShowMessageAfterDeleting = FileCustomSettings.Settings["FindFilesNonUnique_Compare_showMessageAfterDeleting"].ToBool();
            if (deletedFiles.Count > 0)
            {
                if (isShowMessageAfterDeleting)
                    MessageBox.Show($"Files deleted to recycle bin: {Environment.NewLine} {deletedFiles.Display()}");
            }
            else if (isShowMessageAfterDeleting)
                MessageBox.Show("Nothing files deleted");

            ifGroupFilesChanged();
        }

        private void FindFilesNonUnique_ImageCompare_SizeChanged(object sender, EventArgs e)
        {
            main_panel.AlignChildControlsByMaxSizeGrid(FileCustomSettings.DistanceBetweenFormControls, true);
        }

        private void showSettings_checkBox_CheckedChanged(object? sender, EventArgs? e)
        {
            int oldDiff = this.Height - main_panel.GetPointLeftBottom().Y;

            if (showSettings_checkBox.Checked)
            {
                settings_panel.Visible = true;
                main_panel.Location = new Point(
                    main_panel.Location.X,
                    settings_panel.Location.Y + settings_panel.Size.Height + FileCustomSettings.DistanceBetweenFormControls);
            }
            else
            {
                settings_panel.Visible = false;
                main_panel.Location = new Point(main_panel.Location.X, settings_panel.Location.Y);
            }

            var tempAnchor = main_panel.Anchor;
            main_panel.Anchor = AnchorStyles.None;

            main_panel.Size = new Size(main_panel.Size.Width,
                    this.Height - main_panel.Location.Y - oldDiff);

            main_panel.Anchor = tempAnchor;
        }

        private void maximumPathSquareSize_numericUpDown_ValueChanged(object sender, EventArgs e)
        {
            if (!isSettingsComtrolsActionsDisabled)
                applyNonLoadableSetting();
        }

        private void maximumPictureSquareSize_numericUpDown_ValueChanged(object sender, EventArgs e)
        {
            if (!isSettingsComtrolsActionsDisabled)
                applyNonLoadableSetting();
        }

        private void showMessageAfterDeleting_checkBox_CheckedChanged(object sender, EventArgs e)
        {
            if (!isSettingsComtrolsActionsDisabled)
                getApplySettingsToControls(false);
        }

        private void saveSettings_button_Click(object sender, EventArgs e)
        {
            getApplySettingsToControls(false);
            FileCustomSettings.Write();
        }

        private void selectAllElementsTo(bool isDeleted)
        {
            bool delete_RadioButton_value = isDeleted;
            bool keep_RadioButton_value = !isDeleted;

            foreach (Panel panel in main_panel.Controls)
            {
                ((RadioButton)((GroupBox)panel.Controls["groupBox"]).Controls["delete_RadioButton"]).Checked = delete_RadioButton_value;
                ((RadioButton)((GroupBox)panel.Controls["groupBox"]).Controls["keep_RadioButton"]).Checked = keep_RadioButton_value;
            }
        }

        private void SelectAllKeep_button_Click(object sender, EventArgs e)
        {
            selectAllElementsTo(false);
        }

        private void SelectAllDelete_button_Click(object sender, EventArgs e)
        {
            selectAllElementsTo(true);
        }
    }
}
