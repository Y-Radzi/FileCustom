namespace FileCustom
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.DeleteFilesIfEquals_button = new System.Windows.Forms.Button();
            this.FindFilesNonUnique_button = new System.Windows.Forms.Button();
            this.themes_comboBox = new System.Windows.Forms.ComboBox();
            this.theme_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // DeleteFilesIfEquals_button
            // 
            this.DeleteFilesIfEquals_button.Location = new System.Drawing.Point(306, 14);
            this.DeleteFilesIfEquals_button.Name = "DeleteFilesIfEquals_button";
            this.DeleteFilesIfEquals_button.Size = new System.Drawing.Size(234, 33);
            this.DeleteFilesIfEquals_button.TabIndex = 1;
            this.DeleteFilesIfEquals_button.Text = "Delete files if equals";
            this.DeleteFilesIfEquals_button.UseVisualStyleBackColor = true;
            this.DeleteFilesIfEquals_button.Click += new System.EventHandler(this.DeleteFilesIfEquals_button_Click);
            // 
            // FindFilesNonUnique_button
            // 
            this.FindFilesNonUnique_button.Location = new System.Drawing.Point(547, 14);
            this.FindFilesNonUnique_button.Name = "FindFilesNonUnique_button";
            this.FindFilesNonUnique_button.Size = new System.Drawing.Size(234, 33);
            this.FindFilesNonUnique_button.TabIndex = 2;
            this.FindFilesNonUnique_button.Text = "Find non unique files";
            this.FindFilesNonUnique_button.UseVisualStyleBackColor = true;
            this.FindFilesNonUnique_button.Click += new System.EventHandler(this.FindFilesNonUnique_button_Click);
            // 
            // themes_comboBox
            // 
            this.themes_comboBox.FormattingEnabled = true;
            this.themes_comboBox.Location = new System.Drawing.Point(14, 37);
            this.themes_comboBox.Name = "themes_comboBox";
            this.themes_comboBox.Size = new System.Drawing.Size(234, 31);
            this.themes_comboBox.TabIndex = 3;
            this.themes_comboBox.SelectedIndexChanged += new System.EventHandler(this.themes_comboBox_SelectedIndexChanged);
            // 
            // theme_label
            // 
            this.theme_label.AutoSize = true;
            this.theme_label.Location = new System.Drawing.Point(14, 10);
            this.theme_label.Name = "theme_label";
            this.theme_label.Size = new System.Drawing.Size(62, 23);
            this.theme_label.TabIndex = 4;
            this.theme_label.Text = "Theme";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(794, 100);
            this.Controls.Add(this.theme_label);
            this.Controls.Add(this.themes_comboBox);
            this.Controls.Add(this.FindFilesNonUnique_button);
            this.Controls.Add(this.DeleteFilesIfEquals_button);
            this.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button DeleteFilesIfEquals_button;
        private Button FindFilesNonUnique_button;
        private ComboBox themes_comboBox;
        private Label theme_label;
    }
}