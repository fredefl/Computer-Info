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
using System.IO;


namespace ComputerInfo
{
    class ComputerInfoClass
    {   
        // Full Constructor
        /// <summary>
        /// Makes a full ComputerInfo Class
        /// </summary>
        /// <param name="BUFUUF">Wherever it's BUF or UUF</param>
        /// <param name="Number">The BUF/UUF Number</param>
        /// <param name="Location">Location</param>
        /// <param name="ComputerType">Computer Type</param>
        /// <param name="SB">Smartboard</param>
        /// <param name="Organization">Organization</param>
        public ComputerInfoClass (string Identifier, string Location, string ComputerType, string SB, string Organization)
        {
            // Constructor!
            _Identifier = Identifier;
            _Location = Location;
            _ComputerType = ComputerType;
            _SB = SB;
            _Organization = Organization;
        }
        
        // Empty Constructor
        /// <summary>
        /// Makes an empty ComputerInfo Class
        /// </summary>
        public ComputerInfoClass ()
        {
            // Constructor!
            _Identifier = "";
            _Location = "";
            _ComputerType = "";
            _SB = "";
            _Organization = "";
        }
        
        #region Vars
        public string _Identifier = "";
        public string _Location = "";
        public string _ComputerType = "";
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
        #region Objects
        #region Computer Info
        public class ComputerInfoComputerObject
        {
            public List<GraphicsCardObject> graphics_cards;
            public List<ProcessorObject> processors;
            public List<PrinterObject> printers;
            public MemoryObject memory;
            public ComputerModelObject model;
        }
        public class ComputerInfoObject 
        {
            public ComputerInfoComputerObject computer { get; set; }
        }
        #endregion
        #region GraphicsCard
        public class GraphicsCardManufacturerObject
        {
            public string detection_string { get; set; }
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
            public string detection_string { get; set; }
        }
        public class GraphicsCardObject
        {
            public GraphicsCardModelObject model { get; set; }
            public string driver_version { get; set; }
            public string driver_date { get; set; }
            public string ram_size { get; set; }
            public GraphicsCardScreenSizeObject screen_size { get; set; }
        }
        #endregion
        #region Processor
        public class ProcessorManufacturerObject
        {
            public string detection_string { get; set; }
        }
        public class ProcessorModelObject
        {
            public string cores { get; set; }
            public string threads { get; set; }
            public string clock_speed { get; set; }
            public string max_clock_speed { get; set; }
            public string detection_string { get; set; }
        }
        public class ProcessorObject
        {
            public ProcessorModelObject model { get; set; }
            public ProcessorManufacturerObject manufacturer { get; set; }
        }
        #endregion
        #region Printer
        public class PrinterObject
        {
            public string name { get; set; }
        }
        #endregion
        #region Computer Model
        public class ComputerModelManufacturerObject
        {
            public string detection_string { get; set; }
        }
        public class ComputerModelObject
        {
            public string detection_string { get; set; }
            public string type = "7";
            public ComputerModelManufacturerObject manufacturer { get; set; }
        }
        #endregion
        #region Memory
        public class MemoryObject
        {
            public string total_physical_memory;
            public List<MemorySlotObject> slots;
        }
        public class MemorySlotObject
        {
            public string device_identifier;
            public string capacity;
            public bool empty;
            public string serial;
            public string part_number;
            public string speed;
            public MemorySlotManifacturerObject manifacturer;
        }
        public class MemorySlotManifacturerObject {
            public string detection_string;
        }
        #endregion
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
        public MemoryObject GetMemory()
        {
            MemoryObject Memory = new MemoryObject();    
            List<MemorySlotObject> MemorySlots = new List<MemorySlotObject>();
            Memory.slots = MemorySlots;
            // Get used memory slots
            ManagementObjectSearcher Query = new ManagementObjectSearcher("SELECT * FROM Win32_MemoryDevice");
            ManagementObjectCollection Collection = Query.Get();
            foreach (ManagementObject MO in Collection)
            {
                MemorySlotObject MemorySlot = new MemorySlotObject();
                MemorySlot.device_identifier = MO["DeviceID"].ToString().Replace("Memory Device ", "");
                MemorySlot.capacity = Math.Round((Convert.ToDouble(MO["EndingAddress"].ToString()) - Convert.ToDouble(MO["StartingAddress"].ToString())) / 1024).ToString();
                if (Convert.ToDouble(MemorySlot.capacity) == 0)
                {
                    MemorySlot.empty = true;
                }
                else
                {
                    MemorySlot.empty = false;
                }
                MemorySlots.Add(MemorySlot);
            }
            Query = new ManagementObjectSearcher("SELECT * FROM Win32_PhysicalMemory");
            Collection = Query.Get();
            foreach (ManagementObject MO in Collection)
            {
                var Identifier = MO["Tag"].ToString().Replace("Physical Memory ", "");
                foreach (MemorySlotObject MemorySlot in MemorySlots)
                {
                    if (MemorySlot.device_identifier == Identifier)
                    {
                        try { MemorySlot.part_number = MO["PartNumber"].ToString(); }
                        catch { };
                        try { MemorySlot.serial = MO["Serial"].ToString(); }
                        catch { };
                        try { MemorySlot.speed = MO["Speed"].ToString(); }
                        catch { };
                        try
                        {
                            MemorySlot.manifacturer = new MemorySlotManifacturerObject();
                            MemorySlot.manifacturer.detection_string = MO["Manifacturer"].ToString();
                        }
                        catch { }
                    }
                }
            }
            // Get total physical memory
            Query = new ManagementObjectSearcher("Select * From Win32_ComputerSystem");
            Collection = Query.Get();
            double RamBytes = 0;
            foreach (ManagementObject MO in Collection)
            {
                RamBytes = (Convert.ToDouble(MO["TotalPhysicalMemory"]));

            }
            Memory.total_physical_memory = Math.Round(RamBytes / 1048576).ToString();
            return Memory;
        }
        public List<PrinterObject> GetPrinters()
        {
            List<PrinterObject> Printers = new List<PrinterObject>();
            ManagementObjectSearcher Query = new ManagementObjectSearcher("SELECT * FROM Win32_Printer");
            ManagementObjectCollection Collection = Query.Get();
            foreach (ManagementObject MO in Collection)
            {
                PrinterObject Printer = new PrinterObject();
                Printer.name = MO["Name"].ToString();

                Printers.Add(Printer);
            }
            return Printers;
        }
        public List<ProcessorObject> GetProcessors ()
        {
            List<ProcessorObject> Processors = new List<ProcessorObject>();
            ManagementObjectSearcher Query = new ManagementObjectSearcher("SELECT * FROM Win32_Processor");
            ManagementObjectCollection Collection = Query.Get();
            foreach (ManagementObject MO in Collection)
            {
                ProcessorObject Processor = new ProcessorObject();
                try
                {
                    Processor.manufacturer = new ProcessorManufacturerObject();
                    Processor.manufacturer.detection_string = MO["Manufacturer"].ToString();
                }
                catch { }

                try
                {
                    Processor.model = new ProcessorModelObject();
                    Processor.model.clock_speed = Math.Round(Convert.ToDouble(MO["CurrentClockSpeed"].ToString()) / 1000, 1).ToString();
                    Processor.model.cores = MO["NumberOfCores"].ToString();
                    Processor.model.threads = MO["NumberOfLogicalProcessors"].ToString();
                    Processor.model.max_clock_speed = Math.Round(Convert.ToDouble(MO["MaxClockSpeed"].ToString()) / 1000, 1).ToString();
                    Processor.model.detection_string = MO["Name"].ToString();
                }
                catch { }

                Processors.Add(Processor);
            }
            return Processors;
        }
        // Get Graphics Cards
        /// <summary>
        /// Gets a list of graphics cards
        /// </summary>
        /// <returns>A list of graphics cards</returns>
        public List<GraphicsCardObject> GetGraphicsCards()
        {
            List<GraphicsCardObject> GraphicsCards = new List<GraphicsCardObject>();
            ManagementObjectSearcher Query = new ManagementObjectSearcher("SELECT * FROM Win32_VideoController");
            ManagementObjectCollection Collection = Query.Get();
            foreach (ManagementObject MO in Collection)
            {
                GraphicsCardObject GraphicsCard = new GraphicsCardObject();
                try
                {
                    GraphicsCard.driver_version = MO["DriverVersion"].ToString();
                    GraphicsCard.driver_date = MO["DriverDate"].ToString();
                    GraphicsCard.ram_size = Math.Round(Convert.ToDouble(MO["AdapterRAM"]) / 1048576).ToString();
                }
                catch { }

                GraphicsCard.model = new GraphicsCardModelObject();
                try
                {
                    GraphicsCard.model.caption = MO["Caption"].ToString();
                    GraphicsCard.model.name = MO["Name"].ToString();
                    GraphicsCard.model.description = MO["Description"].ToString();
                    GraphicsCard.model.video_processor = MO["VideoProcessor"].ToString();
                }
                catch { }

                GraphicsCard.model.manufacturer = new GraphicsCardManufacturerObject();
                try
                {
                    GraphicsCard.model.manufacturer.detection_string = MO["Name"].ToString();
                }
                catch { }

                GraphicsCard.screen_size = new GraphicsCardScreenSizeObject();
                try
                {
                    GraphicsCard.screen_size.detection_string = MO["CurrentHorizontalResolution"].ToString() + "x" + MO["CurrentVerticalResolution"].ToString();
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
        public ComputerModelObject GetComputerModel()
        {
            ComputerModelObject ComputerModel = new ComputerModelObject();
            ManagementObjectSearcher Query = new ManagementObjectSearcher("SELECT * FROM Win32_ComputerSystem");
            ManagementObjectCollection Collection = Query.Get();
            foreach (ManagementObject MO in Collection)
            {
                try
                {
                    ComputerModel.detection_string = MO["Model"].ToString();
                }
                catch { }

                try
                {
                    ComputerModel.manufacturer = new ComputerModelManufacturerObject();
                    ComputerModel.manufacturer.detection_string = MO["Manufacturer"].ToString();
                }
                catch { }
            }
            return ComputerModel;
        }
        // Get Computer Serial
        /// <summary>
        /// Gets the computers serial number
        /// </summary>
        /// <returns>The computers serial number</returns>
        public string GetComputerSerialNumber()
        {
            string SerialNumber = "";
            ManagementObjectSearcher Query = new ManagementObjectSearcher("SELECT * FROM Win32_BIOS");
            ManagementObjectCollection Collection = Query.Get();
            foreach (ManagementObject MO in Collection)
            {
                SerialNumber = MO["SerialNumber"].ToString();
            }
            return SerialNumber;
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
        /// <param name="ComputerType">Computer Type</param>
        /// <param name="SB">Smartboard</param>
        /// <param name="Organization">Organization</param>
        public void SetVariables(string Identifier, string Location, string ComputerType, string SB, string Organization)
        {
            // Set variables!
            _Identifier = Identifier;
            _Location = Location;
            _ComputerType = ComputerType;
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
            Output += "Computer Serial: "+GetComputerSerialNumber()+"\r\n";
            Output += "Mac Address: "+GetMacAddress()+"\r\n";
            Output += "Lan Mac Address: "+GetLanMacAddress()+"\r\n";
            Output += "Ip Address: "+GetIpAddress()+"\r\n";
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
        /*
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
            Data += "&Serial=" + GetComputerSerialNumber();
            Data += "&SBB=" + _SBB;
            Data += "&SB=" + _SB;
            Data += "&ScreenHeight=" + GetScreenHeight();
            Data += "&ScreenWidth=" + GetScreenWidth();
            Data += "&CpuName=" + GetCpuName();
            Data += "&CpuSpeed=" + GetCpuSpeed();
            if (Base64Encode) return Convert.ToBase64String(System.Text.UTF8Encoding.UTF8.GetBytes(Data)); else return Data;
        }
         * */
        // Send With Tokens, Return Success
        /// <summary>
        /// Sends the computers data to the server, using Tokens.
        /// </summary>
        /// <param name="Token1">The first Token</param>
        /// <param name="Token2">The second Token</param>
        /// <returns>True</returns>
        public bool SendWithTokens(string Token)
        {
            HttpWebRequest Request = (HttpWebRequest)
            WebRequest.Create(Computer_Info.Properties.Settings.Default.BaseUrl + "client/computer?dev=true&foramt=json"); 
            Request.KeepAlive = false;
            Request.ProtocolVersion = HttpVersion.Version10;
            Request.Method = "POST";

            byte[] PostBytes = Encoding.UTF8.GetBytes(JsonConvert.SerializeObject(CreateCompleteComputerInfoObject()));

            Request.ContentType = "text/json";
            Request.ContentLength = PostBytes.Length;
            Stream RequestStream = Request.GetRequestStream();

            RequestStream.Write(PostBytes, 0, PostBytes.Length);
            RequestStream.Close();

            HttpWebResponse Response = (HttpWebResponse) Request.GetResponse();
            Stream ResponseStream = Response.GetResponseStream();
            string ResponseString;
            using (StreamReader Reader = new StreamReader(ResponseStream))
            {
                ResponseString = Reader.ReadToEnd();
            }
            MessageBox.Show(ResponseString);
            int StatusCode = Convert.ToInt32(Response.StatusCode);

            return true;
        }
        public ComputerInfoObject CreateCompleteComputerInfoObject()
        {
            ComputerInfoObject Object = CreateComputerInfoObject();
            Object.computer.model.type = (_ComputerType != "" ? _ComputerType : "7");
            return Object;
        }
        public ComputerInfoObject CreateComputerInfoObject ()
        {
            ComputerInfoObject BaseObject = new ComputerInfoObject();
            // Collect data from machine
            BaseObject.computer = new ComputerInfoComputerObject();
            BaseObject.computer.graphics_cards = GetGraphicsCards();
            BaseObject.computer.processors = GetProcessors();
            BaseObject.computer.model = GetComputerModel();
            BaseObject.computer.printers = GetPrinters();
            BaseObject.computer.memory = GetMemory();
            return BaseObject;
        }
        #endregion
    }
}
