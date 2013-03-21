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
            this.BottomPanel = new MetroFramework.Controls.MetroPanel();
            this.VersionSpinner = new MetroFramework.Controls.MetroProgressSpinner();
            this.SeperatorPanel = new MetroFramework.Controls.MetroPanel();
            this.DisclaimerLabel = new MetroFramework.Controls.MetroLabel();
            this.VersionStatusLabel = new MetroFramework.Controls.MetroLabel();
            this.WebsiteLinkLabel = new MetroFramework.Controls.MetroLink();
            this.GitHubLinkLabel = new MetroFramework.Controls.MetroLink();
            this.OpenSourceInfoLabel = new MetroFramework.Controls.MetroLabel();
            this.CopyrightLabel = new MetroFramework.Controls.MetroLabel();
            this.OkButton = new MetroFramework.Controls.MetroButton();
            this.ApplicationNameLabel = new MetroFramework.Controls.MetroLabel();
            this.VersionLabel = new MetroFramework.Controls.MetroLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BottomPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // BottomPanel
            // 
            this.BottomPanel.BackColor = System.Drawing.SystemColors.Control;
            this.BottomPanel.Controls.Add(this.VersionSpinner);
            this.BottomPanel.Controls.Add(this.SeperatorPanel);
            this.BottomPanel.Controls.Add(this.DisclaimerLabel);
            this.BottomPanel.Controls.Add(this.VersionStatusLabel);
            this.BottomPanel.Controls.Add(this.WebsiteLinkLabel);
            this.BottomPanel.Controls.Add(this.GitHubLinkLabel);
            this.BottomPanel.Controls.Add(this.OpenSourceInfoLabel);
            this.BottomPanel.Controls.Add(this.CopyrightLabel);
            this.BottomPanel.Controls.Add(this.OkButton);
            this.BottomPanel.CustomBackground = false;
            this.BottomPanel.HorizontalScrollbar = false;
            this.BottomPanel.HorizontalScrollbarBarColor = true;
            this.BottomPanel.HorizontalScrollbarHighlightOnWheel = false;
            this.BottomPanel.HorizontalScrollbarSize = 10;
            this.BottomPanel.Location = new System.Drawing.Point(-9, 134);
            this.BottomPanel.Name = "BottomPanel";
            this.BottomPanel.Size = new System.Drawing.Size(464, 120);
            this.BottomPanel.Style = MetroFramework.MetroColorStyle.Blue;
            this.BottomPanel.StyleManager = null;
            this.BottomPanel.TabIndex = 0;
            this.BottomPanel.Theme = MetroFramework.MetroThemeStyle.Light;
            this.BottomPanel.VerticalScrollbar = false;
            this.BottomPanel.VerticalScrollbarBarColor = true;
            this.BottomPanel.VerticalScrollbarHighlightOnWheel = false;
            this.BottomPanel.VerticalScrollbarSize = 10;
            // 
            // VersionSpinner
            // 
            this.VersionSpinner.CustomBackground = false;
            this.VersionSpinner.Location = new System.Drawing.Point(26, 79);
            this.VersionSpinner.Maximum = 100;
            this.VersionSpinner.Name = "VersionSpinner";
            this.VersionSpinner.Size = new System.Drawing.Size(22, 22);
            this.VersionSpinner.Style = MetroFramework.MetroColorStyle.Blue;
            this.VersionSpinner.StyleManager = null;
            this.VersionSpinner.TabIndex = 10;
            this.VersionSpinner.Theme = MetroFramework.MetroThemeStyle.Light;
            this.VersionSpinner.Value = 100;
            // 
            // SeperatorPanel
            // 
            this.SeperatorPanel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.SeperatorPanel.CustomBackground = false;
            this.SeperatorPanel.HorizontalScrollbar = false;
            this.SeperatorPanel.HorizontalScrollbarBarColor = true;
            this.SeperatorPanel.HorizontalScrollbarHighlightOnWheel = false;
            this.SeperatorPanel.HorizontalScrollbarSize = 10;
            this.SeperatorPanel.Location = new System.Drawing.Point(0, 0);
            this.SeperatorPanel.Margin = new System.Windows.Forms.Padding(0);
            this.SeperatorPanel.Name = "SeperatorPanel";
            this.SeperatorPanel.Size = new System.Drawing.Size(412, 2);
            this.SeperatorPanel.Style = MetroFramework.MetroColorStyle.Blue;
            this.SeperatorPanel.StyleManager = null;
            this.SeperatorPanel.TabIndex = 1;
            this.SeperatorPanel.Theme = MetroFramework.MetroThemeStyle.Light;
            this.SeperatorPanel.VerticalScrollbar = false;
            this.SeperatorPanel.VerticalScrollbarBarColor = true;
            this.SeperatorPanel.VerticalScrollbarHighlightOnWheel = false;
            this.SeperatorPanel.VerticalScrollbarSize = 10;
            // 
            // DisclaimerLabel
            // 
            this.DisclaimerLabel.AutoSize = true;
            this.DisclaimerLabel.CustomBackground = false;
            this.DisclaimerLabel.CustomForeColor = false;
            this.DisclaimerLabel.FontSize = MetroFramework.MetroLabelSize.Medium;
            this.DisclaimerLabel.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.DisclaimerLabel.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            this.DisclaimerLabel.Location = new System.Drawing.Point(23, 54);
            this.DisclaimerLabel.Name = "DisclaimerLabel";
            this.DisclaimerLabel.Size = new System.Drawing.Size(433, 19);
            this.DisclaimerLabel.Style = MetroFramework.MetroColorStyle.Blue;
            this.DisclaimerLabel.StyleManager = null;
            this.DisclaimerLabel.TabIndex = 9;
            this.DisclaimerLabel.Text = "Vi er på ingen på ansvarlige for skader dette program måtte forvolde.";
            this.DisclaimerLabel.Theme = MetroFramework.MetroThemeStyle.Light;
            this.DisclaimerLabel.UseStyleColors = false;
            // 
            // VersionStatusLabel
            // 
            this.VersionStatusLabel.AutoSize = true;
            this.VersionStatusLabel.CustomBackground = false;
            this.VersionStatusLabel.CustomForeColor = false;
            this.VersionStatusLabel.FontSize = MetroFramework.MetroLabelSize.Medium;
            this.VersionStatusLabel.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.VersionStatusLabel.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            this.VersionStatusLabel.Location = new System.Drawing.Point(50, 80);
            this.VersionStatusLabel.Name = "VersionStatusLabel";
            this.VersionStatusLabel.Size = new System.Drawing.Size(168, 19);
            this.VersionStatusLabel.Style = MetroFramework.MetroColorStyle.Blue;
            this.VersionStatusLabel.StyleManager = null;
            this.VersionStatusLabel.TabIndex = 7;
            this.VersionStatusLabel.Text = "Søger efter opdateringer...";
            this.VersionStatusLabel.Theme = MetroFramework.MetroThemeStyle.Light;
            this.VersionStatusLabel.UseStyleColors = false;
            // 
            // WebsiteLinkLabel
            // 
            this.WebsiteLinkLabel.AutoSize = true;
            this.WebsiteLinkLabel.CustomBackground = false;
            this.WebsiteLinkLabel.CustomForeColor = false;
            this.WebsiteLinkLabel.FontSize = MetroFramework.MetroLinkSize.Medium;
            this.WebsiteLinkLabel.FontWeight = MetroFramework.MetroLinkWeight.Regular;
            this.WebsiteLinkLabel.Location = new System.Drawing.Point(141, 7);
            this.WebsiteLinkLabel.Name = "WebsiteLinkLabel";
            this.WebsiteLinkLabel.Size = new System.Drawing.Size(57, 23);
            this.WebsiteLinkLabel.Style = MetroFramework.MetroColorStyle.Blue;
            this.WebsiteLinkLabel.StyleManager = null;
            this.WebsiteLinkLabel.TabIndex = 6;
            this.WebsiteLinkLabel.Text = "Illution.";
            this.WebsiteLinkLabel.Theme = MetroFramework.MetroThemeStyle.Light;
            this.WebsiteLinkLabel.UseStyleColors = false;
            this.WebsiteLinkLabel.Click += new System.EventHandler(this.WebsiteLinkLabel_Click);
            // 
            // GitHubLinkLabel
            // 
            this.GitHubLinkLabel.AutoSize = true;
            this.GitHubLinkLabel.CustomBackground = false;
            this.GitHubLinkLabel.CustomForeColor = false;
            this.GitHubLinkLabel.FontSize = MetroFramework.MetroLinkSize.Small;
            this.GitHubLinkLabel.FontWeight = MetroFramework.MetroLinkWeight.Regular;
            this.GitHubLinkLabel.Location = new System.Drawing.Point(328, 34);
            this.GitHubLinkLabel.Name = "GitHubLinkLabel";
            this.GitHubLinkLabel.Size = new System.Drawing.Size(53, 23);
            this.GitHubLinkLabel.Style = MetroFramework.MetroColorStyle.Blue;
            this.GitHubLinkLabel.StyleManager = null;
            this.GitHubLinkLabel.TabIndex = 5;
            this.GitHubLinkLabel.Text = "GitHub.";
            this.GitHubLinkLabel.Theme = MetroFramework.MetroThemeStyle.Light;
            this.GitHubLinkLabel.UseStyleColors = false;
            this.GitHubLinkLabel.Click += new System.EventHandler(this.GitHubLinkLabel_Click);
            // 
            // OpenSourceInfoLabel
            // 
            this.OpenSourceInfoLabel.AutoSize = true;
            this.OpenSourceInfoLabel.CustomBackground = false;
            this.OpenSourceInfoLabel.CustomForeColor = false;
            this.OpenSourceInfoLabel.FontSize = MetroFramework.MetroLabelSize.Medium;
            this.OpenSourceInfoLabel.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.OpenSourceInfoLabel.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            this.OpenSourceInfoLabel.Location = new System.Drawing.Point(23, 35);
            this.OpenSourceInfoLabel.Name = "OpenSourceInfoLabel";
            this.OpenSourceInfoLabel.Size = new System.Drawing.Size(311, 19);
            this.OpenSourceInfoLabel.Style = MetroFramework.MetroColorStyle.Blue;
            this.OpenSourceInfoLabel.StyleManager = null;
            this.OpenSourceInfoLabel.TabIndex = 4;
            this.OpenSourceInfoLabel.Text = "Denne klient er open source, koden kan findes på";
            this.OpenSourceInfoLabel.Theme = MetroFramework.MetroThemeStyle.Light;
            this.OpenSourceInfoLabel.UseStyleColors = false;
            // 
            // CopyrightLabel
            // 
            this.CopyrightLabel.AutoSize = true;
            this.CopyrightLabel.CustomBackground = false;
            this.CopyrightLabel.CustomForeColor = false;
            this.CopyrightLabel.FontSize = MetroFramework.MetroLabelSize.Medium;
            this.CopyrightLabel.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.CopyrightLabel.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            this.CopyrightLabel.Location = new System.Drawing.Point(23, 9);
            this.CopyrightLabel.Name = "CopyrightLabel";
            this.CopyrightLabel.Size = new System.Drawing.Size(122, 19);
            this.CopyrightLabel.Style = MetroFramework.MetroColorStyle.Blue;
            this.CopyrightLabel.StyleManager = null;
            this.CopyrightLabel.TabIndex = 3;
            this.CopyrightLabel.Text = "Copyright © 2012";
            this.CopyrightLabel.Theme = MetroFramework.MetroThemeStyle.Light;
            this.CopyrightLabel.UseStyleColors = false;
            // 
            // OkButton
            // 
            this.OkButton.Highlight = false;
            this.OkButton.Location = new System.Drawing.Point(367, 77);
            this.OkButton.Name = "OkButton";
            this.OkButton.Size = new System.Drawing.Size(75, 23);
            this.OkButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.OkButton.StyleManager = null;
            this.OkButton.TabIndex = 2;
            this.OkButton.Text = "OK";
            this.OkButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.OkButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // ApplicationNameLabel
            // 
            this.ApplicationNameLabel.AutoSize = true;
            this.ApplicationNameLabel.BackColor = System.Drawing.Color.Transparent;
            this.ApplicationNameLabel.CustomBackground = false;
            this.ApplicationNameLabel.CustomForeColor = false;
            this.ApplicationNameLabel.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.ApplicationNameLabel.FontWeight = MetroFramework.MetroLabelWeight.Light;
            this.ApplicationNameLabel.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            this.ApplicationNameLabel.Location = new System.Drawing.Point(9, 15);
            this.ApplicationNameLabel.Name = "ApplicationNameLabel";
            this.ApplicationNameLabel.Size = new System.Drawing.Size(122, 25);
            this.ApplicationNameLabel.Style = MetroFramework.MetroColorStyle.Blue;
            this.ApplicationNameLabel.StyleManager = null;
            this.ApplicationNameLabel.TabIndex = 1;
            this.ApplicationNameLabel.Text = "Computer Info";
            this.ApplicationNameLabel.Theme = MetroFramework.MetroThemeStyle.Light;
            this.ApplicationNameLabel.UseStyleColors = false;
            // 
            // VersionLabel
            // 
            this.VersionLabel.AutoSize = true;
            this.VersionLabel.CustomBackground = false;
            this.VersionLabel.CustomForeColor = false;
            this.VersionLabel.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.VersionLabel.FontWeight = MetroFramework.MetroLabelWeight.Light;
            this.VersionLabel.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            this.VersionLabel.Location = new System.Drawing.Point(9, 40);
            this.VersionLabel.Name = "VersionLabel";
            this.VersionLabel.Size = new System.Drawing.Size(69, 25);
            this.VersionLabel.Style = MetroFramework.MetroColorStyle.Blue;
            this.VersionLabel.StyleManager = null;
            this.VersionLabel.TabIndex = 2;
            this.VersionLabel.Text = "Version";
            this.VersionLabel.Theme = MetroFramework.MetroThemeStyle.Light;
            this.VersionLabel.UseStyleColors = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(267, 5);
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
            this.ClientSize = new System.Drawing.Size(443, 242);
            this.Controls.Add(this.VersionLabel);
            this.Controls.Add(this.ApplicationNameLabel);
            this.Controls.Add(this.BottomPanel);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(0, 0);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AboutBox";
            this.Padding = new System.Windows.Forms.Padding(9, 60, 9, 9);
            this.Text = "Om";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AboutBox_FormClosing);
            this.Load += new System.EventHandler(this.AboutBox_Load);
            this.BottomPanel.ResumeLayout(false);
            this.BottomPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroPanel BottomPanel;
        private MetroFramework.Controls.MetroPanel SeperatorPanel;
        private MetroFramework.Controls.MetroLink GitHubLinkLabel;
        private MetroFramework.Controls.MetroLabel OpenSourceInfoLabel;
        private MetroFramework.Controls.MetroLabel CopyrightLabel;
        private MetroFramework.Controls.MetroButton OkButton;
        private MetroFramework.Controls.MetroLabel ApplicationNameLabel;
        private MetroFramework.Controls.MetroLabel VersionLabel;
        private MetroFramework.Controls.MetroLink WebsiteLinkLabel;
        private MetroFramework.Controls.MetroLabel VersionStatusLabel;
        private MetroFramework.Controls.MetroLabel DisclaimerLabel;
        private PictureBox pictureBox1;
        private MetroFramework.Controls.MetroProgressSpinner VersionSpinner;



    }
}
