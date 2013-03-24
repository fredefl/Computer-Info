namespace Computer_Info
{
    partial class LoginBox
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginBox));
            this.SignInBrowser = new System.Windows.Forms.WebBrowser();
            this.AddressBox = new MetroFramework.Controls.MetroTextBox();
            this.SignInSpinner = new MetroFramework.Controls.MetroProgressSpinner();
            this.BackButton = new MetroFramework.Controls.MetroLink();
            this.SuspendLayout();
            // 
            // SignInBrowser
            // 
            resources.ApplyResources(this.SignInBrowser, "SignInBrowser");
            this.SignInBrowser.Name = "SignInBrowser";
            this.SignInBrowser.ScriptErrorsSuppressed = true;
            this.SignInBrowser.ScrollBarsEnabled = false;
            this.SignInBrowser.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.LoginBrowser_DocumentCompleted);
            this.SignInBrowser.Navigating += new System.Windows.Forms.WebBrowserNavigatingEventHandler(this.LoginBrowser_Navigating);
            // 
            // AddressBox
            // 
            resources.ApplyResources(this.AddressBox, "AddressBox");
            this.AddressBox.BackColor = System.Drawing.SystemColors.Control;
            this.AddressBox.CustomBackground = false;
            this.AddressBox.CustomForeColor = false;
            this.AddressBox.FontSize = MetroFramework.MetroTextBoxSize.Small;
            this.AddressBox.FontWeight = MetroFramework.MetroTextBoxWeight.Regular;
            this.AddressBox.Multiline = false;
            this.AddressBox.Name = "AddressBox";
            this.AddressBox.SelectedText = "";
            this.AddressBox.Style = MetroFramework.MetroColorStyle.Blue;
            this.AddressBox.StyleManager = null;
            this.AddressBox.Theme = MetroFramework.MetroThemeStyle.Light;
            this.AddressBox.UseStyleColors = false;
            this.AddressBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AddressBox_KeyPress);
            // 
            // SignInSpinner
            // 
            this.SignInSpinner.CustomBackground = false;
            resources.ApplyResources(this.SignInSpinner, "SignInSpinner");
            this.SignInSpinner.Maximum = 100;
            this.SignInSpinner.Name = "SignInSpinner";
            this.SignInSpinner.Style = MetroFramework.MetroColorStyle.Blue;
            this.SignInSpinner.StyleManager = null;
            this.SignInSpinner.Theme = MetroFramework.MetroThemeStyle.Light;
            this.SignInSpinner.Value = 66;
            // 
            // BackButton
            // 
            resources.ApplyResources(this.BackButton, "BackButton");
            this.BackButton.CustomBackground = false;
            this.BackButton.CustomForeColor = false;
            this.BackButton.FontSize = MetroFramework.MetroLinkSize.Tall;
            this.BackButton.FontWeight = MetroFramework.MetroLinkWeight.Regular;
            this.BackButton.Name = "BackButton";
            this.BackButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.BackButton.StyleManager = null;
            this.BackButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.BackButton.UseStyleColors = false;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // LoginBox
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.SignInBrowser);
            this.Controls.Add(this.AddressBox);
            this.Controls.Add(this.SignInSpinner);
            this.Controls.Add(this.BackButton);
            this.Name = "LoginBox";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.LoginBox_FormClosing);
            this.Shown += new System.EventHandler(this.LoginBox_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.WebBrowser SignInBrowser;
        private MetroFramework.Controls.MetroTextBox AddressBox;
        private MetroFramework.Controls.MetroProgressSpinner SignInSpinner;
        private MetroFramework.Controls.MetroLink BackButton;
    }
}