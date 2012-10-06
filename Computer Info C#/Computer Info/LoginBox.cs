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
            LoginBrowser.Navigate(Computer_Info.Properties.Settings.Default.BaseUrl + "/windows/login");
        }

        private void LoginBrowser_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            if (LoginBrowser.Url.ToString().Contains(Computer_Info.Properties.Settings.Default.BaseUrl + "/login/windows"))
            {
                string CleanText = Regex.Replace(LoginBrowser.DocumentText, @"<[^>]*>", String.Empty).Trim();
                
                if (CleanText != "")
                {
                    ParentForm.SetToken(CleanText);
                    this.Hide();
                    if (SaveAfterwards)
                    {
                        ParentForm.Save_Click(null, null);
                    }
                }
                else
                {
                    LoginBrowser.Navigate(Computer_Info.Properties.Settings.Default.BaseUrl + "/windows/login");
                }
            }
        }
    }
}
