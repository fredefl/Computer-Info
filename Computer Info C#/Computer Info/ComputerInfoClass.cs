using System;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Diagnostics;
using System.Net.NetworkInformation;
using System.Net;
using System.Management;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using System.Collections.Generic;


namespace ComputerInfoClass
{
    class ComputerInfo
    {   
        // Full Constructor
        /// <summary>
        /// Makes a full ComputerInfo Class
        /// </summary>
        /// <param name="BUFUUF">Wherever it's BUF or UUF</param>
        /// <param name="Number">The BUF/UUF Number</param>
        /// <param name="Location">Location</param>
        /// <param name="SBB">Stationary/Laptop</param>
        /// <param name="SB">Smartboard</param>
        /// <param name="Organization">Organization</param>
        public ComputerInfo(string Identifier, string Location, string SBB, string SB, string Organization)
        {
            // Constructor!
            _Identifier = Identifier;
            _Location = Location;
            _SBB = SBB;
            _SB = SB;
            _Organization = Organization;
        }
        
        // Empty Constructor
        /// <summary>
        /// Makes an empty ComputerInfo Class
        /// </summary>
        public ComputerInfo()
        {
            // Constructor!
            _Identifier = "";
            _Location = "";
            _SBB = "";
            _SB = "";
            _Organization = "";
        }
        
        #region Vars
        public string _Identifier = "";
        public string _Location = "";
        public string _SBB = "";
        public string _SB = "";
        public string _Organization = "";
        #endregion      
        #region Dll
        [DllImport("kernel32", CharSet = CharSet.Auto)]
        	static extern int GetDiskFreeSpaceEx(
         	string lpDirectoryName,
         	out ulong lpFreeBytesAvailable,
         	out ulong lpTotalNumberOfBytes,
         	out ulong lpTotalNumberOfFreeBytes);
        ManagementObjectSearcher Search = new ManagementObjectSearcher("Select * From Win32_ComputerSystem");
        #endregion
        #region Functions (Doc)
        #region Helper Functions (Doc)
        // Get Cmd Output
        /// <summary>
        /// Get output from a CMD command.
        /// </summary>
        /// <param name="Parameters">Parameters</param>
        /// <returns>The output of the CMD command</returns>
        private string Cmd(string Parameters)
        {
            Process p = new Process();
            p.StartInfo = new ProcessStartInfo("cmd", "/C "+Parameters)
            {
                RedirectStandardOutput = true,
                UseShellExecute = false,
                CreateNoWindow = true
            };
            p.Start();
            string output = p.StandardOutput.ReadToEnd();
            p.WaitForExit();
            return output;
        }
        // Check wherever it's a Lan IP Address or not
        /// <summary>
        /// Check wherever it's a Lan IP Address or not
        /// </summary>
        /// <param name="IpAddress">IP Address</param>
        /// <returns>The result</returns>
        public bool IsLanIp(string IpAddress)
        {
            Regex Pattern = new Regex(@"10\.87\.45\.");
            return Pattern.IsMatch(IpAddress);
        }
        // Check wherever we're on a Windows XP machine or not
        /// <summary>
        /// Check wherever we're on a Windows XP machine or not
        /// </summary>
        /// <returns>The result</returns>
        public bool IsXp ()
        {
            System.OperatingSystem osInfo = System.Environment.OSVersion;
            if (osInfo.Version.Major == 5)
                return true;
            else
                return false;
        }
        // String To Boolean
        /// <summary>
        /// Converts a string to a boolean
        /// </summary>
        /// <param name="Input">Input string</param>
        /// <returns>Output boolean</returns>
        public bool StringToBool(string Input)
        {
            if (Input == "1") return true; else return false;
        }
        // Boolean To String
        /// <summary>
        /// Converts a boolean to a string
        /// </summary>
        /// <param name="Input">Input boolean</param>
        /// <returns>Output string</returns>
        public string BoolToString(bool Input)
        {
            if (Input) return "1"; else return "0";
        }
        #endregion
        #region ComputerInfo Functions (Doc)
        public class GraphicsCardManufacturerObject
        {
            public string name { get; set; }
        }
        public class GraphicsCardModelObject
        {
            public string caption { get; set; }
            public GraphicsCardManufacturerObject manufacturer { get; set; }
            public string name { get; set; }
            public string description { get; set; }
            public string video_processor { get; set; }
        }
        public class GraphicsCardScreenSizeObject
        {
            public string width { get; set; }
            public string height { get; set; }
        }
        public class GraphicsCardObject
        {
            public GraphicsCardModelObject model { get; set; }
            public string driver_version { get; set; }
            public string driver_date { get; set; }
            public string ram_size { get; set; }
            public GraphicsCardScreenSizeObject screen_size { get; set; }
        }

        public List<GraphicsCardObject> GetGraphicsCards()
        {
            List<GraphicsCardObject> GraphicsCards = new List<GraphicsCardObject>();
            ManagementObjectSearcher query = new ManagementObjectSearcher("SELECT * FROM Win32_VideoController");
            ManagementObjectCollection coll = query.Get();
            foreach (ManagementObject mo in coll)
            {
                GraphicsCardObject GraphicsCard = new GraphicsCardObject();
                try
                {
                    GraphicsCard.driver_version = mo["DriverVersion"].ToString();
                    GraphicsCard.driver_date = mo["DriverDate"].ToString();
                    GraphicsCard.ram_size = Math.Round(Convert.ToDouble(mo["AdapterRAM"]) / 1048576).ToString();
                } 
                catch { }

                GraphicsCard.model = new GraphicsCardModelObject();
                try
                {
                    
                    GraphicsCard.model.caption = mo["Caption"].ToString();
                    GraphicsCard.model.name = mo["Name"].ToString();
                    GraphicsCard.model.description = mo["Description"].ToString();
                    GraphicsCard.model.video_processor = mo["VideoProcessor"].ToString();
                } 
                catch { }
                
                GraphicsCard.screen_size = new GraphicsCardScreenSizeObject();
                try
                {
                    GraphicsCard.screen_size.height = mo["CurrentVerticalResolution"].ToString();
                    GraphicsCard.screen_size.width = mo["CurrentHorizontalResolution"].ToString();
                }
                catch { }
                GraphicsCards.Add(GraphicsCard);
            }
            return GraphicsCards;
        }
        // Get Screen Height
        /// <summary>
        /// Gets the screen height
        /// </summary>
        /// <returns>The screen height in pixels</returns>
        public string GetScreenHeight()
        {
            return Screen.PrimaryScreen.Bounds.Height.ToString();
        }
        // Get Screen Width
        /// <summary>
        /// Gets the screen width
        /// </summary>
        /// <returns>The screen width in pixels.</returns>
        public string GetScreenWidth()
        {
            return Screen.PrimaryScreen.Bounds.Width.ToString();
        }
        // Get Computer Name
        /// <summary>
        /// Gets the computers name
        /// </summary>
        /// <returns>The computers name</returns>
        public string GetComputerName()
        {
            return System.Environment.MachineName;
        }
        // Get Total Disk Space
        /// <summary>
        /// Gets the total disk space
        /// </summary>
        /// <returns>The total disk space</returns>
        public string GetTotalDiskSpace()
        {
            ulong freeBytesAvailable, totalBytes, freeBytes;
            GetDiskFreeSpaceEx("C:", out freeBytesAvailable, out totalBytes, out freeBytes);
            return Convert.ToInt32(totalBytes / 1024 / 1024 / 1024).ToString();
        }
        // Get Computer Model
        /// <summary>
        /// Gets the computer model
        /// </summary>
        /// <returns>The computer model</returns>
        public string GetComputerModel()
        {
            return Cmd("wmic csproduct get name").Replace("Name", "").Trim();
        }
        // Get Cpu name
        /// <summary>
        /// Gets the CPU name
        /// </summary>
        /// <returns>The CPU name</returns>
        public string GetCpuName()
        {
            return Cmd("wmic cpu get name").Replace("Name", "").Trim();
        }
        // Get Computer Serial
        /// <summary>
        /// Gets the computers serial number
        /// </summary>
        /// <returns>The computers serial number</returns>
        public string GetComputerSerial()
        {
            return Cmd("wmic bios get serialnumber").Replace("SerialNumber", "").Trim();
        }
        // Get Cpu Core Count
        /// <summary>
        /// Gets the CPU core count
        /// </summary>
        /// <returns>CPU core count</returns>
        public string GetCpuCoreCount()
        {
            return Environment.ProcessorCount.ToString();
        }
        // Get Mac Address
        /// <summary>
        /// Gets the MAC Address
        /// </summary>
        /// <returns>The computers MAC Address</returns>
        public string GetMacAddress()
        {
            string macAddresses = "";

            foreach (NetworkInterface nic in NetworkInterface.GetAllNetworkInterfaces())
            {
                if (nic.OperationalStatus == OperationalStatus.Up)
                    {
                        macAddresses += nic.GetPhysicalAddress().ToString();
                        break;
                    }
            }
            return macAddresses;

        }
        // Get Lan Mac Address
        /// <summary>
        /// Gets the LAN MAC Address
        /// </summary>
        /// <param name="All">Wherever it should return all MAC Addresses</param>
        /// <returns>The MAC Address(es)</returns>
        public string GetLanMacAddress(bool All = false)
        {
            
            int istherearesult = 0;
            string Output = "";
            NetworkInterface[] interfaces = NetworkInterface.GetAllNetworkInterfaces();
            foreach (NetworkInterface adapter in interfaces)
            {

                if (!IsXp()) 
                {
                    if (adapter.NetworkInterfaceType.ToString() == "Ethernet" && adapter.OperationalStatus == OperationalStatus.Up)
                    {
                        istherearesult = 1;
                        PhysicalAddress address = adapter.GetPhysicalAddress();
                        byte[] bytes = address.GetAddressBytes();
                        for (int i = 0; i < bytes.Length; i++)
                        {
                            // Display the physical address in hexadecimal.
                            Output += bytes[i].ToString("X2");
                            // Insert a hyphen after each byte, unless we are at the end of the 
                            // address.
                            if (i != bytes.Length)
                            {
                                Output += "-";
                            }
                        }
                        if (!All) break;
                        Output += "|";
                    };
                }
                else
                {

                    IPInterfaceProperties properties = adapter.GetIPProperties();

                    foreach (IPAddressInformation unicast in properties.UnicastAddresses)
                    {

                        if (IsLanIp(unicast.Address.ToString()))
                        {

                            istherearesult = 1;
                            PhysicalAddress address = adapter.GetPhysicalAddress();
                            byte[] bytes = address.GetAddressBytes();
                            for (int i = 0; i < bytes.Length; i++)
                            {
                                // Display the physical address in hexadecimal.
                                Output += bytes[i].ToString("X2");
                                // Insert a hyphen after each byte, unless we are at the end of the 
                                // address.
                                if (i != bytes.Length)
                                {
                                    Output += "-";
                                }
                            }
                            if (!All) break;
                            Output += "|";
                        }
                    
                    }

                }

            };


            if (istherearesult == 0)
            {
                return "NULL";
            }
            else
            {
                Output = Output.Remove(Output.Length - 1, 1);
                return Output;
            }

        }
        // Get Ip Address
        /// <summary>
        /// Gets the IP Address
        /// </summary>
        /// <returns>The IP Address</returns>
        public string GetIpAddress ()
        {
            string strHostName = Dns.GetHostName();
            IPHostEntry ipEntry = Dns.GetHostEntry(strHostName);
            IPAddress[] addr = ipEntry.AddressList;
            string IpAddress = ""; 
            IpAddress =  addr[0].ToString();
            return IpAddress;
        }
        // Get Ram Size
        /// <summary>
        /// Gets the RAM size
        /// </summary>
        /// <returns>The RAM size in MegaBytes</returns>
        public string GetRamSize()
        {
            ManagementObjectSearcher Search = new ManagementObjectSearcher("Select * From Win32_ComputerSystem");

            double Ram_Bytes = 0;
            foreach (ManagementObject Mobject in Search.Get())
            {
                Ram_Bytes = (Convert.ToDouble(Mobject["TotalPhysicalMemory"]));
                
            }
            return (Math.Round(Ram_Bytes / 1048576)).ToString();
        }
        // Get Cpu Speed
        /// <summary>
        /// Get CPU speed
        /// </summary>
        /// <returns>Cpu speed in GHz</returns>
        public string GetCpuSpeed()
        {
            ManagementObject Mo = new ManagementObject("Win32_Processor.DeviceID='CPU0'");
            double CpuSpeed = Math.Round(Convert.ToDouble((uint)(Mo["MaxClockSpeed"])) / 1024, 1);
            Mo.Dispose();
            return CpuSpeed.ToString();
        }
        #endregion
        #region Extra Functions (Doc)
        // Get Unix Timestamp
        /// <summary>
        /// Gets the current UNIX timestamp
        /// </summary>
        /// <returns>Current UNIX timestamp</returns>
        public string GetUnixTimeStamp()
        {
            TimeSpan ts = (DateTime.UtcNow - new DateTime(1970, 1, 1, 0, 0, 0));
            int unixTime = (int)Math.Round((double)ts.TotalSeconds);
            return unixTime.ToString();
        }
        // Set variables
        /// <summary>
        /// Sets the variables
        /// </summary>
        /// <param name="BUFUUF">Wherever it's BUF or UUF</param>
        /// <param name="Number">The BUF/UUF Number</param>
        /// <param name="Location">Location</param>
        /// <param name="SBB">Stationary/Laptop</param>
        /// <param name="SB">Smartboard</param>
        /// <param name="Organization">Organization</param>
        public void SetVariables(string Identifier, string Location, string SBB, string SB, string Organization)
        {
            // Set variables!
            _Identifier = Identifier;
            _Location = Location;
            _SBB = SBB;
            _SB = SB;
            _Organization = Organization;
        }
        #endregion
        #endregion
        #region Debug (Doc)
        /// <summary>
        /// Get a debug string that holds the computers information.
        /// </summary>
        /// <returns>String with computer information</returns>
        public string DebugToText()
        {
            string Output = "";
            // Output += ": "++"\r\n";
            Output += "Screen Height: "+GetScreenHeight()+"\r\n";
            Output += "Screen Width: "+GetScreenWidth()+"\r\n";
            Output += "Unix Timestamp: "+GetUnixTimeStamp()+"\r\n";
            Output += "Computer Name: "+GetComputerName()+"\r\n";
            Output += "Total Disk Space: "+GetTotalDiskSpace()+"\r\n";
            Output += "Computer Model: "+GetComputerModel()+"\r\n";
            Output += "Cpu Name: "+GetCpuName()+"\r\n";
            Output += "Computer Serial: "+GetComputerSerial()+"\r\n";
            Output += "Cpu Core Count: "+GetCpuCoreCount()+"\r\n";
            Output += "Mac Address: "+GetMacAddress()+"\r\n";
            Output += "Lan Mac Address: "+GetLanMacAddress()+"\r\n";
            Output += "Ip Address: "+GetIpAddress()+"\r\n";
            Output += "Ram Size: "+GetRamSize()+"\r\n";
            Output += "Data: " + GetUrlData() + "\r\n";
            return Output;
        }
        #endregion
        #region Send (Doc)
        // Get Url
        /// <summary>
        /// Gets the data URL
        /// </summary>
        /// <param name="Base64Encode">Wherever it should Base64 encode the result or not</param>
        /// <returns>URL string</returns>
        public string GetUrlData (bool Base64Encode = true)
        {
            string Data = "";
            // Data += "&=" + ;
            Data += "Method=Computerinfo";
            Data += "&C=1";
            Data += "&Organization=" + _Organization;
            Data += "&Mac=" + GetLanMacAddress(false);
            Data += "&LanMac=" + GetLanMacAddress(false);
            Data += "&LanCards=" + GetLanMacAddress(true);
            Data += "&Ip=" + GetIpAddress();
            Data += "&Name=" + GetComputerName();
            Data += "&Identifier=" + _Identifier;
            Data += "&Disk=" + GetTotalDiskSpace();
            Data += "&Ram=" + GetRamSize();
            Data += "&Location=" + _Location;
            Data += "&Model=" + GetComputerModel();
            Data += "&Serial=" + GetComputerSerial();
            Data += "&SBB=" + _SBB;
            Data += "&SB=" + _SB;
            Data += "&CpuCores=" + GetCpuCoreCount();
            Data += "&ScreenHeight=" + GetScreenHeight();
            Data += "&ScreenWidth=" + GetScreenWidth();
            Data += "&CpuName=" + GetCpuName();
            Data += "&CpuSpeed=" + GetCpuSpeed();
            if (Base64Encode) return Convert.ToBase64String(System.Text.UTF8Encoding.UTF8.GetBytes(Data)); else return Data;
        }
        // Send With Tokens, Return Success
        /// <summary>
        /// Sends the computers data to the server, using Tokens.
        /// </summary>
        /// <param name="Token1">The first Token</param>
        /// <param name="Token2">The second Token</param>
        /// <returns>True</returns>
        public bool SendWithTokens(string Token)
        {
            string Url = "";
            WebClient Http = new WebClient();
            string Response = Http.DownloadString(Url);
            if (Response != "200")
                if (Response == "403")
                    MessageBox.Show("Forkerte Tokens");
                else
                    MessageBox.Show("Fejl! Måske er der ikke noget net?");
            Debug.Write(Url);
            return true;
        }
        #endregion
    }
}
