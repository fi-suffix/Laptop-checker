using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Management;
using System.IO;

namespace Laptop_checker
{
    public partial class DashboardForm : Form
    {
        private DeviceInfo deviceInfo;
        private DeviceService deviceService;
        private ApiService apiService;
        private readonly string _userName;
        private readonly string _department;

        public DashboardForm(string userName = "", string department = "")
        {
            InitializeComponent();

            _userName = userName;
            _department = department;
            deviceService = new DeviceService();
            deviceInfo = new DeviceInfo();
            apiService = new ApiService();
        }

        private string GenerateDeviceId()
        {
            return Guid.NewGuid().ToString();
        }

        private string GetDeviceId()
        {
            string folderPath = Path.Combine(
                Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData),
                "LaptopChecker"
            );

            string filePath = Path.Combine(folderPath, "device.id");

            if (!Directory.Exists(folderPath))
            {
                Directory.CreateDirectory(folderPath);
            }

            if (File.Exists(filePath))
            {
                return File.ReadAllText(filePath);
            }

            string deviceId = GenerateDeviceId();

            File.WriteAllText(filePath, deviceId);

            return deviceId;
        }

        private void textUserName_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelName_Click(object sender, EventArgs e)
        {

        }

        private void DashboardForm_Load(object sender, EventArgs e)
        {
            txtUserName.Text = _userName;
            txtDepartment.Text = _department;

            lblStatus.Text = "Siap. Server: " + apiService.GetBaseUrl();
            lblStatus.ForeColor = Color.Green;
        }

        private void SetStatus(string message, Color? color = null)
        {
            lblStatus.Text = message;
            if (color.HasValue)
            {
                lblStatus.ForeColor = color.Value;
            }
        }

        private async void btnScan_Click(object sender, EventArgs e)
        {
            try
            {
                deviceInfo = deviceService.ScanDevice();

                txtDeviceId.Text = deviceInfo.DeviceId;
                txtDeviceName.Text = deviceInfo.DeviceName;
                txtManufacturer.Text = deviceInfo.Manufacturer;
                txtModel.Text = deviceInfo.Model;

                txtCpu.Text = deviceInfo.CPU;
                txtRam.Text = deviceInfo.RAM;
                txtGpu.Text = deviceInfo.GPU;
                txtStorage.Text = deviceInfo.Storage;
                txtWindows.Text = deviceInfo.WindowsVersion;

                MessageBox.Show(
                    "Informasi device berhasil dipindai!",
                    "Scan Berhasil",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

                SetStatus("Mengirim data ke server admin...", Color.OrangeRed);

                if (string.IsNullOrWhiteSpace(_userName))
                {
                    SetStatus("Nama pengguna kosong. Buka kembali form pendaftaran.", Color.Red);
                    return;
                }

                if (string.IsNullOrWhiteSpace(apiService.GetBaseUrl()))
                {
                    SetStatus("URL server belum diatur.", Color.Red);
                    return;
                }

                var (success, message) = await apiService.SendDeviceAsync(deviceInfo, _userName, _department);

                if (success)
                {
                    SetStatus("Berhasil! Data masuk ke dashboard admin.", Color.Green);
                }
                else
                {
                    SetStatus("Gagal mengirim: " + message, Color.Red);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Gagal membaca informasi device.\n\n" + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );

                SetStatus("Gagal scan: " + ex.Message, Color.Red);
            }
        }

        private void labelTitle_Click(object sender, EventArgs e)
        {

        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void OS_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
