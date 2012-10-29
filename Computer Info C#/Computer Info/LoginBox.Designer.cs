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
            this.LoginBrowser = new System.Windows.Forms.WebBrowser();
            this.SuspendLayout();
            // 
            // LoginBrowser
            // 
            resources.ApplyResources(this.LoginBrowser, "LoginBrowser");
            this.LoginBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.LoginBrowser.Name = "LoginBrowser";
            this.LoginBrowser.ScriptErrorsSuppressed = true;
            this.LoginBrowser.ScrollBarsEnabled = false;
            this.LoginBrowser.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.LoginBrowser_DocumentCompleted);
            // 
            // LoginBox
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.LoginBrowser);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "LoginBox";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.LoginBox_FormClosing);
            this.Shown += new System.EventHandler(this.LoginBox_Shown);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.WebBrowser LoginBrowser;
    }
}