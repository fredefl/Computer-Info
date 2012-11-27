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
using JCS;

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
        public ComputerInfoClass (string Identifier, string Location, string ComputerType, string SB, int OrganizationId)
        {
            // Constructor!
            _Identifier = Identifier;
            _Location = Location;
            _ComputerType = ComputerType;
            _SB = SB;
            _OrganizationId = OrganizationId;
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
            _OrganizationId = 0;
        }
        
        #region Vars
        public string _Identifier = "";
        public string _Location = "";
        public string _ComputerType = "";
        public string _SB = "";
        public int _OrganizationId = 0;
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
            public string identifier;
            public string location;
            public int organization;
            public int execution_time;
            public List<GraphicsCardObject> graphics_cards;
            public List<ProcessorObject> processors;
            public List<PrinterObject> printers;
            public MemoryObject memory;
            public ComputerModelObject model;
            public OperatingSystemObject operating_system;
        }
        public class ComputerInfoObject 
        {
            public ComputerInfoComputerObject computer;
        }
        #endregion
        #region GraphicsCard
        public class GraphicsCardManufacturerObject
        {
            public string detection_string;
        }
        public class GraphicsCardModelObject
        {
            public string caption;
            public GraphicsCardManufacturerObject manufacturer = new GraphicsCardManufacturerObject();
            public string name;
            public string description;
            public string video_processor;
        }
        public class GraphicsCardScreenSizeObject
        {
            public string detection_string;
        }
        public class GraphicsCardObject
        {
            public GraphicsCardModelObject model = new GraphicsCardModelObject();
            public string driver_version;
            public string driver_date;
            public string ram_size;
            public GraphicsCardScreenSizeObject screen_size = new GraphicsCardScreenSizeObject();
        }
        #endregion
        #region Processor
        public class ProcessorManufacturerObject
        {
            public string detection_string;
        }
        public class ProcessorModelObject
        {
            public string cores;
            public string threads;
            public string clock_speed;
            public string max_clock_speed;
            public string detection_string;
            public string data_width;
        }
        public class ProcessorFamilyObject
        {
            public string detection_string;
            public ProcessorFamilyArchitectureObject architecture = new ProcessorFamilyArchitectureObject();
        }
        public class ProcessorFamilyArchitectureObject
        {
            public string detection_string;
        }
        public class ProcessorObject
        {
            public string device_identifier;
            public ProcessorModelObject model = new ProcessorModelObject();
            public ProcessorFamilyObject family = new ProcessorFamilyObject();
            public ProcessorManufacturerObject manufacturer = new ProcessorManufacturerObject();
        }
        #endregion
        #region Printer
        public class PrinterObject
        {
            public string name;
            public string identifier;
        }
        #endregion
        #region Computer Model
        public class ComputerModelManufacturerObject
        {
            public string detection_string;
        }
        public class ComputerModelObject
        {
            public string detection_string;
            public string type = "7";
            public ComputerModelManufacturerObject manufacturer = new ComputerModelManufacturerObject();
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
            public MemorySlotManifacturerObject manifacturer = new MemorySlotManifacturerObject();
        }
        public class MemorySlotManifacturerObject {
            public string detection_string;
        }
        #endregion
        #region Operating System
        public class OperatingSystemEditionObject
        {
            public string detection_string;
        }
        public class OperatingSystemManufacturerObject
        {
            public string detection_string;
        }
        public class OperatingSystemCoreObject
        {
            public string detection_string;
            public OperatingSystemManufacturerObject manufacturer = new OperatingSystemManufacturerObject();
        }
        public class OperatingSystemObject
        {
            public OperatingSystemCoreObject core = new OperatingSystemCoreObject();
            public OperatingSystemEditionObject edition = new OperatingSystemEditionObject();
            public string architecture = "32-bit";
            public string computer_name;
            public string install_date;
            public string service_pack;
            public string system_drive;
            public string version;
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
        // Get operating system
        /// <summary>
        /// Gets basic operating system information
        /// </summary>
        /// <returns>An OperatingSystemObject</returns>
        public OperatingSystemObject GetOperatingSystem ()
        {
            OperatingSystemObject OperatingSystem = new OperatingSystemObject();
            ManagementObjectSearcher Query = new ManagementObjectSearcher("SELECT * FROM Win32_OperatingSystem");
            ManagementObjectCollection Collection = Query.Get();
            foreach (ManagementObject MO in Collection)
            {
                //OperatingSystem.core.detection_string = GetProductInfo();
                OperatingSystem.core.manufacturer.detection_string = MO["Manufacturer"].ToString();
                OperatingSystem.core.detection_string = OSVersionInfo.Name;
                OperatingSystem.edition.detection_string = OSVersionInfo.Edition;
                OperatingSystem.architecture = OSVersionInfo.OSBits;
                OperatingSystem.computer_name = MO["CSName"].ToString();
                TimeSpan ts = (ManagementDateTimeConverter.ToDateTime(MO["InstallDate"].ToString()).ToUniversalTime() - new DateTime(1970, 1, 1, 0, 0, 0));
                int unixTime = (int)Math.Round((double)ts.TotalSeconds);
                OperatingSystem.install_date = unixTime.ToString();
                OperatingSystem.service_pack = MO["ServicePackMajorVersion"].ToString();
                OperatingSystem.system_drive = MO["SystemDrive"].ToString();
                OperatingSystem.version = MO["Version"].ToString();
            }
            return OperatingSystem;
        }
        // Get memory
        /// <summary>
        /// Gets general memory information such as total memory and all ram slots
        /// </summary>
        /// <returns>A MemoryObject</returns>
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
                        try { MemorySlot.manifacturer.detection_string = MO["Manifacturer"].ToString(); }
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
        // Get printers
        /// <summary>
        /// Gets a list of printers
        /// </summary>
        /// <returns>A list of PrinterObjects</returns>
        public List<PrinterObject> GetPrinters()
        {
            List<PrinterObject> Printers = new List<PrinterObject>();
            ManagementObjectSearcher Query = new ManagementObjectSearcher("SELECT * FROM Win32_Printer");
            ManagementObjectCollection Collection = Query.Get();
            foreach (ManagementObject MO in Collection)
            {
                PrinterObject Printer = new PrinterObject();
                Printer.name = MO["Name"].ToString();
                Printer.identifier = MO["Name"].ToString();

                Printers.Add(Printer);
            }
            return Printers;
        }
        // Get processors
        /// <summary>
        /// Gets a list of processors
        /// </summary>
        /// <returns>A list of ProcessorObjects</returns>
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
                    Processor.device_identifier = MO["DeviceID"].ToString();
                }
                catch { }

                try 
                {
                    Processor.manufacturer.detection_string = MO["Manufacturer"].ToString();
                }
                catch { }

                try
                {
                    
                    Processor.model.clock_speed = Math.Round(Convert.ToDouble(MO["CurrentClockSpeed"].ToString()) / 1000, 1).ToString();
                    Processor.model.cores = MO["NumberOfCores"].ToString();
                    Processor.model.threads = MO["NumberOfLogicalProcessors"].ToString();
                    Processor.model.max_clock_speed = Math.Round(Convert.ToDouble(MO["MaxClockSpeed"].ToString()) / 1000, 1).ToString();
                    Processor.model.detection_string = MO["Name"].ToString();
                    Processor.model.data_width = MO["DataWidth"].ToString();
                }
                catch { }

                try
                {
                    Processor.family.architecture.detection_string = MO["Architecture"].ToString();
                    Processor.family.detection_string = MO["Family"].ToString();
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
        /// <returns>A list of GraphicsCardObjects</returns>
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

                try
                {
                    GraphicsCard.model.caption = MO["Caption"].ToString();
                    GraphicsCard.model.name = MO["Name"].ToString();
                    GraphicsCard.model.description = MO["Description"].ToString();
                    GraphicsCard.model.video_processor = MO["VideoProcessor"].ToString();
                }
                catch { }

                try
                {
                    GraphicsCard.model.manufacturer.detection_string = MO["Name"].ToString();
                }
                catch { }

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
        public void SetVariables(string Identifier, string Location, string ComputerType, string SB, int OrganizationId)
        {
            // Set variables!
            _Identifier = Identifier;
            _Location = Location;
            _ComputerType = ComputerType;
            _SB = SB;
            _OrganizationId = OrganizationId;
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
        /// <summary>
        /// Sends the computer with tokens
        /// </summary>
        /// <param name="Token">The token that will be used to authenticate</param>
        /// <returns>Success, true og false</returns>
        public bool SendWithTokens(string Token)
        {
            HttpWebRequest Request = (HttpWebRequest)
            WebRequest.Create(Computer_Info.Properties.Settings.Default.BaseUrl + "/client/computer?format=json&token=" + Token); 
            Request.KeepAlive = false;
            Request.ProtocolVersion = HttpVersion.Version10;
            Request.Method = "POST";
            byte[] PostBytes = Encoding.UTF8.GetBytes(JsonConvert.SerializeObject(CreateCompleteComputerInfoObject()));
            File.WriteAllBytes("Request.log", PostBytes);

            Request.ContentType = "text/json";
            Request.ContentLength = PostBytes.Length;
            Stream RequestStream = Request.GetRequestStream();

            RequestStream.Write(PostBytes, 0, PostBytes.Length);
            RequestStream.Close();

            try
            {
                HttpWebResponse Response = (HttpWebResponse)Request.GetResponse();
                Stream ResponseStream = Response.GetResponseStream();
                string ResponseString;
                using (StreamReader Reader = new StreamReader(ResponseStream))
                {
                    ResponseString = Reader.ReadToEnd();
                }
                File.WriteAllText("Response.log", ResponseString);
                int StatusCode = Convert.ToInt32(Response.StatusCode);

                return true;
            }
            catch (Exception)
            {
                HttpWebResponse Response = (HttpWebResponse)Request.GetResponse();
                MessageBox.Show("Could not connect to server, please try again");
                return false;
            }
        }

        public ComputerInfoObject CreateCompleteComputerInfoObject()
        {
            var ExecutionTimeMeasurer = new Stopwatch();
            ExecutionTimeMeasurer.Start();
            
            ComputerInfoObject Object = CreateComputerInfoObject();
            Object.computer.model.type = (_ComputerType != "" ? _ComputerType : "7");
            Object.computer.organization = _OrganizationId;
            Object.computer.identifier = _Identifier;
            Object.computer.location = _Location;

            ExecutionTimeMeasurer.Stop();
            Object.computer.execution_time = ExecutionTimeMeasurer.Elapsed.Milliseconds;
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
            BaseObject.computer.operating_system = GetOperatingSystem();
            return BaseObject;
        }
        #endregion
    }
}
