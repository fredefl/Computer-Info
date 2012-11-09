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
            this.SignOutMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.UpdateMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.UpdateProgramMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.UpdateCacheMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AboutMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OrganizationLabel = new System.Windows.Forms.Label();
            this.LocationLabel = new System.Windows.Forms.Label();
            this.IdentifierBox = new System.Windows.Forms.TextBox();
            this.IdentifierLabel = new System.Windows.Forms.Label();
            this.DesktopSelector = new System.Windows.Forms.RadioButton();
            this.LaptopSelector = new System.Windows.Forms.RadioButton();
            this.ComputerTypeLabel = new System.Windows.Forms.Label();
            this.BoardSelector = new System.Windows.Forms.CheckBox();
            this.SaveButton = new System.Windows.Forms.Button();
            this.MacAddressBox = new System.Windows.Forms.TextBox();
            this.LocationBox = new System.Windows.Forms.ComboBox();
            this.OrganizationBox = new System.Windows.Forms.ComboBox();
            this.MainMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainMenu
            // 
            this.MainMenu.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.MainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SignOutMenuItem,
            this.UpdateMenuItem,
            this.AboutMenuItem});
            this.MainMenu.Location = new System.Drawing.Point(0, 0);
            this.MainMenu.Name = "MainMenu";
            this.MainMenu.Size = new System.Drawing.Size(211, 24);
            this.MainMenu.TabIndex = 2;
            this.MainMenu.Text = "MainMenu";
            // 
            // SignOutMenuItem
            // 
            this.SignOutMenuItem.Name = "SignOutMenuItem";
            this.SignOutMenuItem.Size = new System.Drawing.Size(56, 20);
            this.SignOutMenuItem.Text = "Log ud";
            this.SignOutMenuItem.Click += new System.EventHandler(this.SignOutMenuItem_Click);
            // 
            // UpdateMenuItem
            // 
            this.UpdateMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.UpdateProgramMenuItem,
            this.UpdateCacheMenuItem});
            this.UpdateMenuItem.Name = "UpdateMenuItem";
            this.UpdateMenuItem.Size = new System.Drawing.Size(65, 20);
            this.UpdateMenuItem.Text = "Opdater";
            // 
            // UpdateProgramMenuItem
            // 
            this.UpdateProgramMenuItem.Name = "UpdateProgramMenuItem";
            this.UpdateProgramMenuItem.Size = new System.Drawing.Size(122, 22);
            this.UpdateProgramMenuItem.Text = "Program";
            this.UpdateProgramMenuItem.Click += new System.EventHandler(this.UpdateProgramMenuItem_Click);
            // 
            // UpdateCacheMenuItem
            // 
            this.UpdateCacheMenuItem.Name = "UpdateCacheMenuItem";
            this.UpdateCacheMenuItem.Size = new System.Drawing.Size(122, 22);
            this.UpdateCacheMenuItem.Text = "Cache";
            this.UpdateCacheMenuItem.Click += new System.EventHandler(this.UpdateCacheMenuItem_Click);
            // 
            // AboutMenuItem
            // 
            this.AboutMenuItem.Name = "AboutMenuItem";
            this.AboutMenuItem.Size = new System.Drawing.Size(39, 20);
            this.AboutMenuItem.Text = "Om";
            this.AboutMenuItem.Click += new System.EventHandler(this.AboutMenuItem_Click);
            // 
            // OrganizationLabel
            // 
            this.OrganizationLabel.AutoSize = true;
            this.OrganizationLabel.BackColor = System.Drawing.Color.Transparent;
            this.OrganizationLabel.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.OrganizationLabel.ForeColor = System.Drawing.Color.Black;
            this.OrganizationLabel.Location = new System.Drawing.Point(9, 29);
            this.OrganizationLabel.Name = "OrganizationLabel";
            this.OrganizationLabel.Size = new System.Drawing.Size(90, 16);
            this.OrganizationLabel.TabIndex = 4;
            this.OrganizationLabel.Text = "Organization";
            this.OrganizationLabel.UseMnemonic = false;
            // 
            // LocationLabel
            // 
            this.LocationLabel.AutoSize = true;
            this.LocationLabel.BackColor = System.Drawing.Color.Transparent;
            this.LocationLabel.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.LocationLabel.ForeColor = System.Drawing.Color.Black;
            this.LocationLabel.Location = new System.Drawing.Point(9, 71);
            this.LocationLabel.Name = "LocationLabel";
            this.LocationLabel.Size = new System.Drawing.Size(63, 16);
            this.LocationLabel.TabIndex = 5;
            this.LocationLabel.Text = "Location";
            // 
            // IdentifierBox
            // 
            this.IdentifierBox.Location = new System.Drawing.Point(12, 138);
            this.IdentifierBox.Name = "IdentifierBox";
            this.IdentifierBox.Size = new System.Drawing.Size(190, 20);
            this.IdentifierBox.TabIndex = 8;
            // 
            // IdentifierLabel
            // 
            this.IdentifierLabel.AutoSize = true;
            this.IdentifierLabel.BackColor = System.Drawing.Color.Transparent;
            this.IdentifierLabel.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.IdentifierLabel.ForeColor = System.Drawing.Color.Black;
            this.IdentifierLabel.Location = new System.Drawing.Point(9, 118);
            this.IdentifierLabel.Name = "IdentifierLabel";
            this.IdentifierLabel.Size = new System.Drawing.Size(65, 16);
            this.IdentifierLabel.TabIndex = 9;
            this.IdentifierLabel.Text = "Identifier";
            // 
            // DesktopSelector
            // 
            this.DesktopSelector.AutoSize = true;
            this.DesktopSelector.BackColor = System.Drawing.Color.Transparent;
            this.DesktopSelector.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.DesktopSelector.ForeColor = System.Drawing.Color.Black;
            this.DesktopSelector.Location = new System.Drawing.Point(12, 181);
            this.DesktopSelector.Name = "DesktopSelector";
            this.DesktopSelector.Size = new System.Drawing.Size(76, 20);
            this.DesktopSelector.TabIndex = 10;
            this.DesktopSelector.TabStop = true;
            this.DesktopSelector.Text = "Desktop";
            this.DesktopSelector.UseVisualStyleBackColor = false;
            this.DesktopSelector.CheckedChanged += new System.EventHandler(this.DesktopSelector_CheckedChanged);
            // 
            // LaptopSelector
            // 
            this.LaptopSelector.AutoSize = true;
            this.LaptopSelector.BackColor = System.Drawing.Color.Transparent;
            this.LaptopSelector.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.LaptopSelector.ForeColor = System.Drawing.Color.Black;
            this.LaptopSelector.Location = new System.Drawing.Point(12, 204);
            this.LaptopSelector.Name = "LaptopSelector";
            this.LaptopSelector.Size = new System.Drawing.Size(70, 20);
            this.LaptopSelector.TabIndex = 11;
            this.LaptopSelector.TabStop = true;
            this.LaptopSelector.Text = "Laptop";
            this.LaptopSelector.UseVisualStyleBackColor = false;
            this.LaptopSelector.CheckedChanged += new System.EventHandler(this.LaptopSelector_CheckedChanged);
            // 
            // ComputerTypeLabel
            // 
            this.ComputerTypeLabel.AutoSize = true;
            this.ComputerTypeLabel.BackColor = System.Drawing.Color.Transparent;
            this.ComputerTypeLabel.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.ComputerTypeLabel.ForeColor = System.Drawing.Color.Black;
            this.ComputerTypeLabel.Location = new System.Drawing.Point(9, 162);
            this.ComputerTypeLabel.Name = "ComputerTypeLabel";
            this.ComputerTypeLabel.Size = new System.Drawing.Size(104, 16);
            this.ComputerTypeLabel.TabIndex = 12;
            this.ComputerTypeLabel.Text = "Computer Type";
            // 
            // BoardSelector
            // 
            this.BoardSelector.AutoSize = true;
            this.BoardSelector.BackColor = System.Drawing.Color.Transparent;
            this.BoardSelector.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.BoardSelector.ForeColor = System.Drawing.Color.Black;
            this.BoardSelector.Location = new System.Drawing.Point(12, 229);
            this.BoardSelector.Name = "BoardSelector";
            this.BoardSelector.Size = new System.Drawing.Size(190, 20);
            this.BoardSelector.TabIndex = 12;
            this.BoardSelector.Text = "Smartboard / Activeboard";
            this.BoardSelector.UseVisualStyleBackColor = false;
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(12, 255);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(190, 42);
            this.SaveButton.TabIndex = 13;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.Save_Click);
            // 
            // MacAddressBox
            // 
            this.MacAddressBox.Location = new System.Drawing.Point(12, 303);
            this.MacAddressBox.Name = "MacAddressBox";
            this.MacAddressBox.Size = new System.Drawing.Size(190, 20);
            this.MacAddressBox.TabIndex = 14;
            // 
            // LocationBox
            // 
            this.LocationBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.LocationBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.LocationBox.FormattingEnabled = true;
            this.LocationBox.Location = new System.Drawing.Point(12, 91);
            this.LocationBox.Name = "LocationBox";
            this.LocationBox.Size = new System.Drawing.Size(190, 21);
            this.LocationBox.Sorted = true;
            this.LocationBox.TabIndex = 16;
            this.LocationBox.SelectedIndexChanged += new System.EventHandler(this.LocationBox_SelectedIndexChanged);
            // 
            // OrganizationBox
            // 
            this.OrganizationBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.OrganizationBox.FormattingEnabled = true;
            this.OrganizationBox.Location = new System.Drawing.Point(12, 49);
            this.OrganizationBox.Name = "OrganizationBox";
            this.OrganizationBox.Size = new System.Drawing.Size(190, 21);
            this.OrganizationBox.TabIndex = 17;
            this.OrganizationBox.SelectedValueChanged += new System.EventHandler(this.OrganizationBox_SelectedValueChanged);
            // 
            // Main
            // 
            this.AccessibleDescription = "Computer Info";
            this.AccessibleName = "Computer Info";
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(211, 336);
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
            this.Controls.Add(this.MainMenu);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.MainMenu;
            this.MaximizeBox = false;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Computer Info";
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
        private System.Windows.Forms.Label IdentifierLabel;
        private System.Windows.Forms.RadioButton DesktopSelector;
        private System.Windows.Forms.RadioButton LaptopSelector;
        private System.Windows.Forms.Label ComputerTypeLabel;
        private System.Windows.Forms.CheckBox BoardSelector;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.TextBox MacAddressBox;
        private System.Windows.Forms.ToolStripMenuItem UpdateMenuItem;
        private System.Windows.Forms.ComboBox LocationBox;
        private System.Windows.Forms.ToolStripMenuItem SignOutMenuItem;
        private System.Windows.Forms.ComboBox OrganizationBox;
        private System.Windows.Forms.ToolStripMenuItem UpdateProgramMenuItem;
        private System.Windows.Forms.ToolStripMenuItem UpdateCacheMenuItem;

    }
}