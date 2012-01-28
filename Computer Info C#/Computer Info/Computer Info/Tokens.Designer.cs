namespace Computer_Info
{
    partial class Tokens
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tokens));
            this.Token1Box = new System.Windows.Forms.TextBox();
            this.Token2Box = new System.Windows.Forms.TextBox();
            this.UseTokensCheck = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Save = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Token1Box
            // 
            this.Token1Box.Location = new System.Drawing.Point(12, 56);
            this.Token1Box.Name = "Token1Box";
            this.Token1Box.Size = new System.Drawing.Size(202, 20);
            this.Token1Box.TabIndex = 0;
            // 
            // Token2Box
            // 
            this.Token2Box.Location = new System.Drawing.Point(12, 98);
            this.Token2Box.Name = "Token2Box";
            this.Token2Box.Size = new System.Drawing.Size(202, 20);
            this.Token2Box.TabIndex = 1;
            // 
            // UseTokensCheck
            // 
            this.UseTokensCheck.AutoSize = true;
            this.UseTokensCheck.BackColor = System.Drawing.Color.Transparent;
            this.UseTokensCheck.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.UseTokensCheck.ForeColor = System.Drawing.Color.Black;
            this.UseTokensCheck.Location = new System.Drawing.Point(12, 9);
            this.UseTokensCheck.Name = "UseTokensCheck";
            this.UseTokensCheck.Size = new System.Drawing.Size(105, 20);
            this.UseTokensCheck.TabIndex = 2;
            this.UseTokensCheck.Text = "Brug Tokens";
            this.UseTokensCheck.UseVisualStyleBackColor = false;
            this.UseTokensCheck.CheckedChanged += new System.EventHandler(this.UseTokensCheck_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(9, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Token 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(9, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Token 2";
            // 
            // Save
            // 
            this.Save.Location = new System.Drawing.Point(11, 125);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(203, 33);
            this.Save.TabIndex = 5;
            this.Save.Text = "Gem";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // Tokens
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(226, 168);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.UseTokensCheck);
            this.Controls.Add(this.Token2Box);
            this.Controls.Add(this.Token1Box);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Tokens";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tokens";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Tokens_FormClosing);
            this.Shown += new System.EventHandler(this.Tokens_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Token1Box;
        private System.Windows.Forms.TextBox Token2Box;
        private System.Windows.Forms.CheckBox UseTokensCheck;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Save;
    }
}