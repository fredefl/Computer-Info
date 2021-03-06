﻿using System;
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
        /// <param name="Location">Location</param>
        /// <param name="ComputerType">Computer Type</param>
        /// <param name="SB">Smartboard</param>
        /// <param name="OrganizationId">The ID of the organization</param>
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
        public class ComputerInfoObject
        {
            public string identifier;
            public string location;
            public int organization;
            public string serial;
            public int execution_time;
            public List<GraphicsCardObject> graphics_cards;
            public List<ProcessorObject> processors;
            public List<PrinterObject> printers;
            public MemoryObject memory;
            public ComputerModelObject model;
            public OperatingSystemObject operating_system;
            public List<LogicalDriveObject> logical_drives;
            public List<PhysicalDriveObject> physical_drives;
            public List<NetworkCardObject> network_cards;
            public ScreenSizeObject screen_size;
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
            public string detection_string;
            public GraphicsCardMemoryTypeObject memory_type = new GraphicsCardMemoryTypeObject();
        }
        public class GraphicsCardScreenSizeObject
        {
            public string detection_string;
        }

        public class GraphicsCardMemoryTypeObject
        {
            public string detection_string;
        }
        public class GraphicsCardVideoArchitectureObject
        {
            public string detection_string;
        }
        public class GraphicsCardObject
        {
            public GraphicsCardModelObject model = new GraphicsCardModelObject();
            public string driver_version;
            public string driver_date;
            public string ram_size;
            public string device_identifier;
            public GraphicsCardVideoArchitectureObject video_architecture = new GraphicsCardVideoArchitectureObject();
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
            public PrinterLocationObject location = new PrinterLocationObject();
            public PrinterModelObject model = new PrinterModelObject();
            public string local;
            public List<PrinterCapabilitiesObject> capabilities = new List<PrinterCapabilitiesObject>();
        }

        public class PrinterCapabilitiesObject
        {
            public string detection_string;
        }

        public class PrinterModelObject
        {
            public string detection_string;

        }

        public class PrinterLocationObject
        {
            public string name;
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
            public MemorySlotManufacturerObject manufacturer = new MemorySlotManufacturerObject();
        }
        public class MemorySlotManufacturerObject {
            public string detection_string;
        }
        #endregion
        #region Operating System
        public class OperatingSystemEditionObject
        {
            public string detection_string;
            public OperatingSystemManufacturerObject manufacturer = new OperatingSystemManufacturerObject();
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
        #region Drives
        public class LogicalDriveObject
        {
            public string device_identifier;
            public string free_space;
            public string disk_size;
            public string volume_name;
            public string volume_serial_number;
            public string file_system;
            public string name;
            public DriveTypeObject drive_type = new DriveTypeObject();
        }

        public class DriveTypeObject
        {
            public string detection_string;
        }

        public class PhysicalDriveModelObject
        {
            public string detection_string;
        }

        public class PartitionObject
        {
            public string device_identifier;
            public string disk_size;
            public bool boot_partition;
            public string index;
            public string starting_index;
        }

        public class PhysicalDriveObject
        {
            public PhysicalDriveModelObject model = new PhysicalDriveModelObject();
            public string device_identifier;
            public string disk_size;
            public string serial_number;
            public List<PartitionObject> partitions;
        }
        #endregion
        #region Screen Size
        public class ScreenSizeObject
        {
            public int heigth;
            public int width;
            public string detection_string;
        }
        #endregion
        #region Network Cards
        public class NetworkCardObject
        {
            public string mac_address;
            public NetworkCardAdapterTypeObject adapter_type = new NetworkCardAdapterTypeObject();
            public List<string> ip_addresses = new List<string>();
            public string guid;
            public NetworkCardModelObject model = new NetworkCardModelObject();
            public int device_identifier;
            public long max_speed;
        }
        public class NetworkCardAdapterTypeObject
        {
            public string detection_string;
        }
        public class NetworkCardModelObject
        {
            public string detection_string;
        }
        #endregion
        #endregion
        #region Functions (Doc)
        #region Helper Functions (Doc)
        public static void Try(Action a)
        {
            try
            {
                a();
            }
            catch { }
        }
        public string FormatMacAddress (PhysicalAddress Input) {
            string Output = "";
            byte[] bytes = Input.GetAddressBytes();
            for (int i = 0; i < bytes.Length; i++)
            {
                // Display the physical address in hexadecimal.
                Output += bytes[i].ToString("X2");
                // Insert a hyphen after each byte, unless we are at the end of the 
                // address.
                if (i != bytes.Length)
                {
                    Output += ":";
                }
            }
            return Output.Trim(':');
        }
        /// <summary>
        /// Converts a System.DateTime value to a UNIX Timestamp
        /// </summary>
        /// <param name="value">Date to convert</param>
        /// <returns></returns>
        private string ConvertToTimestamp(DateTime value)
        {
            // Create Timespan by subtracting the value provided from
            // The Unix Epoch
            TimeSpan span = (value - new DateTime(1970, 1, 1, 0, 0, 0, 0).ToLocalTime());

            // Return the total seconds (which is a UNIX timestamp)
            return span.TotalSeconds.ToString();
        }

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
        public List<NetworkCardObject> GetNetworkCards()
        {
            List<NetworkCardObject> NetworkCards = new List<NetworkCardObject>();
            int DeviceIdentifier = 0;
            foreach (NetworkInterface nic in NetworkInterface.GetAllNetworkInterfaces())
            {
                if (nic.OperationalStatus == OperationalStatus.Up && nic.NetworkInterfaceType.ToString() != "Loopback")
                {
                    NetworkCardObject NetworkCard = new NetworkCardObject();
                    try
                    {
                        NetworkCard.model.detection_string = nic.Description.ToString();
                    }
                    catch { }
                    NetworkCard.guid = nic.Id;
                    NetworkCard.device_identifier = DeviceIdentifier;
                    NetworkCard.mac_address = FormatMacAddress(nic.GetPhysicalAddress());
                    NetworkCard.adapter_type.detection_string = nic.NetworkInterfaceType.ToString();
                    NetworkCard.max_speed = nic.Speed / 1024 / 1024;
                    foreach (UnicastIPAddressInformation ip_address in nic.GetIPProperties().UnicastAddresses)
                    {
                        NetworkCard.ip_addresses.Add(ip_address.Address.ToString());
                    }
                    NetworkCards.Add(NetworkCard);
                }
                DeviceIdentifier++;
            }
            return NetworkCards;
        }
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
                Try(() =>
                    OperatingSystem.core.manufacturer.detection_string = MO["Manufacturer"].ToString());
                Try(() =>
                    OperatingSystem.core.detection_string = OSVersionInfo.Name);
                Try(() =>
                    OperatingSystem.edition.detection_string = OSVersionInfo.Edition);
                Try(() =>
                    OperatingSystem.edition.manufacturer.detection_string = MO["Manufacturer"].ToString());
                Try(() =>
                    OperatingSystem.architecture = OSVersionInfo.OSBits);
                Try(() =>
                    OperatingSystem.computer_name = MO["CSName"].ToString());
                Try(() =>
                    OperatingSystem.service_pack = MO["ServicePackMajorVersion"].ToString());
                Try(() =>
                    OperatingSystem.system_drive = MO["SystemDrive"].ToString());
                Try(() =>
                    OperatingSystem.version = MO["Version"].ToString());

                try {
                    TimeSpan ts = (ManagementDateTimeConverter.ToDateTime(MO["InstallDate"].ToString()).ToUniversalTime() - new DateTime(1970, 1, 1, 0, 0, 0));
                    int unixTime = (int)Math.Round((double)ts.TotalSeconds);
                    OperatingSystem.install_date = unixTime.ToString();
                } catch { }

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
                
                Try(() =>
                    MemorySlot.device_identifier = MO["DeviceID"].ToString().Replace("Memory Device ", ""));
                Try(() =>
                    MemorySlot.capacity = Math.Round((Convert.ToDouble(MO["EndingAddress"].ToString()) - Convert.ToDouble(MO["StartingAddress"].ToString())) / 1024).ToString());
                
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
                try
                {
                    var Identifier = MO["Tag"].ToString().Replace("Physical Memory ", "");
                    foreach (MemorySlotObject MemorySlot in MemorySlots)
                    {
                        if (MemorySlot.device_identifier == Identifier)
                        {
                            Try(() =>
                                MemorySlot.part_number = MO["PartNumber"].ToString().Trim());
                            Try(() =>
                                MemorySlot.serial = MO["Serial"].ToString());
                            Try(() =>
                                MemorySlot.speed = MO["Speed"].ToString());
                            Try(() =>
                                MemorySlot.manufacturer.detection_string = MO["Manufacturer"].ToString());
                        }
                    }
                }
                catch { }
            }
            // Get total physical memory
            Query = new ManagementObjectSearcher("Select * From Win32_ComputerSystem");
            Collection = Query.Get();
            double RamBytes = 0;
            foreach (ManagementObject MO in Collection)
            {
                Try(() =>
                    RamBytes = (Convert.ToDouble(MO["TotalPhysicalMemory"])));
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
                    
                Try(() =>
                    Printer.name = MO["Name"].ToString());
                Try(() =>
                    Printer.identifier = MO["Name"].ToString());
                Try(() =>
                    Printer.model.detection_string = MO["DriverName"].ToString());
                Try(() =>
                    Printer.location.name = MO["Location"].ToString());
                Try(() =>
                    Printer.local = MO["Local"].ToString());
                try
                {
                    UInt16[] Capabilities = (UInt16[]) MO["Capabilities"];

                    foreach (UInt16 Capability in Capabilities)
                    {
                        PrinterCapabilitiesObject PrinterCapability = new PrinterCapabilitiesObject();
                        PrinterCapability.detection_string = Capability.ToString();
                        Printer.capabilities.Add(PrinterCapability);
                    }
                }
                catch { }

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
                
                Try(() =>
                    Processor.device_identifier = MO["DeviceID"].ToString());
                Try(() =>
                    Processor.manufacturer.detection_string = MO["Manufacturer"].ToString());
                Try(() =>
                    Processor.model.clock_speed = Math.Round(Convert.ToDouble(MO["CurrentClockSpeed"].ToString()) / 1000, 1).ToString());
                Try(() =>
                    Processor.model.cores = MO["NumberOfCores"].ToString());
                Try(() =>
                    Processor.model.threads = MO["NumberOfLogicalProcessors"].ToString());
                Try(() =>
                    Processor.model.max_clock_speed = Math.Round(Convert.ToDouble(MO["MaxClockSpeed"].ToString()) / 1000, 1).ToString());
                Try(() =>
                    Processor.model.detection_string = MO["Name"].ToString());
                Try(() =>
                    Processor.model.data_width = MO["DataWidth"].ToString());
                Try(() =>
                    Processor.family.architecture.detection_string = MO["Architecture"].ToString());
                Try(() =>
                    Processor.family.detection_string = MO["Family"].ToString());

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
                // Create the card object
                GraphicsCardObject GraphicsCard = new GraphicsCardObject();

                // Collect information, one by one
                Try(() =>
                    GraphicsCard.driver_version = MO["DriverVersion"].ToString());
                Try(() =>
                    GraphicsCard.device_identifier = MO["DeviceID"].ToString());
                Try(() =>
                    GraphicsCard.driver_date = this.ConvertToTimestamp(Convert.ToDateTime(MO["DriverDate"].ToString())));
                Try(() =>
                    GraphicsCard.ram_size = Math.Round(Convert.ToDouble(MO["AdapterRAM"]) / 1048576).ToString());
                Try(() =>
                     GraphicsCard.video_architecture.detection_string = MO["VideoArchitecture"].ToString());
                Try(() =>
                     GraphicsCard.driver_date = this.ConvertToTimestamp(Convert.ToDateTime(MO["DriverDate"].ToString())));
                Try(() =>
                    GraphicsCard.model.caption = MO["Caption"].ToString());
                Try(() =>
                    GraphicsCard.model.name = MO["Name"].ToString());
                Try(() =>
                    GraphicsCard.model.description = MO["Description"].ToString());
                Try(() =>
                    GraphicsCard.model.video_processor = MO["VideoProcessor"].ToString());
                Try(() =>
                    GraphicsCard.model.detection_string = MO["Name"].ToString());
                Try(() =>
                    GraphicsCard.model.memory_type.detection_string = MO["VideoMemoryType"].ToString());
                Try(() =>
                    GraphicsCard.model.manufacturer.detection_string = MO["Name"].ToString());
                Try(() =>
                    GraphicsCard.screen_size.detection_string = MO["CurrentHorizontalResolution"].ToString() + "x" + MO["CurrentVerticalResolution"].ToString());

                // Add the card to the array
                GraphicsCards.Add(GraphicsCard);
            }
            return GraphicsCards;
        }
        public List<PhysicalDriveObject> GetPhysicalDrives()
        {
            List<PhysicalDriveObject> PhysicalDrives = new List<PhysicalDriveObject>();
            ManagementObjectSearcher Query = new ManagementObjectSearcher("SELECT * FROM Win32_DiskDrive");
            ManagementObjectCollection Collection = Query.Get();
            foreach (ManagementObject MO in Collection)
            {
                // Create the drive object
                PhysicalDriveObject PhysicalDrive = new PhysicalDriveObject();
                
                Try(() =>
                    PhysicalDrive.model.detection_string = MO["Model"].ToString());
                Try(() =>
                    PhysicalDrive.disk_size = (Convert.ToInt64((MO["Size"].ToString())) / 1073741824).ToString());
                Try(() =>
                    PhysicalDrive.device_identifier = MO["DeviceID"].ToString());
                Try(() =>
                    PhysicalDrive.serial_number = MO["SerialNumber"].ToString());

                // Add the drive to the array
                PhysicalDrives.Add(PhysicalDrive);
            }
            return PhysicalDrives;
        }

        public List<LogicalDriveObject> GetLogicalDrives() 
        {
            List<LogicalDriveObject> LogicalDrives = new List<LogicalDriveObject>();
            ManagementObjectSearcher Query = new ManagementObjectSearcher("SELECT * FROM Win32_LogicalDisk");
            ManagementObjectCollection Collection = Query.Get();
            foreach (ManagementObject MO in Collection)
            {
                // Create the drive object
                LogicalDriveObject LogicalDrive = new LogicalDriveObject();
                
                Try(() =>
                    LogicalDrive.device_identifier = MO["DeviceID"].ToString());
                Try(() =>
                    LogicalDrive.drive_type.detection_string = MO["DriveType"].ToString());
                Try(() =>
                    LogicalDrive.free_space = (Convert.ToInt64((MO["FreeSpace"].ToString())) / 1073741824).ToString());
                Try(() =>
                    LogicalDrive.disk_size = (Convert.ToInt64((MO["Size"].ToString())) / 1073741824).ToString());
                Try(() =>
                    LogicalDrive.volume_name = MO["VolumeName"].ToString());
                Try(() =>
                    LogicalDrive.volume_serial_number = MO["VolumeSerialNumber"].ToString());
                Try(() =>
                    LogicalDrive.file_system = MO["FileSystem"].ToString());
                Try(() =>
                    LogicalDrive.name = MO["Name"].ToString());

                // Add the drive to the array
                LogicalDrives.Add(LogicalDrive);
            }
            return LogicalDrives;
        }

        public ScreenSizeObject GetScreenSize()
        {
            ScreenSizeObject ScreenSize = new ScreenSizeObject();

            Try(() => 
                ScreenSize.heigth = Screen.PrimaryScreen.Bounds.Height);
            Try(() => 
                ScreenSize.width = Screen.PrimaryScreen.Bounds.Width);
            Try(() => 
                ScreenSize.detection_string = ScreenSize.width + "x" + ScreenSize.heigth.ToString());
            
            return ScreenSize;
        }
        // Get Computer Name
        /// <summary>
        /// Gets the computers name
        /// </summary>
        /// <returns>The computers name</returns>
        public string GetComputerName()
        {
            try
            {
                return System.Environment.MachineName;
            }
            catch { return ""; }
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
                Try(() =>
                    ComputerModel.detection_string = MO["Model"].ToString());
                Try(() =>
                    ComputerModel.manufacturer.detection_string = MO["Manufacturer"].ToString());
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
                Try(() =>
                    SerialNumber = MO["SerialNumber"].ToString());
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
            try
            {
                foreach (NetworkInterface nic in NetworkInterface.GetAllNetworkInterfaces())
                {
                    if (nic.OperationalStatus == OperationalStatus.Up)
                    {
                        macAddresses += nic.GetPhysicalAddress().ToString();
                        break;
                    }
                }
            }
            catch { }
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
            try
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
            catch { return ""; }

        }
        // Get Ip Address
        /// <summary>
        /// Gets the IP Address
        /// </summary>
        /// <returns>The IP Address</returns>
        public string GetIpAddress ()
        {
            try
            {
                string strHostName = Dns.GetHostName();
                IPHostEntry ipEntry = Dns.GetHostEntry(strHostName);
                IPAddress[] addr = ipEntry.AddressList;
                string IpAddress = "";
                IpAddress = addr[0].ToString();
                return IpAddress;
            }
            catch { return ""; }
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
        #region Send (Doc)
        /// <summary>
        /// Sends the computer with tokens
        /// </summary>
        /// <param name="Token">The token that will be used to authenticate</param>
        /// <returns>Success, true og false</returns>
        public bool SendWithTokens(string Token)
        {
            string Url = Computer_Info.Properties.Settings.Default.BaseUrl + "/computer?format=json&token=" + Token;
            HttpWebRequest Request = (HttpWebRequest)
            WebRequest.Create(Url);
            File.WriteAllText("Request.url.log", Url);
            Request.KeepAlive = false;
            Request.ProtocolVersion = HttpVersion.Version10;
            Request.Method = "POST";
            Request.UserAgent = "CI/Windows";
            byte[] PostBytes = Encoding.UTF8.GetBytes(JsonConvert.SerializeObject(CreateCompleteComputerInfoObject()));
            File.WriteAllBytes("Request.log", PostBytes);

            Request.ContentType = "application/json";
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
            catch (WebException e)
            {
                MessageBox.Show(e.ToString());
                return false;
            }
        }

        public ComputerInfoObject CreateCompleteComputerInfoObject()
        {
            var ExecutionTimeMeasurer = new Stopwatch();
            ExecutionTimeMeasurer.Start();
            
            ComputerInfoObject Object = CreateComputerInfoObject();
            Object.model.type = (_ComputerType != "" ? _ComputerType : "7");
            Object.organization = _OrganizationId;
            Object.identifier = _Identifier;
            Object.location = _Location;
            Object.serial = GetComputerSerialNumber();

            ExecutionTimeMeasurer.Stop();
            Object.execution_time = ExecutionTimeMeasurer.Elapsed.Milliseconds;
            return Object;
        }

        public ComputerInfoObject CreateComputerInfoObject ()
        {
            ComputerInfoObject BaseObject = new ComputerInfoObject();
            // Collect data from machine
            BaseObject = new ComputerInfoObject();
            BaseObject.graphics_cards = GetGraphicsCards();
            BaseObject.processors = GetProcessors();
            BaseObject.model = GetComputerModel();
            BaseObject.printers = GetPrinters();
            BaseObject.memory = GetMemory();
            BaseObject.operating_system = GetOperatingSystem();
            BaseObject.network_cards = GetNetworkCards();
            BaseObject.screen_size = GetScreenSize();
            BaseObject.logical_drives = GetLogicalDrives();
            BaseObject.physical_drives = GetPhysicalDrives();
            return BaseObject;
        }
        #endregion
    }
}
