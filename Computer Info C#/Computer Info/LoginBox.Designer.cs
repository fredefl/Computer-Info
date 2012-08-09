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
            this.LoginBrowser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LoginBrowser.Location = new System.Drawing.Point(0, 0);
            this.LoginBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.LoginBrowser.Name = "LoginBrowser";
            this.LoginBrowser.ScrollBarsEnabled = false;
            this.LoginBrowser.Size = new System.Drawing.Size(466, 357);
            this.LoginBrowser.TabIndex = 0;
            this.LoginBrowser.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.LoginBrowser_DocumentCompleted);
            // 
            // LoginBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 357);
            this.Controls.Add(this.LoginBrowser);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LoginBox";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Shown += new System.EventHandler(this.LoginBox_Shown);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.WebBrowser LoginBrowser;
    }
}