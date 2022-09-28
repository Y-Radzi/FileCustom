namespace FileCustom
{
    partial class FindFilesNonUnique_Form
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
            this.result_richTextBox = new System.Windows.Forms.RichTextBox();
            this.result_label = new System.Windows.Forms.Label();
            this.runCompare_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // folders_label
            // 
            this.folders_label.AutoSize = true;
            this.folders_label.Location = new System.Drawing.Point(14, 10);
            this.folders_label.Name = "folders_label";
            this.folders_label.Size = new System.Drawing.Size(64, 23);
            this.folders_label.TabIndex = 0;
            this.folders_label.Text = "Folders";
            // 
            // folders_richTextBox
            // 
            this.folders_richTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.folders_richTextBox.Location = new System.Drawing.Point(14, 37);
            this.folders_richTextBox.Name = "folders_richTextBox";
            this.folders_richTextBox.Size = new System.Drawing.Size(1004, 98);
            this.folders_richTextBox.TabIndex = 1;
            this.folders_richTextBox.Text = "";
            this.folders_richTextBox.TextChanged += new System.EventHandler(this.folders_richTextBox_TextChanged);
            // 
            // go_button
            // 
            this.go_button.Location = new System.Drawing.Point(14, 143);
            this.go_button.Name = "go_button";
            this.go_button.Size = new System.Drawing.Size(218, 33);
            this.go_button.TabIndex = 2;
            this.go_button.Text = "Go find";
            this.go_button.UseVisualStyleBackColor = true;
            this.go_button.Click += new System.EventHandler(this.go_button_Click);
            // 
            // result_richTextBox
            // 
            this.result_richTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.result_richTextBox.Location = new System.Drawing.Point(14, 206);
            this.result_richTextBox.Name = "result_richTextBox";
            this.result_richTextBox.ReadOnly = true;
            this.result_richTextBox.Size = new System.Drawing.Size(1004, 494);
            this.result_richTextBox.TabIndex = 3;
            this.result_richTextBox.Text = "";
            // 
            // result_label
            // 
            this.result_label.AutoSize = true;
            this.result_label.Location = new System.Drawing.Point(14, 179);
            this.result_label.Name = "result_label";
            this.result_label.Size = new System.Drawing.Size(56, 23);
            this.result_label.TabIndex = 4;
            this.result_label.Text = "Result";
            // 
            // runCompare_button
            // 
            this.runCompare_button.Location = new System.Drawing.Point(238, 143);
            this.runCompare_button.Name = "runCompare_button";
            this.runCompare_button.Size = new System.Drawing.Size(218, 33);
            this.runCompare_button.TabIndex = 5;
            this.runCompare_button.Text = "Run compare";
            this.runCompare_button.UseVisualStyleBackColor = true;
            this.runCompare_button.Click += new System.EventHandler(this.runCompare_button_Click);
            // 
            // FindFilesNonUnique_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1032, 715);
            this.Controls.Add(this.runCompare_button);
            this.Controls.Add(this.result_label);
            this.Controls.Add(this.result_richTextBox);
            this.Controls.Add(this.go_button);
            this.Controls.Add(this.folders_richTextBox);
            this.Controls.Add(this.folders_label);
            this.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name = "FindFilesNonUnique_Form";
            this.Text = "FindFilesNonUnique";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label folders_label;
        private RichTextBox folders_richTextBox;
        private Button go_button;
        private RichTextBox result_richTextBox;
        private Label result_label;
        private Button runCompare_button;
    }
}