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
            this.panel1 = new System.Windows.Forms.Panel();
            this.ForwardButton = new System.Windows.Forms.Button();
            this.BackButton = new System.Windows.Forms.Button();
            this.AddressBox = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
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
            // panel1
            // 
            this.panel1.Controls.Add(this.ForwardButton);
            this.panel1.Controls.Add(this.BackButton);
            this.panel1.Controls.Add(this.AddressBox);
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // ForwardButton
            // 
            resources.ApplyResources(this.ForwardButton, "ForwardButton");
            this.ForwardButton.Name = "ForwardButton";
            this.ForwardButton.UseVisualStyleBackColor = true;
            this.ForwardButton.Click += new System.EventHandler(this.ForwardButton_Click);
            // 
            // BackButton
            // 
            resources.ApplyResources(this.BackButton, "BackButton");
            this.BackButton.Name = "BackButton";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // AddressBox
            // 
            this.AddressBox.BackColor = System.Drawing.SystemColors.Control;
            this.AddressBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.AddressBox, "AddressBox");
            this.AddressBox.Name = "AddressBox";
            this.AddressBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AddressBox_KeyPress);
            // 
            // LoginBox
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.SignInBrowser);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "LoginBox";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.LoginBox_FormClosing);
            this.Shown += new System.EventHandler(this.LoginBox_Shown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.WebBrowser SignInBrowser;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button ForwardButton;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.TextBox AddressBox;
    }
}