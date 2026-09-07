using System;
using System.Windows.Forms;
using System.Management;
using System.Collections.Generic;

namespace Laptop_checker
{
    public partial class MainForm : Form
    {
        private readonly string[] Departments = new[]
        {
            "Bidang Pemerintahan Desa",
            "Bidang Pembangunan Ekonomi dan Pendapatan Desa",
            "Bidang Sarana Prasarana dan Kewilayahan",
            "Bidang Pemberdayaan Masyarakat Desa"
        };

        public MainForm()
        {
            InitializeComponent();
            InitializeDepartment();
        }

        private void InitializeDepartment()
        {
            comboBoxDepartment.Items.Clear();
            comboBoxDepartment.Items.AddRange(Departments);
            comboBoxDepartment.SelectedIndex = 0;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnScan_Click(object sender, EventArgs e)
        {
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string userName = textUserName.Text.Trim();

            if (string.IsNullOrEmpty(userName))
            {
                MessageBox.Show(
                    "Nama pengguna wajib diisi!",
                    "Peringatan",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                textUserName.Focus();
                return;
            }

            string department = comboBoxDepartment.SelectedItem?.ToString()
                ?? comboBoxDepartment.Text;

            if (string.IsNullOrWhiteSpace(department))
            {
                MessageBox.Show(
                    "Silakan pilih bidang terlebih dahulu!",
                    "Peringatan",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            DashboardForm dashboard = new DashboardForm(userName, department);

            dashboard.Show();

            this.Hide();
        }

        private void panelRegister_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}