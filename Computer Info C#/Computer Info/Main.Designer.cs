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
            this.SchoolBox = new System.Windows.Forms.TextBox();
            this.MainMenu = new System.Windows.Forms.MenuStrip();
            this.AboutMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.UpdateMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LoginMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SchoolLabel = new System.Windows.Forms.Label();
            this.LocationLabel = new System.Windows.Forms.Label();
            this.NumberBox = new System.Windows.Forms.TextBox();
            this.BUFUUFSelector = new System.Windows.Forms.ComboBox();
            this.BUFUFFLabel = new System.Windows.Forms.Label();
            this.StationarySelector = new System.Windows.Forms.RadioButton();
            this.LaptopSelector = new System.Windows.Forms.RadioButton();
            this.ComputerTypeLabel = new System.Windows.Forms.Label();
            this.SmartboardSelector = new System.Windows.Forms.CheckBox();
            this.SaveButton = new System.Windows.Forms.Button();
            this.MacAddressBox = new System.Windows.Forms.TextBox();
            this.LocationComboBox = new System.Windows.Forms.ComboBox();
            this.MainMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // SchoolBox
            // 
            this.SchoolBox.AccessibleDescription = "Skole";
            this.SchoolBox.AccessibleName = "Skole";
            this.SchoolBox.Location = new System.Drawing.Point(12, 49);
            this.SchoolBox.Name = "SchoolBox";
            this.SchoolBox.Size = new System.Drawing.Size(190, 20);
            this.SchoolBox.TabIndex = 1;
            // 
            // MainMenu
            // 
            this.MainMenu.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.LoginMenuItem,
            this.UpdateMenuItem,
            this.AboutMenuItem});
            this.MainMenu.Location = new System.Drawing.Point(0, 0);
            this.MainMenu.Name = "MainMenu";
            this.MainMenu.Size = new System.Drawing.Size(211, 24);
            this.MainMenu.TabIndex = 2;
            this.MainMenu.Text = "MainMenu";
            // 
            // AboutMenuItem
            // 
            this.AboutMenuItem.Name = "AboutMenuItem";
            this.AboutMenuItem.Size = new System.Drawing.Size(39, 20);
            this.AboutMenuItem.Text = "Om";
            this.AboutMenuItem.Click += new System.EventHandler(this.omToolStripMenuItem_Click);
            // 
            // UpdateMenuItem
            // 
            this.UpdateMenuItem.Name = "UpdateMenuItem";
            this.UpdateMenuItem.Size = new System.Drawing.Size(65, 20);
            this.UpdateMenuItem.Text = "Opdater";
            this.UpdateMenuItem.Click += new System.EventHandler(this.NewUpdate_Click);
            // 
            // LoginMenuItem
            // 
            this.LoginMenuItem.Name = "LoginMenuItem";
            this.LoginMenuItem.Size = new System.Drawing.Size(59, 20);
            this.LoginMenuItem.Text = "Log ind";
            this.LoginMenuItem.Click += new System.EventHandler(this.LoginMenuItem_Click);
            // 
            // SchoolLabel
            // 
            this.SchoolLabel.AutoSize = true;
            this.SchoolLabel.BackColor = System.Drawing.Color.Transparent;
            this.SchoolLabel.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SchoolLabel.ForeColor = System.Drawing.Color.Black;
            this.SchoolLabel.Location = new System.Drawing.Point(9, 29);
            this.SchoolLabel.Name = "SchoolLabel";
            this.SchoolLabel.Size = new System.Drawing.Size(44, 16);
            this.SchoolLabel.TabIndex = 4;
            this.SchoolLabel.Text = "Skole";
            this.SchoolLabel.UseMnemonic = false;
            // 
            // LocationLabel
            // 
            this.LocationLabel.AutoSize = true;
            this.LocationLabel.BackColor = System.Drawing.Color.Transparent;
            this.LocationLabel.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LocationLabel.ForeColor = System.Drawing.Color.Black;
            this.LocationLabel.Location = new System.Drawing.Point(9, 71);
            this.LocationLabel.Name = "LocationLabel";
            this.LocationLabel.Size = new System.Drawing.Size(63, 16);
            this.LocationLabel.TabIndex = 5;
            this.LocationLabel.Text = "Lokation";
            // 
            // NumberBox
            // 
            this.NumberBox.Location = new System.Drawing.Point(83, 138);
            this.NumberBox.Name = "NumberBox";
            this.NumberBox.Size = new System.Drawing.Size(119, 20);
            this.NumberBox.TabIndex = 8;
            // 
            // BUFUUFSelector
            // 
            this.BUFUUFSelector.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.BUFUUFSelector.FormattingEnabled = true;
            this.BUFUUFSelector.Items.AddRange(new object[] {
            "BUF",
            "UUF"});
            this.BUFUUFSelector.Location = new System.Drawing.Point(12, 138);
            this.BUFUUFSelector.Name = "BUFUUFSelector";
            this.BUFUUFSelector.Size = new System.Drawing.Size(65, 21);
            this.BUFUUFSelector.TabIndex = 7;
            // 
            // BUFUFFLabel
            // 
            this.BUFUFFLabel.AutoSize = true;
            this.BUFUFFLabel.BackColor = System.Drawing.Color.Transparent;
            this.BUFUFFLabel.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BUFUFFLabel.ForeColor = System.Drawing.Color.Black;
            this.BUFUFFLabel.Location = new System.Drawing.Point(9, 118);
            this.BUFUFFLabel.Name = "BUFUFFLabel";
            this.BUFUFFLabel.Size = new System.Drawing.Size(122, 16);
            this.BUFUFFLabel.TabIndex = 9;
            this.BUFUFFLabel.Text = "BUF/UUF Nummer";
            // 
            // StationarySelector
            // 
            this.StationarySelector.AutoSize = true;
            this.StationarySelector.BackColor = System.Drawing.Color.Transparent;
            this.StationarySelector.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StationarySelector.ForeColor = System.Drawing.Color.Black;
            this.StationarySelector.Location = new System.Drawing.Point(12, 181);
            this.StationarySelector.Name = "StationarySelector";
            this.StationarySelector.Size = new System.Drawing.Size(88, 20);
            this.StationarySelector.TabIndex = 10;
            this.StationarySelector.TabStop = true;
            this.StationarySelector.Text = "Stationær";
            this.StationarySelector.UseVisualStyleBackColor = false;
            this.StationarySelector.CheckedChanged += new System.EventHandler(this.Stationary_CheckedChanged);
            // 
            // LaptopSelector
            // 
            this.LaptopSelector.AutoSize = true;
            this.LaptopSelector.BackColor = System.Drawing.Color.Transparent;
            this.LaptopSelector.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LaptopSelector.ForeColor = System.Drawing.Color.Black;
            this.LaptopSelector.Location = new System.Drawing.Point(12, 204);
            this.LaptopSelector.Name = "LaptopSelector";
            this.LaptopSelector.Size = new System.Drawing.Size(73, 20);
            this.LaptopSelector.TabIndex = 11;
            this.LaptopSelector.TabStop = true;
            this.LaptopSelector.Text = "Bærbar";
            this.LaptopSelector.UseVisualStyleBackColor = false;
            this.LaptopSelector.CheckedChanged += new System.EventHandler(this.Laptop_CheckedChanged);
            // 
            // ComputerTypeLabel
            // 
            this.ComputerTypeLabel.AutoSize = true;
            this.ComputerTypeLabel.BackColor = System.Drawing.Color.Transparent;
            this.ComputerTypeLabel.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComputerTypeLabel.ForeColor = System.Drawing.Color.Black;
            this.ComputerTypeLabel.Location = new System.Drawing.Point(9, 162);
            this.ComputerTypeLabel.Name = "ComputerTypeLabel";
            this.ComputerTypeLabel.Size = new System.Drawing.Size(104, 16);
            this.ComputerTypeLabel.TabIndex = 12;
            this.ComputerTypeLabel.Text = "Computer Type";
            // 
            // SmartboardSelector
            // 
            this.SmartboardSelector.AutoSize = true;
            this.SmartboardSelector.BackColor = System.Drawing.Color.Transparent;
            this.SmartboardSelector.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SmartboardSelector.ForeColor = System.Drawing.Color.Black;
            this.SmartboardSelector.Location = new System.Drawing.Point(12, 229);
            this.SmartboardSelector.Name = "SmartboardSelector";
            this.SmartboardSelector.Size = new System.Drawing.Size(190, 20);
            this.SmartboardSelector.TabIndex = 12;
            this.SmartboardSelector.Text = "Smartboard / Activeboard";
            this.SmartboardSelector.UseVisualStyleBackColor = false;
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(12, 255);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(190, 42);
            this.SaveButton.TabIndex = 13;
            this.SaveButton.Text = "Gem";
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
            // LocationComboBox
            // 
            this.LocationComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.LocationComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.LocationComboBox.FormattingEnabled = true;
            this.LocationComboBox.Location = new System.Drawing.Point(12, 91);
            this.LocationComboBox.Name = "LocationComboBox";
            this.LocationComboBox.Size = new System.Drawing.Size(190, 21);
            this.LocationComboBox.Sorted = true;
            this.LocationComboBox.TabIndex = 16;
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
            this.Controls.Add(this.LocationComboBox);
            this.Controls.Add(this.MacAddressBox);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.SmartboardSelector);
            this.Controls.Add(this.ComputerTypeLabel);
            this.Controls.Add(this.LaptopSelector);
            this.Controls.Add(this.StationarySelector);
            this.Controls.Add(this.BUFUFFLabel);
            this.Controls.Add(this.BUFUUFSelector);
            this.Controls.Add(this.NumberBox);
            this.Controls.Add(this.LocationLabel);
            this.Controls.Add(this.SchoolLabel);
            this.Controls.Add(this.SchoolBox);
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

        private System.Windows.Forms.TextBox SchoolBox;
        private System.Windows.Forms.MenuStrip MainMenu;
        private System.Windows.Forms.ToolStripMenuItem AboutMenuItem;
        private System.Windows.Forms.Label SchoolLabel;
        private System.Windows.Forms.Label LocationLabel;
        private System.Windows.Forms.TextBox NumberBox;
        private System.Windows.Forms.Label BUFUFFLabel;
        private System.Windows.Forms.RadioButton StationarySelector;
        private System.Windows.Forms.RadioButton LaptopSelector;
        private System.Windows.Forms.Label ComputerTypeLabel;
        private System.Windows.Forms.ComboBox BUFUUFSelector;
        private System.Windows.Forms.CheckBox SmartboardSelector;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.TextBox MacAddressBox;
        private System.Windows.Forms.ToolStripMenuItem UpdateMenuItem;
        private System.Windows.Forms.ComboBox LocationComboBox;
        private System.Windows.Forms.ToolStripMenuItem LoginMenuItem;

    }
}