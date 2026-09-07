using System;
using System.Collections.Generic;
using System.Text;
using System.Management;
using System.IO;

namespace Laptop_checker
{
    public class DeviceService
    {
        public string GetCPU()
        {
            using (ManagementObjectSearcher searcher =
                   new ManagementObjectSearcher(
                       "SELECT Name FROM Win32_Processor"))
            {
                foreach (ManagementObject cpu in searcher.Get())
                {
                    return cpu["Name"]?.ToString() ?? "Unknown";
                }
            }

            return "Unknown";
        }

        public string GetRAM()
        {
            using (ManagementObjectSearcher searcher =
                   new ManagementObjectSearcher(
                       "SELECT TotalPhysicalMemory FROM Win32_ComputerSystem"))
            {
                foreach (ManagementObject computer in searcher.Get())
                {
                    if (computer["TotalPhysicalMemory"] != null)
                    {
                        double bytes =
                            Convert.ToDouble(computer["TotalPhysicalMemory"]);

                        double gigabytes =
                            bytes / 1024 / 1024 / 1024;

                        return $"{Math.Round(gigabytes, 0)} GB";
                    }
                }
            }

            return "Unknown";
        }

        public string GetGPU()
        {
            using (ManagementObjectSearcher searcher =
                   new ManagementObjectSearcher(
                       "SELECT Name FROM Win32_VideoController"))
            {
                List<string> gpus = new List<string>();

                foreach (ManagementObject gpu in searcher.Get())
                {
                    if (gpu["Name"] != null)
                    {
                        gpus.Add(gpu["Name"].ToString());
                    }
                }

                return string.Join(", ", gpus);
            }
        }

        public string GetStorage()
        {
            using (ManagementObjectSearcher searcher =
                   new ManagementObjectSearcher(
                       "SELECT Model, Size FROM Win32_DiskDrive"))
            {
                List<string> drives = new List<string>();

                foreach (ManagementObject drive in searcher.Get())
                {
                    string model =
                        drive["Model"]?.ToString() ?? "Unknown";

                    if (drive["Size"] != null)
                    {
                        double bytes =
                            Convert.ToDouble(drive["Size"]);

                        double gigabytes =
                            bytes / 1024 / 1024 / 1024;

                        drives.Add(
                            $"{model} ({Math.Round(gigabytes, 0)} GB)"
                        );
                    }
                }

                return string.Join("\n", drives);
            }
        }

        public string GetWindowsVersion()
        {
            using (ManagementObjectSearcher searcher =
                   new ManagementObjectSearcher(
                       "SELECT Caption, Version, BuildNumber FROM Win32_OperatingSystem"))
            {
                foreach (ManagementObject os in searcher.Get())
                {
                    string caption =
                        os["Caption"]?.ToString() ?? "Windows";

                    string version =
                        os["Version"]?.ToString() ?? "";

                    string build =
                        os["BuildNumber"]?.ToString() ?? "";

                    return $"{caption} - Version {version} - Build {build}";
                }
            }

            return "Unknown";
        }

        public string GetDeviceId()
        {
            string folderPath = Path.Combine(
                Environment.GetFolderPath(
                    Environment.SpecialFolder.ApplicationData),
                "LaptopChecker"
            );

            string filePath = Path.Combine(
                folderPath,
                "device.id"
            );

            if (!Directory.Exists(folderPath))
            {
                Directory.CreateDirectory(folderPath);
            }

            if (File.Exists(filePath))
            {
                return File.ReadAllText(filePath);
            }

            string deviceId = Guid.NewGuid().ToString();

            File.WriteAllText(filePath, deviceId);

            return deviceId;
        }

        public string GetManufacturer()
        {
            using (ManagementObjectSearcher searcher =
                   new ManagementObjectSearcher(
                       "SELECT Manufacturer FROM Win32_ComputerSystem"))
            {
                foreach (ManagementObject computer in searcher.Get())
                {
                    return computer["Manufacturer"]?.ToString() ?? "Unknown";
                }
            }

            return "Unknown";
        }

        public string GetModel()
        {
            using (ManagementObjectSearcher searcher =
                   new ManagementObjectSearcher(
                       "SELECT Model FROM Win32_ComputerSystem"))
            {
                foreach (ManagementObject computer in searcher.Get())
                {
                    return computer["Model"]?.ToString() ?? "Unknown";
                }
            }

            return "Unknown";
        }

        public DeviceInfo ScanDevice()
        {
            DeviceInfo device = new DeviceInfo();

            device.DeviceId = GetDeviceId();
            device.DeviceName = Environment.MachineName;
            device.Manufacturer = GetManufacturer();
            device.Model = GetModel();

            device.CPU = GetCPU();
            device.RAM = GetRAM();
            device.GPU = GetGPU();
            device.Storage = GetStorage();
            device.WindowsVersion = GetWindowsVersion();

            return device;
        }
    }
}
