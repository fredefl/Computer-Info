using System;
using System.Windows.Forms;
using ComputerInfoClass;
using System.Diagnostics;
using System.Net;
using System.Reflection;
using Ini;
using System.IO;
using System.Web;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Computer_Info
{
    public partial class Main : Form
    {

        #region Location List
        public class LocationObject
        {
            public int id { get; set; }
            public string name { get; set; }
            public string Location_number { get; set; }
            public string organization { get; set; }
        }

        public class LocationRootObject
        {
            public List<LocationObject> Locations { get; set; }
            public int count { get; set; }
            public object error_message { get; set; }
            public object error_code { get; set; }
            public string script_excecution_time { get; set; }
            public int server_time { get; set; }
        }

        public void GetLocationList()
        {
            try
            {
                string Url = 
                    Properties.Settings.Default.BaseUrl + 
                    "options/location/?organization=1&format=json&dev=true";
                WebClient Http = new WebClient();
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
                foreach (LocationObject Location in Object.Locations)
                {
                    LocationBox.Items.Add(Location.name);
                }
            }
            catch (Exception)
            {
                Log("Error getting Location list");
            }
        }
        #endregion

        #region OrganizationList
        public class OrganizationEmployeesObject
        {
            public int id { get; set; }
            public List<string> organizations { get; set; }
            public string email { get; set; }
            public string name { get; set; }
        }

        public class OrganizationObject
        {
            public int id { get; set; }
            public string name { get; set; }
            public OrganizationEmployeesObject employees { get; set; }
        }

        public class OrganizationUserObject
        {
            public int id { get; set; }
            public List<OrganizationObject> organizations { get; set; }
            public string email { get; set; }
            public string name { get; set; }
        }

        public class OrganizationRootObject
        {
            public OrganizationUserObject User { get; set; }
            public int count { get; set; }
            public object error_message { get; set; }
            public object error_code { get; set; }
            public string script_excecution_time { get; set; }
            public int server_time { get; set; }
        }

        public void GetOrganizationList()
        {
            try
            {
                string Url =
                    Properties.Settings.Default.BaseUrl +
                    "user/me?format=json&dev=true";
                WebClient Http = new WebClient();
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
                foreach (OrganizationObject Organization in Object.User.organizations)
                {
                    OrganizationBox.Items.Add(Organization.name);
                }
            }
            catch (Exception)
            {
                Log("Error getting organization list");
            }
        }
        #endregion
       
        IniFile Settings = new IniFile(Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase.Replace("file:///", "")) + "/Settings.ini");
        ComputerInfo ComputerInfoInstance;
        string LogString = "Logging Started\r\n";

        public void SetToken (string Token)
        {
            Settings.IniWriteValue("Settings", "Token", Token);
        }

        public void OpenLoginBox(bool SaveAfterwards = false)
        {
            foreach (Form CurrentForm in Application.OpenForms)
            {
                if (CurrentForm is LoginBox)
                {
                    CurrentForm.BringToFront();
                    return;
                }
            }
            LoginBox LoginBoxForm = new LoginBox(this, SaveAfterwards);
            LoginBoxForm.Show();
        }

        public Main()
        {
            // Initialize
            InitializeComponent();
            // Get the organization list
            GetOrganizationList();
            // Get the location list
            GetLocationList();
            // Create Computer Info Instance
            ComputerInfoInstance = new ComputerInfo();
            foreach (ComputerInfoClass.ComputerInfo.GraphicsCardObject GraphicsCard in ComputerInfoInstance.GetGraphicsCards())
            {
                MessageBox.Show(GraphicsCard.ram_size);
            }
            // Remove Dot
            //BUFUUFSelector.SelectedIndex = 0;
            // Set Last Used Organization
            OrganizationBox.Text = Settings.IniReadValue("Settings", "Organization");
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
            string Token = "";
            if (ComputerInfoInstance.StringToBool(Settings.IniReadValue("Settings", "UseTokens")))
             {
                Token = Settings.IniReadValue("Settings", "Token");
             }
            // Guess ComputerType (SBB)
            if(Token != "")
            {
                //GetModelType(Token);
            }
            // Check For Updates
            //UpdateChecker();
            // Delete Updater Application
            if (File.Exists("ComputerInfoUpdater.exe"))
                File.Delete("ComputerInfoUpdater.exe");
        }

        public void Save_Click(object sender, EventArgs e)
        {
            bool SBB;
            if (LaptopSelector.Checked) SBB = true; else SBB = false;
            ComputerInfoInstance.SetVariables(IdentifierBox.Text, LocationBox.Text, ComputerInfoInstance.BoolToString(SBB), ComputerInfoInstance.BoolToString(SmartboardSelector.Checked), OrganizationBox.Text);

            if (Settings.IniReadValue("Settings", "Token").Length > 0) {
                ComputerInfoInstance.SendWithTokens(Settings.IniReadValue("Settings", "Token"));
                Application.Exit();
            }
            else
            {
                OpenLoginBox(true);
            }
            Settings.IniWriteValue("Settings", "Organization", OrganizationBox.Text);
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
            catch (WebException)
            {
                Log("Error getting model type");
            }
            catch (Exception)
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
            try
            {
                string Response = (string)e.Result;
                if (Response == "0")
                    StationarySelector.Checked = true;
                if (Response == "1")
                    LaptopSelector.Checked = true;
            }
            catch (Exception)
            {

            }
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
            if (Response == Assembly.GetExecutingAssembly().GetName().Version.ToString())
                UpdateMenuItem.Visible = false;
            else
                UpdateMenuItem.Visible = true;
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

        // Log a message
        private void Log(string Message)
        {
            LogString += Message + "\r\n";
            System.IO.File.WriteAllText("Log.log", LogString);
        }

        // When the about menu item is clicked, open the about form
        private void omToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void LoginMenuItem_Click(object sender, EventArgs e)
        {
            OpenLoginBox();
        }

        private void programToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateFromServer();
        }

        private void cacheToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OrganizationBox.Items.Clear();
            GetOrganizationList();
            LocationBox.Items.Clear();
            GetLocationList();
        }
    
    }
}