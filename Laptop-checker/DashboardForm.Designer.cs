namespace Laptop_checker
{
    partial class DashboardForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblTitle = new Label();
            txtDeviceName = new TextBox();
            label1 = new Label();
            label2 = new Label();
            txtManufacturer = new TextBox();
            label3 = new Label();
            txtModel = new TextBox();
            label4 = new Label();
            txtCpu = new TextBox();
            label5 = new Label();
            txtRam = new TextBox();
            label6 = new Label();
            txtGpu = new TextBox();
            btnScan = new Button();
            lblSubtitle = new Label();
            groupBox1 = new GroupBox();
            label8 = new Label();
            txtDeviceId = new TextBox();
            label7 = new Label();
            txtWindows = new TextBox();
            groupBox2 = new GroupBox();
            label9 = new Label();
            txtStorage = new TextBox();
            txtUserName = new TextBox();
            labelUserName = new Label();
            txtDepartment = new TextBox();
            labelDepartment = new Label();
            lblStatus = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(12, 9);
            lblTitle.Name = "lblTitle";
            lblTitle.RightToLeft = RightToLeft.No;
            lblTitle.Size = new Size(425, 31);
            lblTitle.TabIndex = 1;
            lblTitle.Text = "💻LAPTOP DEVICE CHECKER";
            lblTitle.TextAlign = ContentAlignment.TopCenter;
            lblTitle.Click += labelTitle_Click;
            // 
            // txtDeviceName
            // 
            txtDeviceName.BorderStyle = BorderStyle.FixedSingle;
            txtDeviceName.Font = new Font("Segoe UI", 11.25F);
            txtDeviceName.Location = new Point(168, 60);
            txtDeviceName.Name = "txtDeviceName";
            txtDeviceName.ReadOnly = true;
            txtDeviceName.RightToLeft = RightToLeft.No;
            txtDeviceName.Size = new Size(438, 27);
            txtDeviceName.TabIndex = 7;
            txtDeviceName.TextChanged += textUserName_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(34, 60);
            label1.Name = "label1";
            label1.RightToLeft = RightToLeft.No;
            label1.Size = new Size(110, 21);
            label1.TabIndex = 8;
            label1.Text = "Device Name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(34, 118);
            label2.Name = "label2";
            label2.RightToLeft = RightToLeft.No;
            label2.Size = new Size(114, 21);
            label2.TabIndex = 10;
            label2.Text = "Manufacturer:";
            // 
            // txtManufacturer
            // 
            txtManufacturer.BorderStyle = BorderStyle.FixedSingle;
            txtManufacturer.Font = new Font("Segoe UI", 11.25F);
            txtManufacturer.Location = new Point(168, 118);
            txtManufacturer.Name = "txtManufacturer";
            txtManufacturer.ReadOnly = true;
            txtManufacturer.RightToLeft = RightToLeft.No;
            txtManufacturer.Size = new Size(438, 27);
            txtManufacturer.TabIndex = 9;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(34, 176);
            label3.Name = "label3";
            label3.RightToLeft = RightToLeft.No;
            label3.Size = new Size(62, 21);
            label3.TabIndex = 12;
            label3.Text = "Model:";
            // 
            // txtModel
            // 
            txtModel.BorderStyle = BorderStyle.FixedSingle;
            txtModel.Font = new Font("Segoe UI", 11.25F);
            txtModel.Location = new Point(168, 176);
            txtModel.Name = "txtModel";
            txtModel.ReadOnly = true;
            txtModel.RightToLeft = RightToLeft.No;
            txtModel.Size = new Size(438, 27);
            txtModel.TabIndex = 11;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(34, 55);
            label4.Name = "label4";
            label4.RightToLeft = RightToLeft.No;
            label4.Size = new Size(44, 21);
            label4.TabIndex = 14;
            label4.Text = "CPU:";
            // 
            // txtCpu
            // 
            txtCpu.BorderStyle = BorderStyle.FixedSingle;
            txtCpu.Font = new Font("Segoe UI", 11.25F);
            txtCpu.Location = new Point(168, 55);
            txtCpu.Name = "txtCpu";
            txtCpu.ReadOnly = true;
            txtCpu.RightToLeft = RightToLeft.No;
            txtCpu.Size = new Size(438, 27);
            txtCpu.TabIndex = 13;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(34, 117);
            label5.Name = "label5";
            label5.RightToLeft = RightToLeft.No;
            label5.Size = new Size(50, 21);
            label5.TabIndex = 16;
            label5.Text = "RAM:";
            // 
            // txtRam
            // 
            txtRam.BorderStyle = BorderStyle.FixedSingle;
            txtRam.Font = new Font("Segoe UI", 11.25F);
            txtRam.Location = new Point(168, 117);
            txtRam.Name = "txtRam";
            txtRam.ReadOnly = true;
            txtRam.RightToLeft = RightToLeft.No;
            txtRam.Size = new Size(438, 27);
            txtRam.TabIndex = 15;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(34, 225);
            label6.Name = "label6";
            label6.RightToLeft = RightToLeft.No;
            label6.Size = new Size(45, 21);
            label6.TabIndex = 18;
            label6.Text = "GPU:";
            // 
            // txtGpu
            // 
            txtGpu.BorderStyle = BorderStyle.FixedSingle;
            txtGpu.Font = new Font("Segoe UI", 11.25F);
            txtGpu.Location = new Point(168, 225);
            txtGpu.Name = "txtGpu";
            txtGpu.ReadOnly = true;
            txtGpu.RightToLeft = RightToLeft.No;
            txtGpu.Size = new Size(438, 27);
            txtGpu.TabIndex = 17;
            // 
            // btnScan
            // 
            btnScan.BackColor = Color.CornflowerBlue;
            btnScan.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnScan.Location = new Point(554, 548);
            btnScan.Name = "btnScan";
            btnScan.RightToLeft = RightToLeft.No;
            btnScan.Size = new Size(233, 61);
            btnScan.TabIndex = 19;
            btnScan.Text = "Scan Sekarang";
            btnScan.UseVisualStyleBackColor = false;
            btnScan.Click += btnScan_Click;
            // 
            // lblSubtitle
            // 
            lblSubtitle.AutoSize = true;
            lblSubtitle.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSubtitle.Location = new Point(12, 40);
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.RightToLeft = RightToLeft.No;
            lblSubtitle.Size = new Size(208, 25);
            lblSubtitle.TabIndex = 20;
            lblSubtitle.Text = "Device Information";
            lblSubtitle.TextAlign = ContentAlignment.TopCenter;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(txtDeviceId);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtWindows);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtManufacturer);
            groupBox1.Controls.Add(txtDeviceName);
            groupBox1.Controls.Add(txtModel);
            groupBox1.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(12, 164);
            groupBox1.Name = "groupBox1";
            groupBox1.RightToLeft = RightToLeft.No;
            groupBox1.Size = new Size(647, 332);
            groupBox1.TabIndex = 22;
            groupBox1.TabStop = false;
            groupBox1.Text = "Device Information";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(34, 226);
            label8.Name = "label8";
            label8.RightToLeft = RightToLeft.No;
            label8.Size = new Size(83, 21);
            label8.TabIndex = 16;
            label8.Text = "Device ID:";
            // 
            // txtDeviceId
            // 
            txtDeviceId.BorderStyle = BorderStyle.FixedSingle;
            txtDeviceId.Font = new Font("Segoe UI", 11.25F);
            txtDeviceId.Location = new Point(168, 226);
            txtDeviceId.Name = "txtDeviceId";
            txtDeviceId.ReadOnly = true;
            txtDeviceId.RightToLeft = RightToLeft.No;
            txtDeviceId.Size = new Size(438, 27);
            txtDeviceId.TabIndex = 15;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(34, 279);
            label7.Name = "label7";
            label7.RightToLeft = RightToLeft.No;
            label7.Size = new Size(35, 21);
            label7.TabIndex = 14;
            label7.Text = "OS:";
            // 
            // txtWindows
            // 
            txtWindows.BorderStyle = BorderStyle.FixedSingle;
            txtWindows.Font = new Font("Segoe UI", 11.25F);
            txtWindows.Location = new Point(168, 279);
            txtWindows.Name = "txtWindows";
            txtWindows.ReadOnly = true;
            txtWindows.RightToLeft = RightToLeft.No;
            txtWindows.Size = new Size(438, 27);
            txtWindows.TabIndex = 13;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(txtStorage);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(txtCpu);
            groupBox2.Controls.Add(txtGpu);
            groupBox2.Controls.Add(txtRam);
            groupBox2.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(682, 164);
            groupBox2.Name = "groupBox2";
            groupBox2.RightToLeft = RightToLeft.No;
            groupBox2.Size = new Size(647, 332);
            groupBox2.TabIndex = 23;
            groupBox2.TabStop = false;
            groupBox2.Text = "Hardware";
            groupBox2.Enter += groupBox2_Enter;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(34, 170);
            label9.Name = "label9";
            label9.RightToLeft = RightToLeft.No;
            label9.Size = new Size(72, 21);
            label9.TabIndex = 20;
            label9.Text = "Storage:";
            // 
            // txtStorage
            // 
            txtStorage.BorderStyle = BorderStyle.FixedSingle;
            txtStorage.Font = new Font("Segoe UI", 11.25F);
            txtStorage.Location = new Point(168, 170);
            txtStorage.Name = "txtStorage";
            txtStorage.ReadOnly = true;
            txtStorage.RightToLeft = RightToLeft.No;
            txtStorage.Size = new Size(438, 27);
            txtStorage.TabIndex = 19;
            // 
            // txtUserName
            // 
            txtUserName.BorderStyle = BorderStyle.FixedSingle;
            txtUserName.Font = new Font("Segoe UI", 11.25F);
            txtUserName.Location = new Point(168, 63);
            txtUserName.Name = "txtUserName";
            txtUserName.ReadOnly = true;
            txtUserName.Size = new Size(438, 27);
            txtUserName.TabIndex = 20;
            // 
            // labelUserName
            // 
            labelUserName.AutoSize = true;
            labelUserName.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelUserName.Location = new Point(34, 63);
            labelUserName.Name = "labelUserName";
            labelUserName.Size = new Size(132, 21);
            labelUserName.TabIndex = 21;
            labelUserName.Text = "Nama Pengguna:";
            // 
            // txtDepartment
            // 
            txtDepartment.BorderStyle = BorderStyle.FixedSingle;
            txtDepartment.Font = new Font("Segoe UI", 11.25F);
            txtDepartment.Location = new Point(168, 105);
            txtDepartment.Name = "txtDepartment";
            txtDepartment.ReadOnly = true;
            txtDepartment.Size = new Size(438, 27);
            txtDepartment.TabIndex = 23;
            // 
            // labelDepartment
            // 
            labelDepartment.AutoSize = true;
            labelDepartment.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelDepartment.Location = new Point(34, 106);
            labelDepartment.Name = "labelDepartment";
            labelDepartment.Size = new Size(65, 21);
            labelDepartment.TabIndex = 24;
            labelDepartment.Text = "Bidang:";
            // 
            // lblStatus
            // 
            lblStatus.Font = new Font("Segoe UI Semibold", 10.5F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblStatus.Location = new Point(12, 660);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(1290, 19);
            lblStatus.TabIndex = 25;
            lblStatus.Text = "Siap scan device";
            // 
            // DashboardForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1346, 690);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(lblStatus);
            Controls.Add(txtUserName);
            Controls.Add(labelUserName);
            Controls.Add(txtDepartment);
            Controls.Add(labelDepartment);
            Controls.Add(lblSubtitle);
            Controls.Add(btnScan);
            Controls.Add(lblTitle);
            Name = "DashboardForm";
            Text = "DashboardForm";
            Load += DashboardForm_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private TextBox txtDeviceName;
        private Label label1;
        private Label label2;
        private TextBox txtManufacturer;
        private Label label3;
        private TextBox txtModel;
        private Label label4;
        private TextBox txtCpu;
        private Label label5;
        private TextBox txtRam;
        private Label label6;
        private TextBox txtGpu;
        private Button btnScan;
        private Label lblSubtitle;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private TextBox txtWindows;
        private Label label8;
        private TextBox txtDeviceId;
        private Label label7;
        private Label label9;
        private TextBox txtStorage;
        private TextBox txtUserName;
        private Label labelUserName;
        private TextBox txtDepartment;
        private Label labelDepartment;
        private Label lblStatus;
    }
}