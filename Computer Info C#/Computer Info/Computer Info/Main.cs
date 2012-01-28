using System;
using System.Windows.Forms;
using ComputerInfoClass;
using System.Diagnostics;
using System.Net;
using System.Reflection;
using Ini;
using System.IO;

namespace Computer_Info
{
    public partial class Main : Form
    {
        IniFile Settings = new IniFile(Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase.Replace("file:///", "")) + "/Settings.ini");
        ComputerInfo ComputerInfoInstance;
        string LogString = "Logging Started\r\n";

        public Main()
        {   
            // Initialize
            InitializeComponent();
            // Create Computer Info Instance
            ComputerInfoInstance = new ComputerInfo();
            // Remove Dot
            BUFUUFSelector.SelectedIndex = 0;
            // Set Last Used School
            SchoolBox.Text = Settings.IniReadValue("Settings", "School");
            // Set Last Used Location
            LocationBox.Text = Settings.IniReadValue("Settings", "Location");
            // Initialize WMIC
            ComputerInfoInstance.GetComputerModel();
            // Get and Set LanMac
            string MacAddress = ComputerInfoInstance.GetLanMacAddress(false);
            MacAddressBox.Text = MacAddress;
            if (MacAddress.Length == 17)
            {
                MainMenu.BackgroundImage = Computer_Info.Properties.Resources.GreenBar;
                this.BackgroundImage = Computer_Info.Properties.Resources.GreenBar;
            }
            else
            {
                MainMenu.BackgroundImage = Computer_Info.Properties.Resources.RedBar;
                this.BackgroundImage = Computer_Info.Properties.Resources.RedBar;
            }
            // Get Tokens
            string Token1 = "";
            string Token2 = "";
            if (ComputerInfoInstance.StringToBool(Settings.IniReadValue("Settings", "UseTokens")))
             {
                Token1 = Settings.IniReadValue("Settings", "Token1");
                Token2 = Settings.IniReadValue("Settings", "Token2");
             }
            // Guess ComputerType (SBB)
            if(Token1 != "" && Token2 != "")
            {
                GetModelType(Token1, Token2);
            }
            // Check For Updates
            UpdateChecker();
            // Delete Updater Application
            if (File.Exists("ComputerInfoUpdater.exe"))
                File.Delete("ComputerInfoUpdater.exe");
        }

        private void Save_Click(object sender, EventArgs e)
        {
            bool SBB;
            if (LaptopSelector.Checked) SBB = true; else SBB = false;
            ComputerInfoInstance.SetVariables(BUFUUFSelector.Text, NumberBox.Text, LocationBox.Text, ComputerInfoInstance.BoolToString(SBB), ComputerInfoInstance.BoolToString(SmartboardSelector.Checked), SchoolBox.Text);

            if (ComputerInfoInstance.StringToBool(Settings.IniReadValue("Settings", "UseTokens")))
            {
                ComputerInfoInstance.SendWithTokens(Settings.IniReadValue("Settings", "Token1"), Settings.IniReadValue("Settings", "Token2"));
                Application.Exit();
            }
            else
            {
                MessageBox.Show("Tokens er ikke indtastet");
            }
            Settings.IniWriteValue("Settings", "School", SchoolBox.Text);
            Settings.IniWriteValue("Settings", "Location", LocationBox.Text);
        }

        #region ModelType
        // Gets the model type
        public void GetModelType(string Token1, string Token2)
        {
            try
            {
                string Url = "http://illution.dk/Computerinfo/ModelResolver.php?Data=" + Convert.ToBase64String(System.Text.UTF8Encoding.UTF8.GetBytes("Token1=" + Token1 + "&Token2=" + Token2 + "&Model=" + ComputerInfoInstance.GetComputerModel()));
                WebClient Http = new WebClient();
                Http.DownloadStringAsync(new Uri(Url));
                Http.DownloadStringCompleted += new DownloadStringCompletedEventHandler(GetModelTypeResponse);
            }
            catch (WebException ex)
            {
                Log("Error getting model type");
            }

        }
        // Gets the model type response (as it is async)
        public void GetModelTypeResponse(Object sender, DownloadStringCompletedEventArgs e)
        {
            var webException = e.Error as WebException;
            if (webException != null && webException.Status == WebExceptionStatus.NameResolutionFailure)
                return;

            string Response = (string)e.Result;
            if (Response == "0")
                StationarySelector.Checked = true;
            if (Response == "1")
                LaptopSelector.Checked = true;
        }
        #endregion
        #region Updater & Update Checker
        // Starts update check
        public void UpdateChecker()
        {
            try
            {
                string Url = "http://illution.dk/download/VersionInfo.php?F=ComputerInfoCSharp";
                WebClient Http = new WebClient();
                Http.DownloadStringAsync(new Uri(Url));
                Http.DownloadStringCompleted += new DownloadStringCompletedEventHandler(UpdateCheckerResponse);
            }
            catch (WebException ex)
            {
                Log("Error getting update information");
            }

        }
        // Get the update check response (as it is async)
        public void UpdateCheckerResponse(Object sender, DownloadStringCompletedEventArgs e)
        {
            var webException = e.Error as WebException;
            if (webException != null && webException.Status == WebExceptionStatus.NameResolutionFailure)
                return;

            string Response = (string)e.Result;
            if (Response == Assembly.GetExecutingAssembly().GetName().Version.ToString())
                NewUpdate.Visible = false;
            else
                NewUpdate.Visible = true;
        }
        // Update the application
        public void UpdateFromServer()
        {
            try
            {
                WebClient Http = new WebClient();
                Http.DownloadFile("http://illution.dk/download/ComputerInfoUpdater.exe", "ComputerInfoUpdater.exe");
                Process UpdaterProcess = new Process();
                UpdaterProcess.StartInfo.FileName = "ComputerInfoUpdater.exe";
                UpdaterProcess.Start();
                Application.Exit();
            }
            catch (WebException ex)
            {
                Log("Error downloading update");
            }
        }
        #endregion

        // Log a message
        private void Log(string Message)
        {
            LogString += Message + "\r\n";
            System.IO.File.WriteAllText("Log.log", LogString);
        }

        // When the about menu item is clicked, open the about form
        private void omToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox AboutboxForm = new AboutBox();
            AboutboxForm.Show();
            this.Hide();
        }

        // When the tokens menu item is clicked, open the tokens form
        private void tokensToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Tokens TokensForm = new Tokens();
            TokensForm.Show();
        }

        // When the form is closeing (not hidden), terminate the application
        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        // Change the tabstop when StationarySelector is checked
        private void Stationary_CheckedChanged(object sender, EventArgs e)
        {
            StationarySelector.TabStop = true;
        }

        // Change the tabstop when LaptopSelector is checked
        private void Laptop_CheckedChanged(object sender, EventArgs e)
        {
            LaptopSelector.TabStop = true;
        }

        // When the form is closed (not hidden), terminate the application
        private void Main_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        // Update the program when NewUpdate button is clicked
        private void NewUpdate_Click(object sender, EventArgs e)
        {
            UpdateFromServer();
        }
    
    }
}
