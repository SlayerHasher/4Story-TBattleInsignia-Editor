
namespace TBattleInsignia_Editor
{
    partial class TBattleInsignia_Editor
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TBattleInsignia_Editor));
            this.MenuStrip = new System.Windows.Forms.MenuStrip();
            this.FileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SearchTextBox = new System.Windows.Forms.TextBox();
            this.ListBox = new System.Windows.Forms.ListBox();
            this.StatusStrip = new System.Windows.Forms.StatusStrip();
            this.CountToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.TabToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.CopyrightToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.PointTextBox = new System.Windows.Forms.TextBox();
            this.PointLabel = new System.Windows.Forms.Label();
            this.SaveButton = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.OFD = new System.Windows.Forms.OpenFileDialog();
            this.SFD = new System.Windows.Forms.SaveFileDialog();
            this.ListBox2 = new System.Windows.Forms.ListBox();
            this.TcdGroupBox = new System.Windows.Forms.GroupBox();
            this.DBGroupBox = new System.Windows.Forms.GroupBox();
            this.connectInDBToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveDBButton = new System.Windows.Forms.Button();
            this.SaveAllDBButton = new System.Windows.Forms.Button();
            this.MenuStrip.SuspendLayout();
            this.StatusStrip.SuspendLayout();
            this.TcdGroupBox.SuspendLayout();
            this.DBGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuStrip
            // 
            this.MenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.MenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileToolStripMenuItem,
            this.connectInDBToolStripMenuItem,
            this.AboutToolStripMenuItem});
            this.MenuStrip.Location = new System.Drawing.Point(0, 0);
            this.MenuStrip.Name = "MenuStrip";
            this.MenuStrip.Size = new System.Drawing.Size(421, 28);
            this.MenuStrip.TabIndex = 0;
            this.MenuStrip.Text = "MenuStrip";
            // 
            // FileToolStripMenuItem
            // 
            this.FileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OpenToolStripMenuItem,
            this.SaveToolStripMenuItem});
            this.FileToolStripMenuItem.Name = "FileToolStripMenuItem";
            this.FileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.FileToolStripMenuItem.Text = "File";
            // 
            // OpenToolStripMenuItem
            // 
            this.OpenToolStripMenuItem.Name = "OpenToolStripMenuItem";
            this.OpenToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.OpenToolStripMenuItem.Text = "Open";
            this.OpenToolStripMenuItem.Click += new System.EventHandler(this.OpenToolStripMenuItem_Click);
            // 
            // SaveToolStripMenuItem
            // 
            this.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem";
            this.SaveToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.SaveToolStripMenuItem.Text = "Save";
            this.SaveToolStripMenuItem.Click += new System.EventHandler(this.SaveToolStripMenuItem_Click);
            // 
            // AboutToolStripMenuItem
            // 
            this.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem";
            this.AboutToolStripMenuItem.Size = new System.Drawing.Size(64, 24);
            this.AboutToolStripMenuItem.Text = "About";
            this.AboutToolStripMenuItem.Click += new System.EventHandler(this.AboutToolStripMenuItem_Click);
            // 
            // SearchTextBox
            // 
            this.SearchTextBox.Location = new System.Drawing.Point(12, 40);
            this.SearchTextBox.Name = "SearchTextBox";
            this.SearchTextBox.Size = new System.Drawing.Size(199, 22);
            this.SearchTextBox.TabIndex = 1;
            this.SearchTextBox.TextChanged += new System.EventHandler(this.SearchTextBox_TextChanged);
            // 
            // ListBox
            // 
            this.ListBox.FormattingEnabled = true;
            this.ListBox.ItemHeight = 16;
            this.ListBox.Location = new System.Drawing.Point(12, 68);
            this.ListBox.Name = "ListBox";
            this.ListBox.Size = new System.Drawing.Size(199, 212);
            this.ListBox.TabIndex = 2;
            this.ListBox.SelectedIndexChanged += new System.EventHandler(this.ListBox_SelectedIndexChanged);
            // 
            // StatusStrip
            // 
            this.StatusStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.StatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CountToolStripStatusLabel,
            this.TabToolStripStatusLabel,
            this.CopyrightToolStripStatusLabel});
            this.StatusStrip.Location = new System.Drawing.Point(0, 292);
            this.StatusStrip.Name = "StatusStrip";
            this.StatusStrip.Size = new System.Drawing.Size(421, 26);
            this.StatusStrip.TabIndex = 3;
            this.StatusStrip.Text = "StatusStrip";
            // 
            // CountToolStripStatusLabel
            // 
            this.CountToolStripStatusLabel.Name = "CountToolStripStatusLabel";
            this.CountToolStripStatusLabel.Size = new System.Drawing.Size(51, 20);
            this.CountToolStripStatusLabel.Text = "Count:";
            // 
            // TabToolStripStatusLabel
            // 
            this.TabToolStripStatusLabel.Name = "TabToolStripStatusLabel";
            this.TabToolStripStatusLabel.Size = new System.Drawing.Size(149, 20);
            this.TabToolStripStatusLabel.Text = "                                   ";
            // 
            // CopyrightToolStripStatusLabel
            // 
            this.CopyrightToolStripStatusLabel.IsLink = true;
            this.CopyrightToolStripStatusLabel.Name = "CopyrightToolStripStatusLabel";
            this.CopyrightToolStripStatusLabel.Size = new System.Drawing.Size(181, 20);
            this.CopyrightToolStripStatusLabel.Text = "Copyright © SlayerHasher";
            this.CopyrightToolStripStatusLabel.ToolTipText = "https://github.com/SlayerHasher";
            this.CopyrightToolStripStatusLabel.Click += new System.EventHandler(this.CopyrightToolStripStatusLabel_Click);
            // 
            // PointTextBox
            // 
            this.PointTextBox.Location = new System.Drawing.Point(263, 68);
            this.PointTextBox.Name = "PointTextBox";
            this.PointTextBox.Size = new System.Drawing.Size(147, 22);
            this.PointTextBox.TabIndex = 4;
            // 
            // PointLabel
            // 
            this.PointLabel.AutoSize = true;
            this.PointLabel.Location = new System.Drawing.Point(217, 71);
            this.PointLabel.Name = "PointLabel";
            this.PointLabel.Size = new System.Drawing.Size(37, 16);
            this.PointLabel.TabIndex = 5;
            this.PointLabel.Text = "Point";
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(6, 50);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(178, 23);
            this.SaveButton.TabIndex = 6;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(6, 21);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(88, 23);
            this.AddButton.TabIndex = 7;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(96, 21);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(88, 23);
            this.DeleteButton.TabIndex = 8;
            this.DeleteButton.Text = "Delete";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // OFD
            // 
            this.OFD.FileName = "OFD";
            // 
            // ListBox2
            // 
            this.ListBox2.FormattingEnabled = true;
            this.ListBox2.ItemHeight = 16;
            this.ListBox2.Location = new System.Drawing.Point(12, 68);
            this.ListBox2.Name = "ListBox2";
            this.ListBox2.Size = new System.Drawing.Size(199, 212);
            this.ListBox2.TabIndex = 9;
            this.ListBox2.Visible = false;
            this.ListBox2.SelectedIndexChanged += new System.EventHandler(this.ListBox2_SelectedIndexChanged);
            // 
            // TcdGroupBox
            // 
            this.TcdGroupBox.Controls.Add(this.SaveButton);
            this.TcdGroupBox.Controls.Add(this.AddButton);
            this.TcdGroupBox.Controls.Add(this.DeleteButton);
            this.TcdGroupBox.Location = new System.Drawing.Point(220, 200);
            this.TcdGroupBox.Name = "TcdGroupBox";
            this.TcdGroupBox.Size = new System.Drawing.Size(190, 80);
            this.TcdGroupBox.TabIndex = 10;
            this.TcdGroupBox.TabStop = false;
            this.TcdGroupBox.Text = "Tcd";
            // 
            // DBGroupBox
            // 
            this.DBGroupBox.Controls.Add(this.SaveAllDBButton);
            this.DBGroupBox.Controls.Add(this.SaveDBButton);
            this.DBGroupBox.Location = new System.Drawing.Point(220, 143);
            this.DBGroupBox.Name = "DBGroupBox";
            this.DBGroupBox.Size = new System.Drawing.Size(190, 51);
            this.DBGroupBox.TabIndex = 11;
            this.DBGroupBox.TabStop = false;
            this.DBGroupBox.Text = "DB";
            // 
            // connectInDBToolStripMenuItem
            // 
            this.connectInDBToolStripMenuItem.Name = "connectInDBToolStripMenuItem";
            this.connectInDBToolStripMenuItem.Size = new System.Drawing.Size(117, 24);
            this.connectInDBToolStripMenuItem.Text = "Connect in DB";
            // 
            // SaveDBButton
            // 
            this.SaveDBButton.Location = new System.Drawing.Point(6, 21);
            this.SaveDBButton.Name = "SaveDBButton";
            this.SaveDBButton.Size = new System.Drawing.Size(88, 23);
            this.SaveDBButton.TabIndex = 0;
            this.SaveDBButton.Text = "Save";
            this.SaveDBButton.UseVisualStyleBackColor = true;
            // 
            // SaveAllDBButton
            // 
            this.SaveAllDBButton.Location = new System.Drawing.Point(96, 21);
            this.SaveAllDBButton.Name = "SaveAllDBButton";
            this.SaveAllDBButton.Size = new System.Drawing.Size(88, 23);
            this.SaveAllDBButton.TabIndex = 1;
            this.SaveAllDBButton.Text = "Save All";
            this.SaveAllDBButton.UseVisualStyleBackColor = true;
            // 
            // TBattleInsignia_Editor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(421, 318);
            this.Controls.Add(this.DBGroupBox);
            this.Controls.Add(this.TcdGroupBox);
            this.Controls.Add(this.ListBox2);
            this.Controls.Add(this.PointLabel);
            this.Controls.Add(this.PointTextBox);
            this.Controls.Add(this.StatusStrip);
            this.Controls.Add(this.ListBox);
            this.Controls.Add(this.SearchTextBox);
            this.Controls.Add(this.MenuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.MenuStrip;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TBattleInsignia_Editor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TBattleInsignia Editor";
            this.MenuStrip.ResumeLayout(false);
            this.MenuStrip.PerformLayout();
            this.StatusStrip.ResumeLayout(false);
            this.StatusStrip.PerformLayout();
            this.TcdGroupBox.ResumeLayout(false);
            this.DBGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MenuStrip;
        private System.Windows.Forms.ToolStripMenuItem FileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem OpenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SaveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AboutToolStripMenuItem;
        private System.Windows.Forms.TextBox SearchTextBox;
        private System.Windows.Forms.ListBox ListBox;
        private System.Windows.Forms.StatusStrip StatusStrip;
        private System.Windows.Forms.ToolStripStatusLabel CopyrightToolStripStatusLabel;
        private System.Windows.Forms.ToolStripStatusLabel CountToolStripStatusLabel;
        private System.Windows.Forms.ToolStripStatusLabel TabToolStripStatusLabel;
        private System.Windows.Forms.TextBox PointTextBox;
        private System.Windows.Forms.Label PointLabel;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.OpenFileDialog OFD;
        private System.Windows.Forms.SaveFileDialog SFD;
        private System.Windows.Forms.ListBox ListBox2;
        private System.Windows.Forms.GroupBox TcdGroupBox;
        private System.Windows.Forms.GroupBox DBGroupBox;
        private System.Windows.Forms.ToolStripMenuItem connectInDBToolStripMenuItem;
        private System.Windows.Forms.Button SaveAllDBButton;
        private System.Windows.Forms.Button SaveDBButton;
    }
}

