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
            labelTitle = new Label();
            panelRegister = new Panel();
            btnRegister = new Button();
            textUserName = new TextBox();
            labelName = new Label();
            labelDepartment = new Label();
            comboBoxDepartment = new ComboBox();
            labelDescription = new Label();
            labelSubtitle = new Label();
            panelRegister.SuspendLayout();
            SuspendLayout();
            // 
            // labelTitle
            // 
            labelTitle.AutoSize = true;
            labelTitle.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelTitle.Location = new Point(218, 33);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(344, 29);
            labelTitle.TabIndex = 0;
            labelTitle.Text = "LAPTOP DEVICE CHECKER";
            labelTitle.TextAlign = ContentAlignment.TopCenter;
            labelTitle.Click += label1_Click;
            // 
            // panelRegister
            // 
            panelRegister.Controls.Add(btnRegister);
            panelRegister.Controls.Add(comboBoxDepartment);
            panelRegister.Controls.Add(labelDepartment);
            panelRegister.Controls.Add(textUserName);
            panelRegister.Controls.Add(labelName);
            panelRegister.Controls.Add(labelDescription);
            panelRegister.Controls.Add(labelSubtitle);
            panelRegister.Controls.Add(labelTitle);
            panelRegister.Location = new Point(12, 12);
            panelRegister.Name = "panelRegister";
            panelRegister.Size = new Size(776, 426);
            panelRegister.TabIndex = 1;
            panelRegister.Paint += panelRegister_Paint;
            // 
            // btnRegister
            // 
            btnRegister.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRegister.Location = new Point(266, 358);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(233, 61);
            btnRegister.TabIndex = 5;
            btnRegister.Text = "Daftarkan Device";
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += btnRegister_Click;
            // 
            // textUserName
            // 
            textUserName.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textUserName.Location = new Point(228, 262);
            textUserName.Name = "textUserName";
            textUserName.Size = new Size(316, 33);
            textUserName.TabIndex = 4;
            // 
            // labelDepartment
            // 
            labelDepartment.AutoSize = true;
            labelDepartment.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelDepartment.Location = new Point(228, 294);
            labelDepartment.Name = "labelDepartment";
            labelDepartment.Size = new Size(210, 21);
            labelDepartment.TabIndex = 6;
            labelDepartment.Text = "Bidang / Departemen:";
            // 
            // comboBoxDepartment
            // 
            comboBoxDepartment.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxDepartment.Font = new Font("Segoe UI", 11.25F);
            comboBoxDepartment.ItemHeight = 31;
            comboBoxDepartment.Location = new Point(228, 316);
            comboBoxDepartment.Name = "comboBoxDepartment";
            comboBoxDepartment.Size = new Size(316, 36);
            comboBoxDepartment.TabIndex = 6;
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Location = new Point(228, 244);
            labelName.Name = "labelName";
            labelName.Size = new Size(96, 15);
            labelName.TabIndex = 3;
            labelName.Text = "Nama Pengguna";
            labelName.Click += label1_Click_1;
            // 
            // labelDescription
            // 
            labelDescription.AutoSize = true;
            labelDescription.Location = new Point(236, 174);
            labelDescription.Name = "labelDescription";
            labelDescription.Size = new Size(298, 15);
            labelDescription.TabIndex = 2;
            labelDescription.Text = "Sebelum mulai, mohon masukan nama terlebih dahulu";
            // 
            // labelSubtitle
            // 
            labelSubtitle.AutoSize = true;
            labelSubtitle.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelSubtitle.Location = new Point(313, 83);
            labelSubtitle.Name = "labelSubtitle";
            labelSubtitle.Size = new Size(138, 20);
            labelSubtitle.TabIndex = 1;
            labelSubtitle.Text = "Device Registration";
            labelSubtitle.Click += label2_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panelRegister);
            Name = "MainForm";
            Text = "Laptop Device Checker";
            panelRegister.ResumeLayout(false);
            panelRegister.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private TextBox textBox3;
        private Label labelTitle;
        private Panel panelRegister;
        private Label labelSubtitle;
        private Label labelDescription;
        private Label labelName;
        private TextBox textUserName;
        private Label labelDepartment;
        private ComboBox comboBoxDepartment;
        private Button btnRegister;
    }
}
