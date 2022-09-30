namespace FileCustom
{
    partial class DeleteEmptyFolders
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
            this.folders_label = new System.Windows.Forms.Label();
            this.folders_richTextBox = new System.Windows.Forms.RichTextBox();
            this.go_button = new System.Windows.Forms.Button();
            this.result_label = new System.Windows.Forms.Label();
            this.result_richTextBox = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // folders_label
            // 
            this.folders_label.AutoSize = true;
            this.folders_label.Location = new System.Drawing.Point(12, 9);
            this.folders_label.Name = "folders_label";
            this.folders_label.Size = new System.Drawing.Size(57, 20);
            this.folders_label.TabIndex = 1;
            this.folders_label.Text = "Folders";
            // 
            // folders_richTextBox
            // 
            this.folders_richTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.folders_richTextBox.Location = new System.Drawing.Point(12, 32);
            this.folders_richTextBox.Name = "folders_richTextBox";
            this.folders_richTextBox.Size = new System.Drawing.Size(880, 137);
            this.folders_richTextBox.TabIndex = 2;
            this.folders_richTextBox.Text = "";
            this.folders_richTextBox.TextChanged += new System.EventHandler(this.folders_richTextBox_TextChanged);
            // 
            // go_button
            // 
            this.go_button.Location = new System.Drawing.Point(12, 175);
            this.go_button.Name = "go_button";
            this.go_button.Size = new System.Drawing.Size(261, 33);
            this.go_button.TabIndex = 4;
            this.go_button.Text = "Go";
            this.go_button.UseVisualStyleBackColor = true;
            this.go_button.Click += new System.EventHandler(this.go_button_Click);
            // 
            // result_label
            // 
            this.result_label.AutoSize = true;
            this.result_label.Location = new System.Drawing.Point(12, 211);
            this.result_label.Name = "result_label";
            this.result_label.Size = new System.Drawing.Size(49, 20);
            this.result_label.TabIndex = 5;
            this.result_label.Text = "Result";
            // 
            // result_richTextBox
            // 
            this.result_richTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.result_richTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.result_richTextBox.Location = new System.Drawing.Point(12, 234);
            this.result_richTextBox.Name = "result_richTextBox";
            this.result_richTextBox.ReadOnly = true;
            this.result_richTextBox.Size = new System.Drawing.Size(880, 290);
            this.result_richTextBox.TabIndex = 6;
            this.result_richTextBox.Text = "";
            // 
            // DeleteEmptyFolders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(904, 536);
            this.Controls.Add(this.result_richTextBox);
            this.Controls.Add(this.result_label);
            this.Controls.Add(this.go_button);
            this.Controls.Add(this.folders_richTextBox);
            this.Controls.Add(this.folders_label);
            this.Name = "DeleteEmptyFolders";
            this.Text = "DeleteEmptyFolders";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label folders_label;
        private RichTextBox folders_richTextBox;
        private Button go_button;
        private Label result_label;
        private RichTextBox result_richTextBox;
    }
}