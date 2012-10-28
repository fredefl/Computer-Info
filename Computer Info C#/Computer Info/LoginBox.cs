using System;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Computer_Info
{
    public partial class LoginBox : Form
    {
        private Main ParentForm;
        private bool SaveAfterwards;
        private bool TerminateApplicationOnClose;
        private bool Success = false;

        public LoginBox(Main _ParentForm, bool _SaveAfterwards, bool _TerminateApplicationOnClose)
        {
            InitializeComponent();
            ParentForm = _ParentForm;
            SaveAfterwards = _SaveAfterwards;
            TerminateApplicationOnClose = _TerminateApplicationOnClose;
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

        private void LoginBox_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (TerminateApplicationOnClose && e.CloseReason == CloseReason.UserClosing)
            {
                Environment.Exit(0);
            }
        }
    }
}
