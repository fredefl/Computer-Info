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
            this.WBrowser = new System.Windows.Forms.WebBrowser();
            this.SuspendLayout();
            // 
            // WBrowser
            // 
            this.WBrowser.Location = new System.Drawing.Point(0, 0);
            this.WBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.WBrowser.Name = "WBrowser";
            this.WBrowser.Size = new System.Drawing.Size(328, 678);
            this.WBrowser.TabIndex = 0;
            this.WBrowser.Url = new System.Uri("http://illution.dk/About/IE", System.UriKind.Absolute);
            // 
            // AboutBox
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.Graphic;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(311, 674);
            this.Controls.Add(this.WBrowser);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AboutBox";
            this.Padding = new System.Windows.Forms.Padding(9);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Om";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AboutBox_FormClosing);
            this.Load += new System.EventHandler(this.AboutBox_Load);
            this.Shown += new System.EventHandler(this.AboutBox_Shown);
            this.ResumeLayout(false);

        }

        #endregion

        private WebBrowser WBrowser;


    }
}
