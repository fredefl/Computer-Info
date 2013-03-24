using System;
using System.Windows.Forms;
using ComputerInfo;
using System.Diagnostics;
using System.Net;
using System.Reflection;
using Ini;
using System.IO;
using System.Collections.Generic;
using Newtonsoft.Json;
using System.Threading;
using System.Globalization;
using Computer_Info.Resources;
using System.ComponentModel;

using MetroFramework.Forms;
using MetroFramework;
using System.Resources;

namespace Computer_Info
{
    public partial class Main : MetroForm
    {

        IniFile Settings;
        ComputerInfoClass ComputerInfoInstance;
        string WorkingDirectory = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase.Replace("file:///", "")) + @"\";
        string LogString = "Logging Started\r\n";
        Dictionary<string, int> Organizations = new Dictionary<string, int>();
        int LocationBoxItemCount = 0;

        public Main()
        {
            // Force language setting with this line
            //Thread.CurrentThread.CurrentUICulture = CultureInfo.GetCultureInfo("da-DK");

            // Initialize
            InitializeComponent();

            // Form Localization
            OrganizationLabel.Text = Strings.Organization;
            LocationLabel.Text = Strings.Location;
            IdentifierLabel.Text = Strings.Identifier;
            ComputerTypeLabel.Text = Strings.ComputerType;
            DesktopSelector.Text = Strings.Desktop;
            LaptopSelector.Text = Strings.Laptop;
            BoardSelector.Text = Strings.Board;
            SaveButton.Text = Strings.Save;
            
            // Bottom menu Localization
            SignOutLink.Text = Strings.SignOut;
            AboutLink.Text = Strings.About;

            // Check if a Settings.ini file is present, if not create a new one
            if (!File.Exists(WorkingDirectory + "Settings.ini"))
            {
                File.WriteAllText(WorkingDirectory + "Settings.ini", Computer_Info.Properties.Resources.Settings);
            }

            // Initialize settings from file
            Settings = new IniFile(WorkingDirectory + "Settings.ini");
            
            // Set Last Used Organization
            OrganizationBox.Text = Settings.IniReadValue("Settings", "Organization");
           
            // Set Last Used Location
            LocationBox.Text = Settings.IniReadValue("Settings", "Location");
            
            // Check if logged in
            if (GetToken() == "")
            {
                OpenLoginBox(false,true, true);
            }
            
            // Keep validating the token until it's valid
            while (ValidateToken() == false)
            {
                OpenLoginBox(false, true, true);
            }
            
            // Get the organization list
            GetOrganizationList();
            
            // Get the location list
            GetLocationList();
            
            // Create Computer Info Instance
            ComputerInfoInstance = new ComputerInfoClass();
            // REMOVE THIS LINE IN A PRODUCTION ENVIROMENT
            Log(JsonConvert.SerializeObject(ComputerInfoInstance.CreateCompleteComputerInfoObject(), Formatting.Indented));
            
            // Get and set LAN MAC
            string MacAddress = ComputerInfoInstance.GetLanMacAddress(false);
            MacAddressBox.Text = MacAddress;
            
            // Check if a LAN MAC address is available, if not color the form red otherwise green
            /*if (JCS.OSVersionInfo.Name != "Windows 8")
            {
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
            }*/

            // Get Tokens
            string Token = "";
            if (ComputerInfoInstance.StringToBool(Settings.IniReadValue("Settings", "UseTokens"))) 
            {
                Token = Settings.IniReadValue("Settings", "Token");
            }

            // Check For Updates
            //UpdateChecker();
            // Delete Updater Application
            if (File.Exists("ComputerInfoUpdater.exe"))
                File.Delete("ComputerInfoUpdater.exe");
        }

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
            catch
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
            //if (Response == Assembly.GetExecutingAssembly().GetName().Version.ToString())
                //UpdateMenuItem.Visible = false;
            //else
                //UpdateMenuItem.Visible = true;
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
            catch
            {
                Log("Error downloading update");
            }
        }
        #endregion

        #region Location List
        public class LocationObject
        {
            public int id;
            public string name;
        }

        public class LocationRootObject
        {
            public List<LocationObject> result;
            public int count;
            public object error_message;
            public object error_code;
            public string script_excecution_time;
            public int server_time;
        }

        public void GetLocationList()
        {
            string CurrentOrganizationId = "";
            LocationBox.Items.Clear();
            try
            {
                if (OrganizationBox.Text != "")
                {
                    CurrentOrganizationId = Organizations[OrganizationBox.Text].ToString();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Den valgte organization kunne ikke findes, fjern den manuelt i Settings.ini hvis den er blevet slettet");
                return;
            }
            try
            {
                string Url =
                    Properties.Settings.Default.BaseUrl +
                    "/locations/" + CurrentOrganizationId + "?format=json&fields=name,id&token=" + GetToken();
                Log("Locations URL: " + Url);
                WebClient Http = new WebClient();
                Http.Headers.Add("user-agent: CI/Windows");
                Http.DownloadStringAsync(new Uri(Url));
                Http.DownloadStringCompleted += new DownloadStringCompletedEventHandler(GetLocationListResponse);
            }
            catch (WebException)
            {
                Log("Error getting Location list");
            }
            catch (Exception)
            {
                Log("Error getting Location list");
            }
        }

        // Gets the model type response (as it is async)
        public void GetLocationListResponse(Object sender, DownloadStringCompletedEventArgs e)
        {
            var webException = e.Error as WebException;
            if (webException != null && webException.Status == WebExceptionStatus.NameResolutionFailure)
                return;
            try
            {
                string Response = (string)e.Result;
                LocationRootObject Object = JsonConvert.DeserializeObject<LocationRootObject>(Response);
                foreach (LocationObject Location in Object.result)
                {
                    LocationBox.Items.Add(Location.name);
                }
                LocationBoxItemCount = LocationBox.Items.Count;
            }
            catch (Exception)
            {
                Log("Error getting Location list - afterwards");
            }
        }
        #endregion

        #region OrganizationList

        public class OrganizationObject
        {
            public int id;
            public string name;
            public List<string> employees;
        }

        public class OrganizationUserObject
        {
            public int id;
            public List<OrganizationObject> organizations;
            public string email;
            public string name;
        }

        public class OrganizationRootObject
        {
            public OrganizationUserObject result;
            public int count;
            public string error_message;
            public string error_code;
            public string script_excecution_time;
            public int server_time;
        }

        public void GetOrganizationList()
        {
            try
            {
                string Url =
                    Properties.Settings.Default.BaseUrl +
                    "/user/me?format=json&token=" + GetToken();
                Log(Url);
                WebClient Http = new WebClient();
                Http.Headers.Add("user-agent: CI/Windows");
                Http.DownloadStringAsync(new Uri(Url));
                Http.DownloadStringCompleted += new DownloadStringCompletedEventHandler(GetOrganizationListResponse);
            }
            catch (WebException)
            {
                Log("Error getting organization list");
            }
            catch (Exception)
            {
                Log("Error getting organization list");
            }
        }

        public void GetOrganizationListResponse(Object sender, DownloadStringCompletedEventArgs e)
        {
            var webException = e.Error as WebException;
            if (webException != null && webException.Status == WebExceptionStatus.NameResolutionFailure)
                return;
            try
            {
                string Response = (string)e.Result;
                OrganizationRootObject Object = JsonConvert.DeserializeObject<OrganizationRootObject>(Response);
                foreach (OrganizationObject Organization in Object.result.organizations)
                {
                    Organizations.Add(Organization.name, Organization.id);
                    OrganizationBox.Items.Add(Organization.name);
                }
            }
            catch (Exception)
            {
                Log("Error getting organization list - afterwards");
            }
        }
        #endregion


        public bool ValidateToken()
        {
            string Url =
                    Properties.Settings.Default.BaseUrl +
                    "/token/" + GetToken();
            WebClient Http = new WebClient();
            Http.Headers.Add("user-agent: CI/Windows");
            try
            {
                string Result = Http.DownloadString(new Uri(Url));
                if (Result == "true")
                    return true;
                else
                    return false;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public void SetToken(string Token)
        {
            Settings.IniWriteValue("Settings", "Token", Token);
        }

        public string GetToken()
        {
            return Settings.IniReadValue("Settings", "Token");
        }

        public void OpenLoginBox(bool SaveAfterwards = false, bool WaitForClose = false, bool TerminateApplicationOnClose = false)
        {
            foreach (Form CurrentForm in Application.OpenForms)
            {
                if (CurrentForm is LoginBox)
                {
                    if (WaitForClose)
                    {
                        CurrentForm.ShowDialog();
                    }
                    else
                    {
                        CurrentForm.Show();
                    }
                    CurrentForm.BringToFront();
                    return;
                }
            }
            LoginBox LoginBoxForm = new LoginBox(this, SaveAfterwards, TerminateApplicationOnClose);
            if (WaitForClose)
                LoginBoxForm.ShowDialog();
            else
                LoginBoxForm.Show();
        }

        public void Save_Click(object sender, EventArgs e)
        {
            int ComputerType = 7;
            if (LaptopSelector.Checked)
            {
                ComputerType = 1;
            }
            else if (DesktopSelector.Checked)
            {
                ComputerType = 2;
            }
            int OrganizationId = 0;
            try 
            {
                OrganizationId = Organizations[OrganizationBox.Text];
            } catch (Exception) {

            }

            ComputerInfoInstance.SetVariables(IdentifierBox.Text, LocationBox.Text, ComputerType.ToString(), ComputerInfoInstance.BoolToString(BoardSelector.Checked), OrganizationId);

            if (Settings.IniReadValue("Settings", "Token").Length > 0) {
                if (ComputerInfoInstance.SendWithTokens(Settings.IniReadValue("Settings", "Token")))
                {
                    Application.Exit();
                }
            }
            else
            {
                OpenLoginBox(true);
            }
            Settings.IniWriteValue("Settings", "Organization", OrganizationBox.Text);
            Settings.IniWriteValue("Settings", "Location", LocationBox.Text);
        }

        // Log a message
        private void Log(string Message)
        {
            LogString += Message + "\r\n";
            System.IO.File.WriteAllText("Log.log", LogString);
        }

        // When the form is closeing (not hidden), terminate the application
        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        // Change the tabstop when DesktopSelector is checked
        private void DesktopSelector_CheckedChanged(object sender, EventArgs e)
        {
            DesktopSelector.TabStop = true;
        }

        // Change the tabstop when LaptopSelector is checked
        private void LaptopSelector_CheckedChanged(object sender, EventArgs e)
        {
            LaptopSelector.TabStop = true;
        }

        // When the form is closed (not hidden), terminate the application
        private void Main_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void UpdateProgramMenuItem_Click(object sender, EventArgs e)
        {
            UpdateFromServer();
        }

        private void UpdateCacheMenuItem_Click(object sender, EventArgs e)
        {
            OrganizationBox.Items.Clear();
            GetOrganizationList();
            LocationBox.Items.Clear();
            GetLocationList();
        }

        private void OrganizationBox_SelectedValueChanged(object sender, EventArgs e)
        {
            Settings.IniWriteValue("Settings", "Organization", OrganizationBox.Text);
            GetLocationList();
        }

        private void LocationBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Settings.IniWriteValue("Settings", "Location", LocationBox.Text);
        }

        // When the about link is clicked, open the about form
        private void AboutLink_Click(object sender, EventArgs e)
        {
            foreach (Form CurrentForm in Application.OpenForms)
            {
                if (CurrentForm is AboutBox)
                {
                    CurrentForm.BringToFront();
                    return;
                }
            }
            AboutBox AboutboxForm = new AboutBox();
            AboutboxForm.Show();
        }

        // Sign the user out if they click the sign out button
        private void SignOutLink_Click(object sender, EventArgs e)
        {
            Settings.IniWriteValue("Settings", "Token", "");
            System.Windows.Forms.Application.Restart();
        }

        private void metroLink1_Click(object sender, EventArgs e)
        {
            AddLocationBox.Visible = !AddLocationBox.Visible;
            if (AddLocationBox.Visible)
            {
                
            }
            AddLocationBox.Focus();
        }

        private void AddLocationBox_TextChanged(object sender, EventArgs e)
        {
            if (LocationBox.Items.Count > LocationBoxItemCount)
            {
                LocationBox.Items[0] = AddLocationBox.Text;
            }
            else
            {
                LocationBox.Items.Add(AddLocationBox.Text);
            }
            LocationBox.SelectedIndex = 0;
        }
    
    }
}