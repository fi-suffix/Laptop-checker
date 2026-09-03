using System;
using System.Windows.Forms;
using System.Management;

namespace Laptop_checker
{
    public partial class MainForm : Form
    {
        // Designer expects this to be a TextBox control
        private TextBox textRAM;

        public MainForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private string GetCPU()
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

        private string GetRAM()
        {
            using (ManagementObjectSearcher searcher =
                   new ManagementObjectSearcher(
                       "SELECT TotalPhysicalMemory FROM Win32_ComputerSystem"))
            {
                foreach (ManagementObject computer in searcher.Get())
                {
                    if (computer["TotalPhysicalMemory"] != null)
                    {
                        double bytes = Convert.ToDouble(
                            computer["TotalPhysicalMemory"]
                        );

                        double gigabytes = bytes / 1024 / 1024 / 1024;

                        return $"{Math.Round(gigabytes, 0)} GB";
                    }
                }
            }

            return "Unknown";
        }

        private string GetGPU()
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

        private void btnScan_Click(object sender, EventArgs e)
        {
            textDeviceName.Text = Environment.MachineName;

            using (ManagementObjectSearcher searcher =
            new ManagementObjectSearcher("SELECT Manufacturer, Model FROM Win32_ComputerSystem"))
            {
                foreach (ManagementObject computer in searcher.Get())
                {
                    textManufacturer.Text = computer["Manufacturer"]?.ToString() ?? "Unknown";
                    textModel.Text = computer["Model"]?.ToString() ?? "Unknown";
                }
            }

            textCPU.Text = GetCPU();
            textRAM.Text = GetRAM();
            textGPU.Text = GetGPU();
        }
    }
}