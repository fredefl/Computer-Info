using System;
using System.Reflection;
using System.Windows.Forms;
using Computer_Info.Resources;

namespace Computer_Info
{
    partial class AboutBox : Form
    {
        /*
         *  VersionStatusImage.Image = Computer_Info.Properties.Resources.Error;
         *  VersionStatusLabel.Text = "Du kører ikke den nyeste version!";
         * */
        public AboutBox()
        {
            InitializeComponent();
            CopyrightLabel.Text = Strings.AboutCopyright;
            DisclaimerLabel.Text = Strings.AboutDisclaimer;
            OpenSourceInfoLabel.Text = Strings.AboutOpenSource;
            VersionStatusLabel.Text = Strings.AboutUpdatesSearching;
            GitHubLinkLabel.Left = Int32.Parse(Strings.AboutGithubLeft);
        }

        private void CloseForm()
        {
            this.Hide();
        }

        private void AboutBox_FormClosing(object sender, FormClosingEventArgs e)
        {
            CloseForm();
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            CloseForm();
        }

        private void AboutBox_Load(object sender, EventArgs e)
        {
            VersionLabel.Text = Assembly.GetExecutingAssembly().GetName().Version.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CloseForm();
        }

        private void GitHubLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/fredefl/Computer-Info");
        }

        private void WebsiteLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://illution.dk");
        }
    }
}
