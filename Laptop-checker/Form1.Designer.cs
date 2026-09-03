namespace Laptop_checker
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            btnScan = new Button();
            textDeviceName = new TextBox();
            textCPU = new TextBox();
            textRAM = new TextBox();
            textGPU = new TextBox();
            textModel = new TextBox();
            textManufacturer = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(314, 41);
            label1.Name = "label1";
            label1.Size = new Size(145, 15);
            label1.TabIndex = 0;
            label1.Text = "LAPTOP DEVICE CHECKER";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(51, 104);
            label2.Name = "label2";
            label2.Size = new Size(77, 15);
            label2.TabIndex = 1;
            label2.Text = "Device Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(51, 238);
            label3.Name = "label3";
            label3.Size = new Size(33, 15);
            label3.TabIndex = 2;
            label3.Text = "RAM";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(51, 203);
            label4.Name = "label4";
            label4.Size = new Size(30, 15);
            label4.TabIndex = 3;
            label4.Text = "CPU";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(51, 169);
            label5.Name = "label5";
            label5.Size = new Size(41, 15);
            label5.TabIndex = 4;
            label5.Text = "Model";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(51, 139);
            label6.Name = "label6";
            label6.Size = new Size(79, 15);
            label6.TabIndex = 5;
            label6.Text = "Manufacturer";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(51, 275);
            label7.Name = "label7";
            label7.Size = new Size(30, 15);
            label7.TabIndex = 6;
            label7.Text = "GPU";
            // 
            // btnScan
            // 
            btnScan.BackColor = SystemColors.GrayText;
            btnScan.Location = new Point(291, 353);
            btnScan.Name = "btnScan";
            btnScan.Size = new Size(182, 60);
            btnScan.TabIndex = 7;
            btnScan.Text = "Scan Device Now";
            btnScan.UseVisualStyleBackColor = false;
            btnScan.Click += btnScan_Click;
            // 
            // textDeviceName
            // 
            textDeviceName.Location = new Point(252, 104);
            textDeviceName.Name = "textDeviceName";
            textDeviceName.Size = new Size(339, 23);
            textDeviceName.TabIndex = 8;
            // 
            // textCPU
            // 
            textCPU.Location = new Point(252, 203);
            textCPU.Name = "textCPU";
            textCPU.Size = new Size(339, 23);
            textCPU.TabIndex = 9;
            // 
            // textRAM
            // 
            textRAM.Location = new Point(252, 238);
            textRAM.Name = "textRAM";
            textRAM.Size = new Size(339, 23);
            textRAM.TabIndex = 10;
            // 
            // textGPU
            // 
            textGPU.Location = new Point(252, 275);
            textGPU.Name = "textGPU";
            textGPU.Size = new Size(339, 23);
            textGPU.TabIndex = 11;
            // 
            // textModel
            // 
            textModel.Location = new Point(252, 169);
            textModel.Name = "textModel";
            textModel.Size = new Size(339, 23);
            textModel.TabIndex = 12;
            // 
            // textManufacturer
            // 
            textManufacturer.Location = new Point(252, 136);
            textManufacturer.Name = "textManufacturer";
            textManufacturer.Size = new Size(339, 23);
            textManufacturer.TabIndex = 13;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textManufacturer);
            Controls.Add(textModel);
            Controls.Add(textGPU);
            Controls.Add(textRAM);
            Controls.Add(textCPU);
            Controls.Add(textDeviceName);
            Controls.Add(btnScan);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "MainForm";
            Text = "Laptop Device Checker";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Button btnScan;
        private TextBox textDeviceName;
        private TextBox textCPU;
        private TextBox textBox3;
        private TextBox textGPU;
        private TextBox textModel;
        private TextBox textManufacturer;
    }
}
