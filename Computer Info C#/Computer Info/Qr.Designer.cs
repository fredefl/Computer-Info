namespace Computer_Info
{
    partial class Qr
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
            this.QrCode = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.QrCode)).BeginInit();
            this.SuspendLayout();
            // 
            // QrCode
            // 
            this.QrCode.AccessibleName = "";
            this.QrCode.Location = new System.Drawing.Point(0, 0);
            this.QrCode.Name = "QrCode";
            this.QrCode.Size = new System.Drawing.Size(512, 512);
            this.QrCode.TabIndex = 0;
            this.QrCode.TabStop = false;
            // 
            // Qr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 512);
            this.Controls.Add(this.QrCode);
            this.Name = "Qr";
            this.Text = "Qr";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Qr_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.QrCode)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox QrCode;
    }
}