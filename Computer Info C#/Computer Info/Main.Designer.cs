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
            this.omToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tokensToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.NewUpdate = new System.Windows.Forms.ToolStripMenuItem();
            this.LocationBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.NumberBox = new System.Windows.Forms.TextBox();
            this.BUFUUFSelector = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.StationarySelector = new System.Windows.Forms.RadioButton();
            this.LaptopSelector = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.SmartboardSelector = new System.Windows.Forms.CheckBox();
            this.SaveButton = new System.Windows.Forms.Button();
            this.LogBox = new System.Windows.Forms.TextBox();
            this.MacAddressBox = new System.Windows.Forms.TextBox();
            this.MainMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // SchoolBox
            // 
            this.SchoolBox.AccessibleDescription = "Skole";
            this.SchoolBox.AccessibleName = "Skole";
            this.SchoolBox.Location = new System.Drawing.Point(12, 48);
            this.SchoolBox.Name = "SchoolBox";
            this.SchoolBox.Size = new System.Drawing.Size(196, 20);
            this.SchoolBox.TabIndex = 1;
            // 
            // MainMenu
            // 
            this.MainMenu.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.omToolStripMenuItem,
            this.tokensToolStripMenuItem,
            this.NewUpdate});
            this.MainMenu.Location = new System.Drawing.Point(0, 0);
            this.MainMenu.Name = "MainMenu";
            this.MainMenu.Size = new System.Drawing.Size(220, 24);
            this.MainMenu.TabIndex = 2;
            this.MainMenu.Text = "MainMenu";
            // 
            // omToolStripMenuItem
            // 
            this.omToolStripMenuItem.Name = "omToolStripMenuItem";
            this.omToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.omToolStripMenuItem.Text = "Om";
            this.omToolStripMenuItem.Click += new System.EventHandler(this.omToolStripMenuItem_Click);
            // 
            // tokensToolStripMenuItem
            // 
            this.tokensToolStripMenuItem.Name = "tokensToolStripMenuItem";
            this.tokensToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.tokensToolStripMenuItem.Text = "Tokens";
            this.tokensToolStripMenuItem.Click += new System.EventHandler(this.tokensToolStripMenuItem_Click);
            // 
            // NewUpdate
            // 
            this.NewUpdate.Name = "NewUpdate";
            this.NewUpdate.Size = new System.Drawing.Size(65, 20);
            this.NewUpdate.Text = "Opdater";
            this.NewUpdate.Click += new System.EventHandler(this.NewUpdate_Click);
            // 
            // LocationBox
            // 
            this.LocationBox.Location = new System.Drawing.Point(12, 90);
            this.LocationBox.Name = "LocationBox";
            this.LocationBox.Size = new System.Drawing.Size(196, 20);
            this.LocationBox.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(9, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Skole";
            this.label1.UseMnemonic = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(9, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Lokation";
            // 
            // NumberBox
            // 
            this.NumberBox.Location = new System.Drawing.Point(83, 130);
            this.NumberBox.Name = "NumberBox";
            this.NumberBox.Size = new System.Drawing.Size(125, 20);
            this.NumberBox.TabIndex = 8;
            // 
            // BUFUUFSelector
            // 
            this.BUFUUFSelector.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.BUFUUFSelector.FormattingEnabled = true;
            this.BUFUUFSelector.Items.AddRange(new object[] {
            "BUF",
            "UUF"});
            this.BUFUUFSelector.Location = new System.Drawing.Point(12, 129);
            this.BUFUUFSelector.Name = "BUFUUFSelector";
            this.BUFUUFSelector.Size = new System.Drawing.Size(65, 21);
            this.BUFUUFSelector.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(9, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "BUF/UUF Nummer";
            // 
            // StationarySelector
            // 
            this.StationarySelector.AutoSize = true;
            this.StationarySelector.BackColor = System.Drawing.Color.Transparent;
            this.StationarySelector.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StationarySelector.ForeColor = System.Drawing.Color.Black;
            this.StationarySelector.Location = new System.Drawing.Point(12, 173);
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
            this.LaptopSelector.Location = new System.Drawing.Point(12, 196);
            this.LaptopSelector.Name = "LaptopSelector";
            this.LaptopSelector.Size = new System.Drawing.Size(73, 20);
            this.LaptopSelector.TabIndex = 11;
            this.LaptopSelector.TabStop = true;
            this.LaptopSelector.Text = "Bærbar";
            this.LaptopSelector.UseVisualStyleBackColor = false;
            this.LaptopSelector.CheckedChanged += new System.EventHandler(this.Laptop_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(9, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 16);
            this.label4.TabIndex = 12;
            this.label4.Text = "Computer Type";
            // 
            // SmartboardSelector
            // 
            this.SmartboardSelector.AutoSize = true;
            this.SmartboardSelector.BackColor = System.Drawing.Color.Transparent;
            this.SmartboardSelector.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SmartboardSelector.ForeColor = System.Drawing.Color.Black;
            this.SmartboardSelector.Location = new System.Drawing.Point(12, 219);
            this.SmartboardSelector.Name = "SmartboardSelector";
            this.SmartboardSelector.Size = new System.Drawing.Size(190, 20);
            this.SmartboardSelector.TabIndex = 12;
            this.SmartboardSelector.Text = "Smartboard / Activeboard";
            this.SmartboardSelector.UseVisualStyleBackColor = false;
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(12, 245);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(196, 42);
            this.SaveButton.TabIndex = 13;
            this.SaveButton.Text = "Gem";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.Save_Click);
            // 
            // LogBox
            // 
            this.LogBox.Location = new System.Drawing.Point(229, 27);
            this.LogBox.Multiline = true;
            this.LogBox.Name = "LogBox";
            this.LogBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.LogBox.Size = new System.Drawing.Size(599, 253);
            this.LogBox.TabIndex = 15;
            // 
            // MacAddressBox
            // 
            this.MacAddressBox.Location = new System.Drawing.Point(12, 293);
            this.MacAddressBox.Name = "MacAddressBox";
            this.MacAddressBox.Size = new System.Drawing.Size(196, 20);
            this.MacAddressBox.TabIndex = 14;
            // 
            // Main
            // 
            this.AccessibleDescription = "Computer Info";
            this.AccessibleName = "Computer Info";
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(220, 323);
            this.Controls.Add(this.MacAddressBox);
            this.Controls.Add(this.LogBox);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.SmartboardSelector);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.LaptopSelector);
            this.Controls.Add(this.StationarySelector);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.BUFUUFSelector);
            this.Controls.Add(this.NumberBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LocationBox);
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
        private System.Windows.Forms.ToolStripMenuItem omToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tokensToolStripMenuItem;
        private System.Windows.Forms.TextBox LocationBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox NumberBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton StationarySelector;
        private System.Windows.Forms.RadioButton LaptopSelector;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox BUFUUFSelector;
        private System.Windows.Forms.CheckBox SmartboardSelector;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.TextBox LogBox;
        private System.Windows.Forms.TextBox MacAddressBox;
        private System.Windows.Forms.ToolStripMenuItem NewUpdate;

    }
}