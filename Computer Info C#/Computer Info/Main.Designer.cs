namespace Computer_Info
{
    partial class Main
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
            //base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.OrganizationLabel = new MetroFramework.Controls.MetroLabel();
            this.LocationLabel = new MetroFramework.Controls.MetroLabel();
            this.IdentifierBox = new MetroFramework.Controls.MetroTextBox();
            this.IdentifierLabel = new MetroFramework.Controls.MetroLabel();
            this.DesktopSelector = new MetroFramework.Controls.MetroRadioButton();
            this.LaptopSelector = new MetroFramework.Controls.MetroRadioButton();
            this.ComputerTypeLabel = new MetroFramework.Controls.MetroLabel();
            this.BoardSelector = new MetroFramework.Controls.MetroCheckBox();
            this.SaveButton = new MetroFramework.Controls.MetroButton();
            this.MacAddressBox = new MetroFramework.Controls.MetroTextBox();
            this.LocationBox = new MetroFramework.Controls.MetroComboBox();
            this.OrganizationBox = new MetroFramework.Controls.MetroComboBox();
            this.AboutLink = new MetroFramework.Controls.MetroLink();
            this.SignOutLink = new MetroFramework.Controls.MetroLink();
            this.metroLink1 = new MetroFramework.Controls.MetroLink();
            this.AddLocationBox = new MetroFramework.Controls.MetroTextBox();
            this.SuspendLayout();
            // 
            // OrganizationLabel
            // 
            resources.ApplyResources(this.OrganizationLabel, "OrganizationLabel");
            this.OrganizationLabel.BackColor = System.Drawing.Color.Transparent;
            this.OrganizationLabel.CustomBackground = false;
            this.OrganizationLabel.CustomForeColor = false;
            this.OrganizationLabel.FontSize = MetroFramework.MetroLabelSize.Medium;
            this.OrganizationLabel.FontWeight = MetroFramework.MetroLabelWeight.Light;
            this.OrganizationLabel.ForeColor = System.Drawing.Color.Black;
            this.OrganizationLabel.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            this.OrganizationLabel.Name = "OrganizationLabel";
            this.OrganizationLabel.Style = MetroFramework.MetroColorStyle.Blue;
            this.OrganizationLabel.StyleManager = null;
            this.OrganizationLabel.Theme = MetroFramework.MetroThemeStyle.Light;
            this.OrganizationLabel.UseMnemonic = false;
            this.OrganizationLabel.UseStyleColors = false;
            // 
            // LocationLabel
            // 
            resources.ApplyResources(this.LocationLabel, "LocationLabel");
            this.LocationLabel.BackColor = System.Drawing.Color.Transparent;
            this.LocationLabel.CustomBackground = false;
            this.LocationLabel.CustomForeColor = false;
            this.LocationLabel.FontSize = MetroFramework.MetroLabelSize.Medium;
            this.LocationLabel.FontWeight = MetroFramework.MetroLabelWeight.Light;
            this.LocationLabel.ForeColor = System.Drawing.Color.Black;
            this.LocationLabel.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            this.LocationLabel.Name = "LocationLabel";
            this.LocationLabel.Style = MetroFramework.MetroColorStyle.Blue;
            this.LocationLabel.StyleManager = null;
            this.LocationLabel.Theme = MetroFramework.MetroThemeStyle.Light;
            this.LocationLabel.UseStyleColors = false;
            // 
            // IdentifierBox
            // 
            this.IdentifierBox.CustomBackground = false;
            this.IdentifierBox.CustomForeColor = false;
            this.IdentifierBox.FontSize = MetroFramework.MetroTextBoxSize.Small;
            this.IdentifierBox.FontWeight = MetroFramework.MetroTextBoxWeight.Regular;
            resources.ApplyResources(this.IdentifierBox, "IdentifierBox");
            this.IdentifierBox.Multiline = false;
            this.IdentifierBox.Name = "IdentifierBox";
            this.IdentifierBox.SelectedText = "";
            this.IdentifierBox.Style = MetroFramework.MetroColorStyle.Blue;
            this.IdentifierBox.StyleManager = null;
            this.IdentifierBox.Theme = MetroFramework.MetroThemeStyle.Light;
            this.IdentifierBox.UseStyleColors = false;
            // 
            // IdentifierLabel
            // 
            resources.ApplyResources(this.IdentifierLabel, "IdentifierLabel");
            this.IdentifierLabel.BackColor = System.Drawing.Color.Transparent;
            this.IdentifierLabel.CustomBackground = false;
            this.IdentifierLabel.CustomForeColor = false;
            this.IdentifierLabel.FontSize = MetroFramework.MetroLabelSize.Medium;
            this.IdentifierLabel.FontWeight = MetroFramework.MetroLabelWeight.Light;
            this.IdentifierLabel.ForeColor = System.Drawing.Color.Black;
            this.IdentifierLabel.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            this.IdentifierLabel.Name = "IdentifierLabel";
            this.IdentifierLabel.Style = MetroFramework.MetroColorStyle.Blue;
            this.IdentifierLabel.StyleManager = null;
            this.IdentifierLabel.Theme = MetroFramework.MetroThemeStyle.Light;
            this.IdentifierLabel.UseStyleColors = false;
            // 
            // DesktopSelector
            // 
            resources.ApplyResources(this.DesktopSelector, "DesktopSelector");
            this.DesktopSelector.BackColor = System.Drawing.Color.Transparent;
            this.DesktopSelector.CustomBackground = false;
            this.DesktopSelector.CustomForeColor = false;
            this.DesktopSelector.FontSize = MetroFramework.MetroLinkSize.Small;
            this.DesktopSelector.FontWeight = MetroFramework.MetroLinkWeight.Regular;
            this.DesktopSelector.ForeColor = System.Drawing.Color.Black;
            this.DesktopSelector.Name = "DesktopSelector";
            this.DesktopSelector.Style = MetroFramework.MetroColorStyle.Blue;
            this.DesktopSelector.StyleManager = null;
            this.DesktopSelector.TabStop = true;
            this.DesktopSelector.Theme = MetroFramework.MetroThemeStyle.Light;
            this.DesktopSelector.UseStyleColors = false;
            this.DesktopSelector.UseVisualStyleBackColor = false;
            this.DesktopSelector.CheckedChanged += new System.EventHandler(this.DesktopSelector_CheckedChanged);
            // 
            // LaptopSelector
            // 
            resources.ApplyResources(this.LaptopSelector, "LaptopSelector");
            this.LaptopSelector.BackColor = System.Drawing.Color.Transparent;
            this.LaptopSelector.CustomBackground = false;
            this.LaptopSelector.CustomForeColor = false;
            this.LaptopSelector.FontSize = MetroFramework.MetroLinkSize.Small;
            this.LaptopSelector.FontWeight = MetroFramework.MetroLinkWeight.Regular;
            this.LaptopSelector.ForeColor = System.Drawing.Color.Black;
            this.LaptopSelector.Name = "LaptopSelector";
            this.LaptopSelector.Style = MetroFramework.MetroColorStyle.Blue;
            this.LaptopSelector.StyleManager = null;
            this.LaptopSelector.TabStop = true;
            this.LaptopSelector.Theme = MetroFramework.MetroThemeStyle.Light;
            this.LaptopSelector.UseStyleColors = false;
            this.LaptopSelector.UseVisualStyleBackColor = false;
            this.LaptopSelector.CheckedChanged += new System.EventHandler(this.LaptopSelector_CheckedChanged);
            // 
            // ComputerTypeLabel
            // 
            resources.ApplyResources(this.ComputerTypeLabel, "ComputerTypeLabel");
            this.ComputerTypeLabel.BackColor = System.Drawing.Color.Transparent;
            this.ComputerTypeLabel.CustomBackground = false;
            this.ComputerTypeLabel.CustomForeColor = false;
            this.ComputerTypeLabel.FontSize = MetroFramework.MetroLabelSize.Medium;
            this.ComputerTypeLabel.FontWeight = MetroFramework.MetroLabelWeight.Light;
            this.ComputerTypeLabel.ForeColor = System.Drawing.Color.Black;
            this.ComputerTypeLabel.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            this.ComputerTypeLabel.Name = "ComputerTypeLabel";
            this.ComputerTypeLabel.Style = MetroFramework.MetroColorStyle.Blue;
            this.ComputerTypeLabel.StyleManager = null;
            this.ComputerTypeLabel.Theme = MetroFramework.MetroThemeStyle.Light;
            this.ComputerTypeLabel.UseStyleColors = false;
            // 
            // BoardSelector
            // 
            resources.ApplyResources(this.BoardSelector, "BoardSelector");
            this.BoardSelector.BackColor = System.Drawing.Color.Transparent;
            this.BoardSelector.CustomBackground = false;
            this.BoardSelector.CustomForeColor = false;
            this.BoardSelector.FontSize = MetroFramework.MetroLinkSize.Small;
            this.BoardSelector.FontWeight = MetroFramework.MetroLinkWeight.Regular;
            this.BoardSelector.ForeColor = System.Drawing.Color.Black;
            this.BoardSelector.Name = "BoardSelector";
            this.BoardSelector.Style = MetroFramework.MetroColorStyle.Blue;
            this.BoardSelector.StyleManager = null;
            this.BoardSelector.Theme = MetroFramework.MetroThemeStyle.Light;
            this.BoardSelector.UseStyleColors = false;
            this.BoardSelector.UseVisualStyleBackColor = false;
            // 
            // SaveButton
            // 
            this.SaveButton.Highlight = false;
            resources.ApplyResources(this.SaveButton, "SaveButton");
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.SaveButton.StyleManager = null;
            this.SaveButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.SaveButton.Click += new System.EventHandler(this.Save_Click);
            // 
            // MacAddressBox
            // 
            this.MacAddressBox.CustomBackground = false;
            this.MacAddressBox.CustomForeColor = false;
            this.MacAddressBox.FontSize = MetroFramework.MetroTextBoxSize.Small;
            this.MacAddressBox.FontWeight = MetroFramework.MetroTextBoxWeight.Regular;
            resources.ApplyResources(this.MacAddressBox, "MacAddressBox");
            this.MacAddressBox.Multiline = false;
            this.MacAddressBox.Name = "MacAddressBox";
            this.MacAddressBox.SelectedText = "";
            this.MacAddressBox.Style = MetroFramework.MetroColorStyle.Blue;
            this.MacAddressBox.StyleManager = null;
            this.MacAddressBox.Theme = MetroFramework.MetroThemeStyle.Light;
            this.MacAddressBox.UseStyleColors = false;
            // 
            // LocationBox
            // 
            this.LocationBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.LocationBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.LocationBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.LocationBox.FontSize = MetroFramework.MetroLinkSize.Medium;
            this.LocationBox.FontWeight = MetroFramework.MetroLinkWeight.Regular;
            this.LocationBox.FormattingEnabled = true;
            resources.ApplyResources(this.LocationBox, "LocationBox");
            this.LocationBox.Name = "LocationBox";
            this.LocationBox.Sorted = true;
            this.LocationBox.Style = MetroFramework.MetroColorStyle.Blue;
            this.LocationBox.StyleManager = null;
            this.LocationBox.Theme = MetroFramework.MetroThemeStyle.Light;
            this.LocationBox.SelectedIndexChanged += new System.EventHandler(this.LocationBox_SelectedIndexChanged);
            // 
            // OrganizationBox
            // 
            this.OrganizationBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.OrganizationBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.OrganizationBox.FontSize = MetroFramework.MetroLinkSize.Medium;
            this.OrganizationBox.FontWeight = MetroFramework.MetroLinkWeight.Regular;
            this.OrganizationBox.FormattingEnabled = true;
            resources.ApplyResources(this.OrganizationBox, "OrganizationBox");
            this.OrganizationBox.Name = "OrganizationBox";
            this.OrganizationBox.Style = MetroFramework.MetroColorStyle.Blue;
            this.OrganizationBox.StyleManager = null;
            this.OrganizationBox.Theme = MetroFramework.MetroThemeStyle.Light;
            this.OrganizationBox.SelectedValueChanged += new System.EventHandler(this.OrganizationBox_SelectedValueChanged);
            // 
            // AboutLink
            // 
            resources.ApplyResources(this.AboutLink, "AboutLink");
            this.AboutLink.CustomBackground = false;
            this.AboutLink.CustomForeColor = false;
            this.AboutLink.FontSize = MetroFramework.MetroLinkSize.Medium;
            this.AboutLink.FontWeight = MetroFramework.MetroLinkWeight.Regular;
            this.AboutLink.Name = "AboutLink";
            this.AboutLink.Style = MetroFramework.MetroColorStyle.Blue;
            this.AboutLink.StyleManager = null;
            this.AboutLink.Theme = MetroFramework.MetroThemeStyle.Light;
            this.AboutLink.UseStyleColors = false;
            this.AboutLink.Click += new System.EventHandler(this.AboutLink_Click);
            // 
            // SignOutLink
            // 
            resources.ApplyResources(this.SignOutLink, "SignOutLink");
            this.SignOutLink.CustomBackground = false;
            this.SignOutLink.CustomForeColor = false;
            this.SignOutLink.FontSize = MetroFramework.MetroLinkSize.Medium;
            this.SignOutLink.FontWeight = MetroFramework.MetroLinkWeight.Regular;
            this.SignOutLink.Name = "SignOutLink";
            this.SignOutLink.Style = MetroFramework.MetroColorStyle.Blue;
            this.SignOutLink.StyleManager = null;
            this.SignOutLink.Theme = MetroFramework.MetroThemeStyle.Light;
            this.SignOutLink.UseStyleColors = false;
            this.SignOutLink.Click += new System.EventHandler(this.SignOutLink_Click);
            // 
            // metroLink1
            // 
            resources.ApplyResources(this.metroLink1, "metroLink1");
            this.metroLink1.BackColor = System.Drawing.Color.Transparent;
            this.metroLink1.CustomBackground = false;
            this.metroLink1.CustomForeColor = false;
            this.metroLink1.FontSize = MetroFramework.MetroLinkSize.Tall;
            this.metroLink1.FontWeight = MetroFramework.MetroLinkWeight.Bold;
            this.metroLink1.Name = "metroLink1";
            this.metroLink1.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroLink1.StyleManager = null;
            this.metroLink1.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroLink1.UseStyleColors = false;
            this.metroLink1.Click += new System.EventHandler(this.metroLink1_Click);
            // 
            // AddLocationBox
            // 
            this.AddLocationBox.BackColor = System.Drawing.Color.White;
            this.AddLocationBox.CustomBackground = true;
            this.AddLocationBox.CustomForeColor = false;
            this.AddLocationBox.FontSize = MetroFramework.MetroTextBoxSize.Small;
            this.AddLocationBox.FontWeight = MetroFramework.MetroTextBoxWeight.Regular;
            resources.ApplyResources(this.AddLocationBox, "AddLocationBox");
            this.AddLocationBox.Multiline = false;
            this.AddLocationBox.Name = "AddLocationBox";
            this.AddLocationBox.SelectedText = "";
            this.AddLocationBox.Style = MetroFramework.MetroColorStyle.Blue;
            this.AddLocationBox.StyleManager = null;
            this.AddLocationBox.Theme = MetroFramework.MetroThemeStyle.Light;
            this.AddLocationBox.UseStyleColors = false;
            this.AddLocationBox.TextChanged += new System.EventHandler(this.AddLocationBox_TextChanged);
            // 
            // Main
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.AddLocationBox);
            this.Controls.Add(this.SignOutLink);
            this.Controls.Add(this.AboutLink);
            this.Controls.Add(this.OrganizationBox);
            this.Controls.Add(this.LocationBox);
            this.Controls.Add(this.MacAddressBox);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.BoardSelector);
            this.Controls.Add(this.ComputerTypeLabel);
            this.Controls.Add(this.LaptopSelector);
            this.Controls.Add(this.DesktopSelector);
            this.Controls.Add(this.IdentifierLabel);
            this.Controls.Add(this.IdentifierBox);
            this.Controls.Add(this.LocationLabel);
            this.Controls.Add(this.OrganizationLabel);
            this.Controls.Add(this.metroLink1);
            this.MaximizeBox = false;
            this.Name = "Main";
            //this.Resizable = false;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Main_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        //private MetroFramework.Controls.Me MainMenu;
        //private System.Windows.Forms.ToolStripMenuItem AboutMenuItem;
        private MetroFramework.Controls.MetroLabel OrganizationLabel;
        private MetroFramework.Controls.MetroLabel LocationLabel;
        private MetroFramework.Controls.MetroTextBox IdentifierBox;
        private MetroFramework.Controls.MetroLabel IdentifierLabel;
        private MetroFramework.Controls.MetroRadioButton DesktopSelector;
        private MetroFramework.Controls.MetroRadioButton LaptopSelector;
        private MetroFramework.Controls.MetroLabel ComputerTypeLabel;
        private MetroFramework.Controls.MetroCheckBox BoardSelector;
        private MetroFramework.Controls.MetroButton SaveButton;
        private MetroFramework.Controls.MetroTextBox MacAddressBox;
        //private System.Windows.Forms.ToolStripMenuItem UpdateMenuItem;
        private MetroFramework.Controls.MetroComboBox LocationBox;
        //private System.Windows.Forms.ToolStripMenuItem SignOutMenuItem;
        private MetroFramework.Controls.MetroComboBox OrganizationBox;
        private MetroFramework.Controls.MetroLink AboutLink;
        private MetroFramework.Controls.MetroLink SignOutLink;
        private MetroFramework.Controls.MetroLink metroLink1;
        private MetroFramework.Controls.MetroTextBox AddLocationBox;
        //private System.Windows.Forms.ToolStripMenuItem UpdateProgramMenuItem;
        //private System.Windows.Forms.ToolStripMenuItem UpdateCacheMenuItem;

    }
}