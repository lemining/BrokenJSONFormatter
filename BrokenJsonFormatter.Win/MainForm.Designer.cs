namespace BrokenJsonFormatter.Win
{
    partial class MainForm
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
            this.OpenFileLabel = new System.Windows.Forms.Label();
            this.openFileBtn = new System.Windows.Forms.Button();
            this.FormatAndSaveLabel = new System.Windows.Forms.Label();
            this.formatAndSaveBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // OpenFileLabel
            // 
            this.OpenFileLabel.AutoSize = true;
            this.OpenFileLabel.Location = new System.Drawing.Point(47, 38);
            this.OpenFileLabel.Name = "OpenFileLabel";
            this.OpenFileLabel.Size = new System.Drawing.Size(176, 13);
            this.OpenFileLabel.TabIndex = 0;
            this.OpenFileLabel.Text = "1. Select broken JSON file to format";
            // 
            // openFileBtn
            // 
            this.openFileBtn.Location = new System.Drawing.Point(50, 64);
            this.openFileBtn.Name = "openFileBtn";
            this.openFileBtn.Size = new System.Drawing.Size(173, 23);
            this.openFileBtn.TabIndex = 1;
            this.openFileBtn.Text = "Open File";
            this.openFileBtn.UseVisualStyleBackColor = true;
            this.openFileBtn.Click += new System.EventHandler(this.openFileBtn_Click);
            // 
            // FormatAndSaveLabel
            // 
            this.FormatAndSaveLabel.AutoSize = true;
            this.FormatAndSaveLabel.Location = new System.Drawing.Point(47, 108);
            this.FormatAndSaveLabel.Name = "FormatAndSaveLabel";
            this.FormatAndSaveLabel.Size = new System.Drawing.Size(100, 13);
            this.FormatAndSaveLabel.TabIndex = 2;
            this.FormatAndSaveLabel.Text = "2. Format and Save";
            // 
            // formatAndSaveBtn
            // 
            this.formatAndSaveBtn.Location = new System.Drawing.Point(50, 134);
            this.formatAndSaveBtn.Name = "formatAndSaveBtn";
            this.formatAndSaveBtn.Size = new System.Drawing.Size(173, 23);
            this.formatAndSaveBtn.TabIndex = 3;
            this.formatAndSaveBtn.Text = "Format and Save";
            this.formatAndSaveBtn.UseVisualStyleBackColor = true;
            this.formatAndSaveBtn.Click += new System.EventHandler(this.formatAndSaveBtn_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.formatAndSaveBtn);
            this.Controls.Add(this.FormatAndSaveLabel);
            this.Controls.Add(this.openFileBtn);
            this.Controls.Add(this.OpenFileLabel);
            this.Name = "MainForm";
            this.Text = "Broken Json Formatter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label OpenFileLabel;
        private System.Windows.Forms.Button openFileBtn;
        private System.Windows.Forms.Label FormatAndSaveLabel;
        private System.Windows.Forms.Button formatAndSaveBtn;

    }
}

