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
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.MainMenu = new System.Windows.Forms.MenuStrip();
            this.LoginMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.UpdateMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.programToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cacheToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AboutMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OrganizationLabel = new System.Windows.Forms.Label();
            this.LocationLabel = new System.Windows.Forms.Label();
            this.IdentifierBox = new System.Windows.Forms.TextBox();
            this.BUFUFFLabel = new System.Windows.Forms.Label();
            this.StationarySelector = new System.Windows.Forms.RadioButton();
            this.LaptopSelector = new System.Windows.Forms.RadioButton();
            this.ComputerTypeLabel = new System.Windows.Forms.Label();
            this.SmartboardSelector = new System.Windows.Forms.CheckBox();
            this.SaveButton = new System.Windows.Forms.Button();
            this.MacAddressBox = new System.Windows.Forms.TextBox();
            this.LocationBox = new System.Windows.Forms.ComboBox();
            this.OrganizationBox = new System.Windows.Forms.ComboBox();
            this.MainMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainMenu
            // 
            resources.ApplyResources(this.MainMenu, "MainMenu");
            this.MainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.LoginMenuItem,
            this.UpdateMenuItem,
            this.AboutMenuItem});
            this.MainMenu.Name = "MainMenu";
            // 
            // LoginMenuItem
            // 
            this.LoginMenuItem.Name = "LoginMenuItem";
            resources.ApplyResources(this.LoginMenuItem, "LoginMenuItem");
            this.LoginMenuItem.Click += new System.EventHandler(this.LoginMenuItem_Click);
            // 
            // UpdateMenuItem
            // 
            this.UpdateMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.programToolStripMenuItem,
            this.cacheToolStripMenuItem});
            this.UpdateMenuItem.Name = "UpdateMenuItem";
            resources.ApplyResources(this.UpdateMenuItem, "UpdateMenuItem");
            // 
            // programToolStripMenuItem
            // 
            this.programToolStripMenuItem.Name = "programToolStripMenuItem";
            resources.ApplyResources(this.programToolStripMenuItem, "programToolStripMenuItem");
            this.programToolStripMenuItem.Click += new System.EventHandler(this.programToolStripMenuItem_Click);
            // 
            // cacheToolStripMenuItem
            // 
            this.cacheToolStripMenuItem.Name = "cacheToolStripMenuItem";
            resources.ApplyResources(this.cacheToolStripMenuItem, "cacheToolStripMenuItem");
            this.cacheToolStripMenuItem.Click += new System.EventHandler(this.cacheToolStripMenuItem_Click);
            // 
            // AboutMenuItem
            // 
            this.AboutMenuItem.Name = "AboutMenuItem";
            resources.ApplyResources(this.AboutMenuItem, "AboutMenuItem");
            this.AboutMenuItem.Click += new System.EventHandler(this.omToolStripMenuItem_Click);
            // 
            // OrganizationLabel
            // 
            resources.ApplyResources(this.OrganizationLabel, "OrganizationLabel");
            this.OrganizationLabel.BackColor = System.Drawing.Color.Transparent;
            this.OrganizationLabel.ForeColor = System.Drawing.Color.Black;
            this.OrganizationLabel.Name = "OrganizationLabel";
            this.OrganizationLabel.UseMnemonic = false;
            // 
            // LocationLabel
            // 
            resources.ApplyResources(this.LocationLabel, "LocationLabel");
            this.LocationLabel.BackColor = System.Drawing.Color.Transparent;
            this.LocationLabel.ForeColor = System.Drawing.Color.Black;
            this.LocationLabel.Name = "LocationLabel";
            // 
            // IdentifierBox
            // 
            resources.ApplyResources(this.IdentifierBox, "IdentifierBox");
            this.IdentifierBox.Name = "IdentifierBox";
            // 
            // BUFUFFLabel
            // 
            resources.ApplyResources(this.BUFUFFLabel, "BUFUFFLabel");
            this.BUFUFFLabel.BackColor = System.Drawing.Color.Transparent;
            this.BUFUFFLabel.ForeColor = System.Drawing.Color.Black;
            this.BUFUFFLabel.Name = "BUFUFFLabel";
            // 
            // StationarySelector
            // 
            resources.ApplyResources(this.StationarySelector, "StationarySelector");
            this.StationarySelector.BackColor = System.Drawing.Color.Transparent;
            this.StationarySelector.ForeColor = System.Drawing.Color.Black;
            this.StationarySelector.Name = "StationarySelector";
            this.StationarySelector.TabStop = true;
            this.StationarySelector.UseVisualStyleBackColor = false;
            this.StationarySelector.CheckedChanged += new System.EventHandler(this.Stationary_CheckedChanged);
            // 
            // LaptopSelector
            // 
            resources.ApplyResources(this.LaptopSelector, "LaptopSelector");
            this.LaptopSelector.BackColor = System.Drawing.Color.Transparent;
            this.LaptopSelector.ForeColor = System.Drawing.Color.Black;
            this.LaptopSelector.Name = "LaptopSelector";
            this.LaptopSelector.TabStop = true;
            this.LaptopSelector.UseVisualStyleBackColor = false;
            this.LaptopSelector.CheckedChanged += new System.EventHandler(this.Laptop_CheckedChanged);
            // 
            // ComputerTypeLabel
            // 
            resources.ApplyResources(this.ComputerTypeLabel, "ComputerTypeLabel");
            this.ComputerTypeLabel.BackColor = System.Drawing.Color.Transparent;
            this.ComputerTypeLabel.ForeColor = System.Drawing.Color.Black;
            this.ComputerTypeLabel.Name = "ComputerTypeLabel";
            // 
            // SmartboardSelector
            // 
            resources.ApplyResources(this.SmartboardSelector, "SmartboardSelector");
            this.SmartboardSelector.BackColor = System.Drawing.Color.Transparent;
            this.SmartboardSelector.ForeColor = System.Drawing.Color.Black;
            this.SmartboardSelector.Name = "SmartboardSelector";
            this.SmartboardSelector.UseVisualStyleBackColor = false;
            // 
            // SaveButton
            // 
            resources.ApplyResources(this.SaveButton, "SaveButton");
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.Save_Click);
            // 
            // MacAddressBox
            // 
            resources.ApplyResources(this.MacAddressBox, "MacAddressBox");
            this.MacAddressBox.Name = "MacAddressBox";
            // 
            // LocationBox
            // 
            this.LocationBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.LocationBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.LocationBox.FormattingEnabled = true;
            resources.ApplyResources(this.LocationBox, "LocationBox");
            this.LocationBox.Name = "LocationBox";
            this.LocationBox.Sorted = true;
            this.LocationBox.SelectedIndexChanged += new System.EventHandler(this.LocationBox_SelectedIndexChanged);
            // 
            // OrganizationBox
            // 
            this.OrganizationBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.OrganizationBox.FormattingEnabled = true;
            resources.ApplyResources(this.OrganizationBox, "OrganizationBox");
            this.OrganizationBox.Name = "OrganizationBox";
            this.OrganizationBox.SelectedValueChanged += new System.EventHandler(this.OrganizationBox_SelectedValueChanged);
            // 
            // Main
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.OrganizationBox);
            this.Controls.Add(this.LocationBox);
            this.Controls.Add(this.MacAddressBox);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.SmartboardSelector);
            this.Controls.Add(this.ComputerTypeLabel);
            this.Controls.Add(this.LaptopSelector);
            this.Controls.Add(this.StationarySelector);
            this.Controls.Add(this.BUFUFFLabel);
            this.Controls.Add(this.IdentifierBox);
            this.Controls.Add(this.LocationLabel);
            this.Controls.Add(this.OrganizationLabel);
            this.Controls.Add(this.MainMenu);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MainMenuStrip = this.MainMenu;
            this.MaximizeBox = false;
            this.Name = "Main";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Main_FormClosed);
            this.MainMenu.ResumeLayout(false);
            this.MainMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MainMenu;
        private System.Windows.Forms.ToolStripMenuItem AboutMenuItem;
        private System.Windows.Forms.Label OrganizationLabel;
        private System.Windows.Forms.Label LocationLabel;
        private System.Windows.Forms.TextBox IdentifierBox;
        private System.Windows.Forms.Label BUFUFFLabel;
        private System.Windows.Forms.RadioButton StationarySelector;
        private System.Windows.Forms.RadioButton LaptopSelector;
        private System.Windows.Forms.Label ComputerTypeLabel;
        private System.Windows.Forms.CheckBox SmartboardSelector;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.TextBox MacAddressBox;
        private System.Windows.Forms.ToolStripMenuItem UpdateMenuItem;
        private System.Windows.Forms.ComboBox LocationBox;
        private System.Windows.Forms.ToolStripMenuItem LoginMenuItem;
        private System.Windows.Forms.ComboBox OrganizationBox;
        private System.Windows.Forms.ToolStripMenuItem programToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cacheToolStripMenuItem;

    }
}