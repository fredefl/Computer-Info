using System;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using Computer_Info.Resources;
using System.Drawing;

using MetroFramework.Forms;
using MetroFramework;

namespace Computer_Info
{
    public partial class LoginBox : MetroForm
    {
        private Main ParentMaintForm;
        private bool SaveAfterwards;
        private bool TerminateApplicationOnClose;

        public LoginBox(Main _ParentMainForm, bool _SaveAfterwards, bool _TerminateApplicationOnClose)
        {
            InitializeComponent();
            ParentMaintForm = _ParentMainForm;
            SaveAfterwards = _SaveAfterwards;
            TerminateApplicationOnClose = _TerminateApplicationOnClose;
            this.Text = Strings.SignIn;
        }

        private void LoginBox_Shown(object sender, EventArgs e)
        {
            SignInBrowser.Navigate(Computer_Info.Properties.Settings.Default.BaseUrl + "/windows/login?language=" + Strings.CurrentLanguage);
        }

        private void LoginBrowser_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            SignInBrowser.Show();
            if (SignInBrowser.Url.ToString().Contains(Computer_Info.Properties.Settings.Default.BaseUrl + "/login/windows"))
            {
                string CleanText = Regex.Replace(SignInBrowser.DocumentText, @"<[^>]*>", String.Empty).Trim();
                
                if (CleanText != "")
                {
                    ParentMaintForm.SetToken(CleanText);
                    this.Hide();
                    if (SaveAfterwards)
                    {
                        ParentMaintForm.Save_Click(null, null);
                    }
                }
                else
                {
                    SignInBrowser.Navigate(Computer_Info.Properties.Settings.Default.BaseUrl + "/windows/login");
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

        private void LoginBrowser_Navigating(object sender, WebBrowserNavigatingEventArgs e)
        {
            AddressBox.Text = e.Url.ToString();
        }

        private void ForwardButton_Click(object sender, EventArgs e)
        {
            SignInBrowser.GoForward();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            SignInBrowser.GoBack();
        }

        private void AddressBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13) {
                SignInBrowser.Navigate(AddressBox.Text);
            }
        }
    }
}
