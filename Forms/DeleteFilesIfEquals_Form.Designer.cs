namespace FileCustom
{
    partial class DeleteFilesIfEquals_Form
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
            this.foldersToCompare_richTextBox = new FileCustomRichTextBox(true, true, true);
            this.foldersToCompare_label = new System.Windows.Forms.Label();
            this.foldersToDelete_label = new System.Windows.Forms.Label();
            this.foldersToDelete_richTextBox = new FileCustomRichTextBox(true, true, true);
            this.result_richTextBox = new FileCustomRichTextBox(true, false, false);
            this.result_label = new System.Windows.Forms.Label();
            this.go_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // foldersToCompare_richTextBox
            // 
            this.foldersToCompare_richTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.foldersToCompare_richTextBox.Location = new System.Drawing.Point(14, 37);
            this.foldersToCompare_richTextBox.Name = "foldersToCompare_richTextBox";
            this.foldersToCompare_richTextBox.Size = new System.Drawing.Size(911, 137);
            this.foldersToCompare_richTextBox.TabIndex = 1;
            this.foldersToCompare_richTextBox.Text = "";
            // 
            // foldersToCompare_label
            // 
            this.foldersToCompare_label.AutoSize = true;
            this.foldersToCompare_label.Location = new System.Drawing.Point(14, 10);
            this.foldersToCompare_label.Name = "foldersToCompare_label";
            this.foldersToCompare_label.Size = new System.Drawing.Size(157, 23);
            this.foldersToCompare_label.TabIndex = 0;
            this.foldersToCompare_label.Text = "Folders to compare";
            // 
            // foldersToDelete_label
            // 
            this.foldersToDelete_label.AutoSize = true;
            this.foldersToDelete_label.Location = new System.Drawing.Point(14, 196);
            this.foldersToDelete_label.Name = "foldersToDelete_label";
            this.foldersToDelete_label.Size = new System.Drawing.Size(380, 23);
            this.foldersToDelete_label.TabIndex = 0;
            this.foldersToDelete_label.Text = "Folders to delete (auto-excludes comparing files)";
            // 
            // foldersToDelete_richTextBox
            // 
            this.foldersToDelete_richTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.foldersToDelete_richTextBox.Location = new System.Drawing.Point(14, 222);
            this.foldersToDelete_richTextBox.Name = "foldersToDelete_richTextBox";
            this.foldersToDelete_richTextBox.Size = new System.Drawing.Size(911, 137);
            this.foldersToDelete_richTextBox.TabIndex = 2;
            this.foldersToDelete_richTextBox.Text = "";
            // 
            // result_richTextBox
            // 
            this.result_richTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.result_richTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.result_richTextBox.Location = new System.Drawing.Point(14, 430);
            this.result_richTextBox.Name = "result_richTextBox";
            this.result_richTextBox.ReadOnly = true;
            this.result_richTextBox.Size = new System.Drawing.Size(911, 232);
            this.result_richTextBox.TabIndex = 4;
            this.result_richTextBox.Text = "";
            // 
            // result_label
            // 
            this.result_label.AutoSize = true;
            this.result_label.Location = new System.Drawing.Point(14, 404);
            this.result_label.Name = "result_label";
            this.result_label.Size = new System.Drawing.Size(56, 23);
            this.result_label.TabIndex = 0;
            this.result_label.Text = "Result";
            // 
            // go_button
            // 
            this.go_button.Location = new System.Drawing.Point(14, 367);
            this.go_button.Name = "go_button";
            this.go_button.Size = new System.Drawing.Size(261, 33);
            this.go_button.TabIndex = 3;
            this.go_button.Text = "Go";
            this.go_button.UseVisualStyleBackColor = true;
            this.go_button.Click += new System.EventHandler(this.go_button_Click);
            // 
            // DeleteFilesIfEquals_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(938, 676);
            this.Controls.Add(this.go_button);
            this.Controls.Add(this.result_label);
            this.Controls.Add(this.result_richTextBox);
            this.Controls.Add(this.foldersToDelete_richTextBox);
            this.Controls.Add(this.foldersToDelete_label);
            this.Controls.Add(this.foldersToCompare_label);
            this.Controls.Add(this.foldersToCompare_richTextBox);
            this.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name = "DeleteFilesIfEquals_Form";
            this.Text = "DeleteFilesIfEquals";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FileCustomRichTextBox foldersToCompare_richTextBox;
        private Label foldersToCompare_label;
        private Label foldersToDelete_label;
        private FileCustomRichTextBox foldersToDelete_richTextBox;
        private FileCustomRichTextBox result_richTextBox;
        private Label result_label;
        private Button go_button;
    }
}