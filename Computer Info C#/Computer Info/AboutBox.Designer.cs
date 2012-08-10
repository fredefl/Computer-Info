using System.Windows.Forms;
namespace Computer_Info
{
    partial class AboutBox
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutBox));
            this.BottomPanel = new System.Windows.Forms.Panel();
            this.SeperatorPanel = new System.Windows.Forms.Panel();
            this.DisclaimerLabel = new System.Windows.Forms.Label();
            this.VersionStatusImage = new System.Windows.Forms.PictureBox();
            this.VersionStatusLabel = new System.Windows.Forms.Label();
            this.WebsiteLinkLabel = new System.Windows.Forms.LinkLabel();
            this.GitHubLinkLabel = new System.Windows.Forms.LinkLabel();
            this.OpenSourceInfoLabel = new System.Windows.Forms.Label();
            this.CopyrightLabel = new System.Windows.Forms.Label();
            this.OkButton = new System.Windows.Forms.Button();
            this.ApplicationNameLabel = new System.Windows.Forms.Label();
            this.VersionLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BottomPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.VersionStatusImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // BottomPanel
            // 
            this.BottomPanel.BackColor = System.Drawing.SystemColors.Control;
            this.BottomPanel.Controls.Add(this.SeperatorPanel);
            this.BottomPanel.Controls.Add(this.DisclaimerLabel);
            this.BottomPanel.Controls.Add(this.VersionStatusImage);
            this.BottomPanel.Controls.Add(this.VersionStatusLabel);
            this.BottomPanel.Controls.Add(this.WebsiteLinkLabel);
            this.BottomPanel.Controls.Add(this.GitHubLinkLabel);
            this.BottomPanel.Controls.Add(this.OpenSourceInfoLabel);
            this.BottomPanel.Controls.Add(this.CopyrightLabel);
            this.BottomPanel.Controls.Add(this.OkButton);
            this.BottomPanel.Location = new System.Drawing.Point(-9, 134);
            this.BottomPanel.Name = "BottomPanel";
            this.BottomPanel.Size = new System.Drawing.Size(399, 120);
            this.BottomPanel.TabIndex = 0;
            // 
            // SeperatorPanel
            // 
            this.SeperatorPanel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.SeperatorPanel.Location = new System.Drawing.Point(0, 0);
            this.SeperatorPanel.Margin = new System.Windows.Forms.Padding(0);
            this.SeperatorPanel.Name = "SeperatorPanel";
            this.SeperatorPanel.Size = new System.Drawing.Size(412, 2);
            this.SeperatorPanel.TabIndex = 1;
            // 
            // DisclaimerLabel
            // 
            this.DisclaimerLabel.AutoSize = true;
            this.DisclaimerLabel.Font = new System.Drawing.Font("Arial", 8.25F);
            this.DisclaimerLabel.Location = new System.Drawing.Point(23, 54);
            this.DisclaimerLabel.Name = "DisclaimerLabel";
            this.DisclaimerLabel.Size = new System.Drawing.Size(340, 14);
            this.DisclaimerLabel.TabIndex = 9;
            this.DisclaimerLabel.Text = "Vi er på ingen på ansvarlige for skader dette program måtte forvolde.";
            // 
            // VersionStatusImage
            // 
            this.VersionStatusImage.Image = global::Computer_Info.Properties.Resources.Loading;
            this.VersionStatusImage.Location = new System.Drawing.Point(26, 78);
            this.VersionStatusImage.Name = "VersionStatusImage";
            this.VersionStatusImage.Size = new System.Drawing.Size(16, 16);
            this.VersionStatusImage.TabIndex = 8;
            this.VersionStatusImage.TabStop = false;
            // 
            // VersionStatusLabel
            // 
            this.VersionStatusLabel.AutoSize = true;
            this.VersionStatusLabel.Font = new System.Drawing.Font("Arial", 8.25F);
            this.VersionStatusLabel.Location = new System.Drawing.Point(46, 79);
            this.VersionStatusLabel.Name = "VersionStatusLabel";
            this.VersionStatusLabel.Size = new System.Drawing.Size(134, 14);
            this.VersionStatusLabel.TabIndex = 7;
            this.VersionStatusLabel.Text = "Søger efter opdateringer...";
            // 
            // WebsiteLinkLabel
            // 
            this.WebsiteLinkLabel.AutoSize = true;
            this.WebsiteLinkLabel.Font = new System.Drawing.Font("Arial", 8.25F);
            this.WebsiteLinkLabel.LinkColor = System.Drawing.SystemColors.Highlight;
            this.WebsiteLinkLabel.Location = new System.Drawing.Point(110, 18);
            this.WebsiteLinkLabel.Name = "WebsiteLinkLabel";
            this.WebsiteLinkLabel.Size = new System.Drawing.Size(39, 14);
            this.WebsiteLinkLabel.TabIndex = 6;
            this.WebsiteLinkLabel.TabStop = true;
            this.WebsiteLinkLabel.Text = "Illution.";
            this.WebsiteLinkLabel.VisitedLinkColor = System.Drawing.SystemColors.Highlight;
            this.WebsiteLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.WebsiteLinkLabel_LinkClicked);
            // 
            // GitHubLinkLabel
            // 
            this.GitHubLinkLabel.AutoSize = true;
            this.GitHubLinkLabel.Font = new System.Drawing.Font("Arial", 8.25F);
            this.GitHubLinkLabel.LinkColor = System.Drawing.SystemColors.Highlight;
            this.GitHubLinkLabel.Location = new System.Drawing.Point(263, 35);
            this.GitHubLinkLabel.Name = "GitHubLinkLabel";
            this.GitHubLinkLabel.Size = new System.Drawing.Size(42, 14);
            this.GitHubLinkLabel.TabIndex = 5;
            this.GitHubLinkLabel.TabStop = true;
            this.GitHubLinkLabel.Text = "GitHub.";
            this.GitHubLinkLabel.VisitedLinkColor = System.Drawing.SystemColors.Highlight;
            this.GitHubLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.GitHubLinkLabel_LinkClicked);
            // 
            // OpenSourceInfoLabel
            // 
            this.OpenSourceInfoLabel.AutoSize = true;
            this.OpenSourceInfoLabel.Font = new System.Drawing.Font("Arial", 8.25F);
            this.OpenSourceInfoLabel.Location = new System.Drawing.Point(23, 35);
            this.OpenSourceInfoLabel.Name = "OpenSourceInfoLabel";
            this.OpenSourceInfoLabel.Size = new System.Drawing.Size(245, 14);
            this.OpenSourceInfoLabel.TabIndex = 4;
            this.OpenSourceInfoLabel.Text = "Denne klient er open source, koden kan findes på";
            // 
            // CopyrightLabel
            // 
            this.CopyrightLabel.AutoSize = true;
            this.CopyrightLabel.Font = new System.Drawing.Font("Arial", 8.25F);
            this.CopyrightLabel.Location = new System.Drawing.Point(23, 17);
            this.CopyrightLabel.Name = "CopyrightLabel";
            this.CopyrightLabel.Size = new System.Drawing.Size(91, 14);
            this.CopyrightLabel.TabIndex = 3;
            this.CopyrightLabel.Text = "Copyright © 2012";
            // 
            // OkButton
            // 
            this.OkButton.Location = new System.Drawing.Point(305, 74);
            this.OkButton.Name = "OkButton";
            this.OkButton.Size = new System.Drawing.Size(75, 23);
            this.OkButton.TabIndex = 2;
            this.OkButton.Text = "OK";
            this.OkButton.UseVisualStyleBackColor = true;
            this.OkButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // ApplicationNameLabel
            // 
            this.ApplicationNameLabel.AutoSize = true;
            this.ApplicationNameLabel.BackColor = System.Drawing.Color.Transparent;
            this.ApplicationNameLabel.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ApplicationNameLabel.Location = new System.Drawing.Point(9, 10);
            this.ApplicationNameLabel.Name = "ApplicationNameLabel";
            this.ApplicationNameLabel.Size = new System.Drawing.Size(228, 45);
            this.ApplicationNameLabel.TabIndex = 1;
            this.ApplicationNameLabel.Text = "Computer Info";
            // 
            // VersionLabel
            // 
            this.VersionLabel.AutoSize = true;
            this.VersionLabel.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VersionLabel.Location = new System.Drawing.Point(14, 55);
            this.VersionLabel.Name = "VersionLabel";
            this.VersionLabel.Size = new System.Drawing.Size(48, 15);
            this.VersionLabel.TabIndex = 2;
            this.VersionLabel.Text = "Version";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(220, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(353, 335);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // AboutBox
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.Graphic;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(383, 242);
            this.Controls.Add(this.VersionLabel);
            this.Controls.Add(this.ApplicationNameLabel);
            this.Controls.Add(this.BottomPanel);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AboutBox";
            this.Padding = new System.Windows.Forms.Padding(9);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Om";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AboutBox_FormClosing);
            this.Load += new System.EventHandler(this.AboutBox_Load);
            this.BottomPanel.ResumeLayout(false);
            this.BottomPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.VersionStatusImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel BottomPanel;
        private Panel SeperatorPanel;
        private LinkLabel GitHubLinkLabel;
        private Label OpenSourceInfoLabel;
        private Label CopyrightLabel;
        private Button OkButton;
        private Label ApplicationNameLabel;
        private Label VersionLabel;
        private LinkLabel WebsiteLinkLabel;
        private PictureBox VersionStatusImage;
        private Label VersionStatusLabel;
        private Label DisclaimerLabel;
        private PictureBox pictureBox1;



    }
}
