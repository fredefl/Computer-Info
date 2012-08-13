using System;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Computer_Info
{
    public partial class LoginBox : Form
    {
        private Main ParentForm;
        private bool SaveAfterwards;

        public LoginBox (Main _ParentForm, bool _SaveAfterwards)
        {
            InitializeComponent();
            ParentForm = _ParentForm;
            SaveAfterwards = _SaveAfterwards;
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
                this.Hide();
                if (SaveAfterwards)
                {
                    ParentForm.Save_Click(null, null);
                }
            }
        }
    }
}
