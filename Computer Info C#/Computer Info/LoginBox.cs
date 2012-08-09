using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Computer_Info
{
    public partial class LoginBox : Form
    {
        private Main ParentForm;

        public LoginBox (Main _ParentForm)
        {
            InitializeComponent();
            ParentForm = _ParentForm;
        }

        private void LoginBox_Shown(object sender, EventArgs e)
        {
            LoginBrowser.Navigate("https://illution.dk/ClickThis/login/google");
        }

        private void LoginBrowser_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            if (LoginBrowser.Url.ToString() == "")
            {
                ParentForm.SetToken(Regex.Replace(LoginBrowser.DocumentText, @"<[^>]*>", String.Empty));
            }
        }
    }
}
