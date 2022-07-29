namespace FileCustom
{
    partial class FindFilesNonUnique_Compare_Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.page_numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.page_label = new System.Windows.Forms.Label();
            this.main_panel = new System.Windows.Forms.Panel();
            this.applyActions_button = new System.Windows.Forms.Button();
            this.settings_panel = new System.Windows.Forms.Panel();
            this.showMessageAfterDeleting_checkBox = new System.Windows.Forms.CheckBox();
            this.saveSettings_button = new System.Windows.Forms.Button();
            this.maximumPictureSquareSize_numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.maximumPictureSquareSize_label = new System.Windows.Forms.Label();
            this.maximumPathSquareSize_numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.maximumPathSquareSize_label = new System.Windows.Forms.Label();
            this.showSettings_checkBox = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.page_numericUpDown)).BeginInit();
            this.settings_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.maximumPictureSquareSize_numericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maximumPathSquareSize_numericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // page_numericUpDown
            // 
            this.page_numericUpDown.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.page_numericUpDown.Location = new System.Drawing.Point(314, 14);
            this.page_numericUpDown.Name = "page_numericUpDown";
            this.page_numericUpDown.Size = new System.Drawing.Size(110, 30);
            this.page_numericUpDown.TabIndex = 2;
            this.page_numericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.page_numericUpDown.ValueChanged += new System.EventHandler(this.page_numericUpDown_ValueChanged);
            // 
            // page_label
            // 
            this.page_label.AutoSize = true;
            this.page_label.Location = new System.Drawing.Point(431, 16);
            this.page_label.Name = "page_label";
            this.page_label.Size = new System.Drawing.Size(67, 23);
            this.page_label.TabIndex = 0;
            this.page_label.Text = "Page of";
            // 
            // main_panel
            // 
            this.main_panel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.main_panel.AutoScroll = true;
            this.main_panel.BackColor = System.Drawing.Color.PaleGreen;
            this.main_panel.Location = new System.Drawing.Point(14, 185);
            this.main_panel.Name = "main_panel";
            this.main_panel.Size = new System.Drawing.Size(897, 548);
            this.main_panel.TabIndex = 0;
            // 
            // applyActions_button
            // 
            this.applyActions_button.Location = new System.Drawing.Point(14, 14);
            this.applyActions_button.Name = "applyActions_button";
            this.applyActions_button.Size = new System.Drawing.Size(222, 34);
            this.applyActions_button.TabIndex = 1;
            this.applyActions_button.Text = "Apply page actions";
            this.applyActions_button.UseVisualStyleBackColor = true;
            this.applyActions_button.Click += new System.EventHandler(this.applyActions_button_Click);
            // 
            // settings_panel
            // 
            this.settings_panel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.settings_panel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.settings_panel.Controls.Add(this.showMessageAfterDeleting_checkBox);
            this.settings_panel.Controls.Add(this.saveSettings_button);
            this.settings_panel.Controls.Add(this.maximumPictureSquareSize_numericUpDown);
            this.settings_panel.Controls.Add(this.maximumPictureSquareSize_label);
            this.settings_panel.Controls.Add(this.maximumPathSquareSize_numericUpDown);
            this.settings_panel.Controls.Add(this.maximumPathSquareSize_label);
            this.settings_panel.Location = new System.Drawing.Point(14, 55);
            this.settings_panel.Name = "settings_panel";
            this.settings_panel.Size = new System.Drawing.Size(897, 124);
            this.settings_panel.TabIndex = 0;
            // 
            // showMessageAfterDeleting_checkBox
            // 
            this.showMessageAfterDeleting_checkBox.AutoSize = true;
            this.showMessageAfterDeleting_checkBox.Location = new System.Drawing.Point(228, 84);
            this.showMessageAfterDeleting_checkBox.Name = "showMessageAfterDeleting_checkBox";
            this.showMessageAfterDeleting_checkBox.Size = new System.Drawing.Size(259, 27);
            this.showMessageAfterDeleting_checkBox.TabIndex = 7;
            this.showMessageAfterDeleting_checkBox.Text = "Show message after deleting?";
            this.showMessageAfterDeleting_checkBox.UseVisualStyleBackColor = true;
            this.showMessageAfterDeleting_checkBox.CheckedChanged += new System.EventHandler(this.showMessageAfterDeleting_checkBox_CheckedChanged);
            // 
            // saveSettings_button
            // 
            this.saveSettings_button.Location = new System.Drawing.Point(3, 3);
            this.saveSettings_button.Name = "saveSettings_button";
            this.saveSettings_button.Size = new System.Drawing.Size(218, 74);
            this.saveSettings_button.TabIndex = 4;
            this.saveSettings_button.Text = "Save settings";
            this.saveSettings_button.UseVisualStyleBackColor = true;
            this.saveSettings_button.Click += new System.EventHandler(this.saveSettings_button_Click);
            // 
            // maximumPictureSquareSize_numericUpDown
            // 
            this.maximumPictureSquareSize_numericUpDown.Increment = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.maximumPictureSquareSize_numericUpDown.Location = new System.Drawing.Point(488, 46);
            this.maximumPictureSquareSize_numericUpDown.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.maximumPictureSquareSize_numericUpDown.Minimum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.maximumPictureSquareSize_numericUpDown.Name = "maximumPictureSquareSize_numericUpDown";
            this.maximumPictureSquareSize_numericUpDown.Size = new System.Drawing.Size(253, 30);
            this.maximumPictureSquareSize_numericUpDown.TabIndex = 6;
            this.maximumPictureSquareSize_numericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.maximumPictureSquareSize_numericUpDown.Value = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.maximumPictureSquareSize_numericUpDown.ValueChanged += new System.EventHandler(this.maximumPictureSquareSize_numericUpDown_ValueChanged);
            // 
            // maximumPictureSquareSize_label
            // 
            this.maximumPictureSquareSize_label.AutoSize = true;
            this.maximumPictureSquareSize_label.Location = new System.Drawing.Point(488, 3);
            this.maximumPictureSquareSize_label.Name = "maximumPictureSquareSize_label";
            this.maximumPictureSquareSize_label.Size = new System.Drawing.Size(233, 23);
            this.maximumPictureSquareSize_label.TabIndex = 0;
            this.maximumPictureSquareSize_label.Text = "Maximum picture square size";
            // 
            // maximumPathSquareSize_numericUpDown
            // 
            this.maximumPathSquareSize_numericUpDown.Increment = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.maximumPathSquareSize_numericUpDown.Location = new System.Drawing.Point(228, 46);
            this.maximumPathSquareSize_numericUpDown.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.maximumPathSquareSize_numericUpDown.Minimum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.maximumPathSquareSize_numericUpDown.Name = "maximumPathSquareSize_numericUpDown";
            this.maximumPathSquareSize_numericUpDown.Size = new System.Drawing.Size(253, 30);
            this.maximumPathSquareSize_numericUpDown.TabIndex = 5;
            this.maximumPathSquareSize_numericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.maximumPathSquareSize_numericUpDown.Value = new decimal(new int[] {
            350,
            0,
            0,
            0});
            this.maximumPathSquareSize_numericUpDown.ValueChanged += new System.EventHandler(this.maximumPathSquareSize_numericUpDown_ValueChanged);
            // 
            // maximumPathSquareSize_label
            // 
            this.maximumPathSquareSize_label.AutoSize = true;
            this.maximumPathSquareSize_label.Location = new System.Drawing.Point(228, 3);
            this.maximumPathSquareSize_label.Name = "maximumPathSquareSize_label";
            this.maximumPathSquareSize_label.Size = new System.Drawing.Size(215, 23);
            this.maximumPathSquareSize_label.TabIndex = 0;
            this.maximumPathSquareSize_label.Text = "Maximum path square size";
            // 
            // showSettings_checkBox
            // 
            this.showSettings_checkBox.AutoSize = true;
            this.showSettings_checkBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.showSettings_checkBox.Location = new System.Drawing.Point(778, 14);
            this.showSettings_checkBox.Name = "showSettings_checkBox";
            this.showSettings_checkBox.Size = new System.Drawing.Size(133, 27);
            this.showSettings_checkBox.TabIndex = 3;
            this.showSettings_checkBox.Text = "Show settings";
            this.showSettings_checkBox.UseVisualStyleBackColor = true;
            this.showSettings_checkBox.CheckedChanged += new System.EventHandler(this.showSettings_checkBox_CheckedChanged);
            // 
            // FindFilesNonUnique_Compare_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(923, 745);
            this.Controls.Add(this.showSettings_checkBox);
            this.Controls.Add(this.settings_panel);
            this.Controls.Add(this.applyActions_button);
            this.Controls.Add(this.main_panel);
            this.Controls.Add(this.page_label);
            this.Controls.Add(this.page_numericUpDown);
            this.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name = "FindFilesNonUnique_Compare_Form";
            this.Text = "Files compare";
            this.SizeChanged += new System.EventHandler(this.FindFilesNonUnique_ImageCompare_SizeChanged);
            ((System.ComponentModel.ISupportInitialize)(this.page_numericUpDown)).EndInit();
            this.settings_panel.ResumeLayout(false);
            this.settings_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.maximumPictureSquareSize_numericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maximumPathSquareSize_numericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private NumericUpDown page_numericUpDown;
        private Label page_label;
        private Panel main_panel;
        private Button applyActions_button;
        private Panel settings_panel;
        private CheckBox showSettings_checkBox;
        private NumericUpDown maximumPictureSquareSize_numericUpDown;
        private Label maximumPictureSquareSize_label;
        private NumericUpDown maximumPathSquareSize_numericUpDown;
        private Label maximumPathSquareSize_label;
        private Button saveSettings_button;
        private CheckBox showMessageAfterDeleting_checkBox;
    }
}