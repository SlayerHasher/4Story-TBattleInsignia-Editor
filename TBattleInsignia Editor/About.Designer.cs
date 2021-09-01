
namespace TBattleInsignia_Editor
{
    partial class About
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(About));
            this.PictureBox = new System.Windows.Forms.PictureBox();
            this.TcdLabel = new System.Windows.Forms.Label();
            this.CopyrightLabel = new System.Windows.Forms.Label();
            this.MyGitHubLinkLabel = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // PictureBox
            // 
            this.PictureBox.Image = global::TBattleInsignia_Editor.Properties.Resources.TBattleInsignia;
            this.PictureBox.Location = new System.Drawing.Point(12, 12);
            this.PictureBox.Name = "PictureBox";
            this.PictureBox.Size = new System.Drawing.Size(66, 62);
            this.PictureBox.TabIndex = 0;
            this.PictureBox.TabStop = false;
            // 
            // TcdLabel
            // 
            this.TcdLabel.AutoSize = true;
            this.TcdLabel.Location = new System.Drawing.Point(84, 28);
            this.TcdLabel.Name = "TcdLabel";
            this.TcdLabel.Size = new System.Drawing.Size(320, 17);
            this.TcdLabel.TabIndex = 1;
            this.TcdLabel.Text = "This is tool for edit 4Story TBattleInsignia Tcd file.";
            // 
            // CopyrightLabel
            // 
            this.CopyrightLabel.AutoSize = true;
            this.CopyrightLabel.Location = new System.Drawing.Point(84, 45);
            this.CopyrightLabel.Name = "CopyrightLabel";
            this.CopyrightLabel.Size = new System.Drawing.Size(329, 17);
            this.CopyrightLabel.TabIndex = 2;
            this.CopyrightLabel.Text = "Copyright ©                        2021. All right reserved.";
            // 
            // MyGitHubLinkLabel
            // 
            this.MyGitHubLinkLabel.AutoSize = true;
            this.MyGitHubLinkLabel.Location = new System.Drawing.Point(164, 45);
            this.MyGitHubLinkLabel.Name = "MyGitHubLinkLabel";
            this.MyGitHubLinkLabel.Size = new System.Drawing.Size(94, 17);
            this.MyGitHubLinkLabel.TabIndex = 3;
            this.MyGitHubLinkLabel.TabStop = true;
            this.MyGitHubLinkLabel.Text = "SlayerHasher";
            this.MyGitHubLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.MyGitHubLinkLabel_LinkClicked);
            // 
            // About
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(413, 87);
            this.Controls.Add(this.MyGitHubLinkLabel);
            this.Controls.Add(this.CopyrightLabel);
            this.Controls.Add(this.TcdLabel);
            this.Controls.Add(this.PictureBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "About";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "About TBattleInsignia";
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PictureBox;
        private System.Windows.Forms.Label TcdLabel;
        private System.Windows.Forms.Label CopyrightLabel;
        private System.Windows.Forms.LinkLabel MyGitHubLinkLabel;
    }
}