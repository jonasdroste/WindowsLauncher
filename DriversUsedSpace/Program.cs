using System.Diagnostics;
using System.IO;
using System;
using System.Windows.Forms;

namespace DriversUsedSpace
{
    class Program
    {
        static void Main(string[] args)
        {
            Process.GetCurrentProcess().PriorityClass = ProcessPriorityClass.RealTime;

            string exePath = Directory.GetCurrentDirectory();

            File.WriteAllText(exePath + @"\Space_C.txt", Convert.ToString(GetHDDSize(@"C:\")));
            File.WriteAllText(exePath + @"\Space_D.txt", Convert.ToString(GetHDDSize(@"D:\")));



        }

        public static string GetHDDSize(string driveName)
        {
            foreach (DriveInfo drive in DriveInfo.GetDrives())
            {
                if (drive.IsReady && drive.Name == driveName)
                {
                    return drive.Name.Substring(0,2) + " " + 
                        (Convert.ToDouble((drive.TotalSize - drive.TotalFreeSpace)) / (1024 * 1024 * 1024)).ToString("N1") + " / " + 
                        (drive.TotalSize) / (1024 * 1024 * 1024) + " GB";
                    
                }
            }
            return "null";
        }
    }
}
