using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Diagnostics;
using System.IO;

namespace Computer_Info_Updater
{
    class Program
    {
        static bool FindAndKillProcess(string name)
        {
	        foreach (Process clsProcess in Process.GetProcesses()) {
		        if (clsProcess.ProcessName.StartsWith(name))
		        {
			        clsProcess.Kill();
			        return true;
		        }
	        }
	        return false;
        }

        static void Main(string[] args)
        {
            FindAndKillProcess("ComputerInfo");
            File.Delete("ComputerInfo.exe");
            WebClient Http = new WebClient();
            Http.DownloadFile("http://illution.dk/download/ComputerInfo.exe","ComputerInfo.exe");
            Process UpdaterProcess = new Process();
            UpdaterProcess.StartInfo.FileName = "ComputerInfo.exe";
            UpdaterProcess.Start();
        }
    }
}
