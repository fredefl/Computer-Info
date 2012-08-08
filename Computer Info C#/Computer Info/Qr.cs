using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Computer_Info
{
    public partial class Qr : Form
    {
        public void SetQrCodeUrl(string Url)
        {
            QrCode.ImageLocation = Url;
        }
        public Qr()
        {
            InitializeComponent();
        }

        private void Qr_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
