namespace ClinicManagment
{
    partial class Appointment
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Appointment));
            this.AppointmentDGV = new System.Windows.Forms.DataGridView();
            this.label21 = new System.Windows.Forms.Label();
            this.AppointmentDatePicker = new System.Windows.Forms.DateTimePicker();
            this.label25 = new System.Windows.Forms.Label();
            this.PatientComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.EquipmentComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ServiceComboBox = new System.Windows.Forms.ComboBox();
            this.Doctor = new System.Windows.Forms.Label();
            this.StaffComboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.StartTimePicker = new System.Windows.Forms.DateTimePicker();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.saveBtn = new System.Windows.Forms.Button();
            this.editBtn = new System.Windows.Forms.Button();
            this.PriorityCb = new System.Windows.Forms.ComboBox();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.PatientBtn = new System.Windows.Forms.Button();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.label16 = new System.Windows.Forms.Label();
            this.pictureBox11 = new System.Windows.Forms.PictureBox();
            this.pictureBox12 = new System.Windows.Forms.PictureBox();
            this.pictureBox13 = new System.Windows.Forms.PictureBox();
            this.pictureBox14 = new System.Windows.Forms.PictureBox();
            this.StaffBtn = new System.Windows.Forms.Button();
            this.ServicesBtn = new System.Windows.Forms.Button();
            this.AppointmentBtn = new System.Windows.Forms.Button();
            this.EquipmentBtn = new System.Windows.Forms.Button();
            this.LogoutBtn = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SearchTb = new System.Windows.Forms.TextBox();
            this.Save = new System.Windows.Forms.Button();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.displayQr = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.AppointmentDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // AppointmentDGV
            // 
            this.AppointmentDGV.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.AppointmentDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AppointmentDGV.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.AppointmentDGV.Location = new System.Drawing.Point(229, 263);
            this.AppointmentDGV.Name = "AppointmentDGV";
            this.AppointmentDGV.RowHeadersWidth = 51;
            this.AppointmentDGV.RowTemplate.Height = 29;
            this.AppointmentDGV.Size = new System.Drawing.Size(1000, 286);
            this.AppointmentDGV.TabIndex = 90;
            this.AppointmentDGV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.AppointmentDGV_CellClick);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label21.Location = new System.Drawing.Point(296, 126);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(198, 28);
            this.label21.TabIndex = 89;
            this.label21.Text = "Date of Appointment";
            // 
            // AppointmentDatePicker
            // 
            this.AppointmentDatePicker.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(231)))), ((int)(((byte)(245)))));
            this.AppointmentDatePicker.Location = new System.Drawing.Point(296, 154);
            this.AppointmentDatePicker.Name = "AppointmentDatePicker";
            this.AppointmentDatePicker.Size = new System.Drawing.Size(347, 27);
            this.AppointmentDatePicker.TabIndex = 88;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label25.Location = new System.Drawing.Point(223, 55);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(154, 28);
            this.label25.TabIndex = 86;
            this.label25.Text = "Name of patient";
            // 
            // PatientComboBox
            // 
            this.PatientComboBox.FormattingEnabled = true;
            this.PatientComboBox.Location = new System.Drawing.Point(226, 86);
            this.PatientComboBox.Name = "PatientComboBox";
            this.PatientComboBox.Size = new System.Drawing.Size(175, 28);
            this.PatientComboBox.TabIndex = 93;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(414, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 28);
            this.label1.TabIndex = 95;
            this.label1.Text = "Equipment";
            // 
            // EquipmentComboBox
            // 
            this.EquipmentComboBox.FormattingEnabled = true;
            this.EquipmentComboBox.Location = new System.Drawing.Point(414, 86);
            this.EquipmentComboBox.Name = "EquipmentComboBox";
            this.EquipmentComboBox.Size = new System.Drawing.Size(175, 28);
            this.EquipmentComboBox.TabIndex = 96;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(785, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 28);
            this.label2.TabIndex = 97;
            this.label2.Text = "Service";
            // 
            // ServiceComboBox
            // 
            this.ServiceComboBox.FormattingEnabled = true;
            this.ServiceComboBox.Location = new System.Drawing.Point(785, 86);
            this.ServiceComboBox.Name = "ServiceComboBox";
            this.ServiceComboBox.Size = new System.Drawing.Size(171, 28);
            this.ServiceComboBox.TabIndex = 98;
            // 
            // Doctor
            // 
            this.Doctor.AutoSize = true;
            this.Doctor.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.Doctor.Location = new System.Drawing.Point(595, 55);
            this.Doctor.Name = "Doctor";
            this.Doctor.Size = new System.Drawing.Size(73, 28);
            this.Doctor.TabIndex = 99;
            this.Doctor.Text = "Doctor";
            // 
            // StaffComboBox
            // 
            this.StaffComboBox.FormattingEnabled = true;
            this.StaffComboBox.Location = new System.Drawing.Point(595, 86);
            this.StaffComboBox.Name = "StaffComboBox";
            this.StaffComboBox.Size = new System.Drawing.Size(184, 28);
            this.StaffComboBox.TabIndex = 100;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(806, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 28);
            this.label3.TabIndex = 101;
            this.label3.Text = "Priority";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(659, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 28);
            this.label4.TabIndex = 104;
            this.label4.Text = "Start Time";
            // 
            // StartTimePicker
            // 
            this.StartTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.StartTimePicker.Location = new System.Drawing.Point(659, 154);
            this.StartTimePicker.Name = "StartTimePicker";
            this.StartTimePicker.Size = new System.Drawing.Size(141, 27);
            this.StartTimePicker.TabIndex = 106;
            this.StartTimePicker.Value = new System.DateTime(2023, 6, 3, 12, 52, 0, 0);
            // 
            // deleteBtn
            // 
            this.deleteBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(158)))), ((int)(((byte)(189)))));
            this.deleteBtn.Location = new System.Drawing.Point(726, 209);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(156, 29);
            this.deleteBtn.TabIndex = 110;
            this.deleteBtn.Text = "DELETE";
            this.deleteBtn.UseVisualStyleBackColor = false;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // saveBtn
            // 
            this.saveBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(158)))), ((int)(((byte)(189)))));
            this.saveBtn.Location = new System.Drawing.Point(555, 209);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(156, 29);
            this.saveBtn.TabIndex = 109;
            this.saveBtn.Text = "SAVE";
            this.saveBtn.UseVisualStyleBackColor = false;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // editBtn
            // 
            this.editBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(158)))), ((int)(((byte)(189)))));
            this.editBtn.Location = new System.Drawing.Point(379, 209);
            this.editBtn.Name = "editBtn";
            this.editBtn.Size = new System.Drawing.Size(156, 29);
            this.editBtn.TabIndex = 108;
            this.editBtn.Text = "EDIT";
            this.editBtn.UseVisualStyleBackColor = false;
            this.editBtn.Click += new System.EventHandler(this.editBtn_Click);
            // 
            // PriorityCb
            // 
            this.PriorityCb.FormattingEnabled = true;
            this.PriorityCb.Items.AddRange(new object[] {
            "YES",
            "NO"});
            this.PriorityCb.Location = new System.Drawing.Point(809, 153);
            this.PriorityCb.Name = "PriorityCb";
            this.PriorityCb.Size = new System.Drawing.Size(73, 28);
            this.PriorityCb.TabIndex = 112;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(158)))), ((int)(((byte)(189)))));
            this.panel2.Controls.Add(this.PatientBtn);
            this.panel2.Controls.Add(this.pictureBox8);
            this.panel2.Controls.Add(this.pictureBox9);
            this.panel2.Controls.Add(this.pictureBox10);
            this.panel2.Controls.Add(this.label16);
            this.panel2.Controls.Add(this.pictureBox11);
            this.panel2.Controls.Add(this.pictureBox12);
            this.panel2.Controls.Add(this.pictureBox13);
            this.panel2.Controls.Add(this.pictureBox14);
            this.panel2.Controls.Add(this.StaffBtn);
            this.panel2.Controls.Add(this.ServicesBtn);
            this.panel2.Controls.Add(this.AppointmentBtn);
            this.panel2.Controls.Add(this.EquipmentBtn);
            this.panel2.Controls.Add(this.LogoutBtn);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(218, 638);
            this.panel2.TabIndex = 114;
            // 
            // PatientBtn
            // 
            this.PatientBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(158)))), ((int)(((byte)(189)))));
            this.PatientBtn.Enabled = false;
            this.PatientBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(158)))), ((int)(((byte)(189)))));
            this.PatientBtn.FlatAppearance.BorderSize = 0;
            this.PatientBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PatientBtn.Font = new System.Drawing.Font("Segoe UI Variable Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.PatientBtn.Location = new System.Drawing.Point(53, 155);
            this.PatientBtn.Name = "PatientBtn";
            this.PatientBtn.Size = new System.Drawing.Size(105, 42);
            this.PatientBtn.TabIndex = 89;
            this.PatientBtn.Text = "PATIENT";
            this.PatientBtn.UseVisualStyleBackColor = false;
            this.PatientBtn.Click += new System.EventHandler(this.PatientBtn_Click);
            // 
            // pictureBox8
            // 
            this.pictureBox8.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox8.Image")));
            this.pictureBox8.Location = new System.Drawing.Point(6, 431);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(54, 35);
            this.pictureBox8.TabIndex = 12;
            this.pictureBox8.TabStop = false;
            // 
            // pictureBox9
            // 
            this.pictureBox9.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox9.Image")));
            this.pictureBox9.Location = new System.Drawing.Point(9, 363);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(42, 42);
            this.pictureBox9.TabIndex = 10;
            this.pictureBox9.TabStop = false;
            // 
            // pictureBox10
            // 
            this.pictureBox10.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox10.Image")));
            this.pictureBox10.Location = new System.Drawing.Point(9, 294);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(42, 42);
            this.pictureBox10.TabIndex = 8;
            this.pictureBox10.TabStop = false;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Segoe UI Variable Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label16.Location = new System.Drawing.Point(32, 61);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(133, 27);
            this.label16.TabIndex = 6;
            this.label16.Text = "HospitalCare";
            // 
            // pictureBox11
            // 
            this.pictureBox11.AccessibleName = "";
            this.pictureBox11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(158)))), ((int)(((byte)(189)))));
            this.pictureBox11.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox11.Image")));
            this.pictureBox11.Location = new System.Drawing.Point(20, -40);
            this.pictureBox11.Name = "pictureBox11";
            this.pictureBox11.Size = new System.Drawing.Size(157, 110);
            this.pictureBox11.TabIndex = 2;
            this.pictureBox11.TabStop = false;
            // 
            // pictureBox12
            // 
            this.pictureBox12.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox12.Image")));
            this.pictureBox12.Location = new System.Drawing.Point(11, 225);
            this.pictureBox12.Name = "pictureBox12";
            this.pictureBox12.Size = new System.Drawing.Size(42, 42);
            this.pictureBox12.TabIndex = 5;
            this.pictureBox12.TabStop = false;
            // 
            // pictureBox13
            // 
            this.pictureBox13.Image = global::ClinicManagment.Properties.Resources.login_removebg_preview;
            this.pictureBox13.Location = new System.Drawing.Point(11, 580);
            this.pictureBox13.Name = "pictureBox13";
            this.pictureBox13.Size = new System.Drawing.Size(50, 40);
            this.pictureBox13.TabIndex = 2;
            this.pictureBox13.TabStop = false;
            // 
            // pictureBox14
            // 
            this.pictureBox14.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox14.Image")));
            this.pictureBox14.Location = new System.Drawing.Point(11, 155);
            this.pictureBox14.Name = "pictureBox14";
            this.pictureBox14.Size = new System.Drawing.Size(42, 42);
            this.pictureBox14.TabIndex = 2;
            this.pictureBox14.TabStop = false;
            // 
            // StaffBtn
            // 
            this.StaffBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(158)))), ((int)(((byte)(189)))));
            this.StaffBtn.Enabled = false;
            this.StaffBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(158)))), ((int)(((byte)(189)))));
            this.StaffBtn.FlatAppearance.BorderSize = 0;
            this.StaffBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StaffBtn.Font = new System.Drawing.Font("Segoe UI Variable Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.StaffBtn.Location = new System.Drawing.Point(32, 225);
            this.StaffBtn.Name = "StaffBtn";
            this.StaffBtn.Size = new System.Drawing.Size(105, 42);
            this.StaffBtn.TabIndex = 90;
            this.StaffBtn.Text = "STAFF";
            this.StaffBtn.UseVisualStyleBackColor = false;
            this.StaffBtn.Click += new System.EventHandler(this.StaffBtn_Click);
            // 
            // ServicesBtn
            // 
            this.ServicesBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(158)))), ((int)(((byte)(189)))));
            this.ServicesBtn.Enabled = false;
            this.ServicesBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(158)))), ((int)(((byte)(189)))));
            this.ServicesBtn.FlatAppearance.BorderSize = 0;
            this.ServicesBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ServicesBtn.Font = new System.Drawing.Font("Segoe UI Variable Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ServicesBtn.Location = new System.Drawing.Point(45, 294);
            this.ServicesBtn.Name = "ServicesBtn";
            this.ServicesBtn.Size = new System.Drawing.Size(113, 42);
            this.ServicesBtn.TabIndex = 91;
            this.ServicesBtn.Text = "SERVICES";
            this.ServicesBtn.UseVisualStyleBackColor = false;
            this.ServicesBtn.Click += new System.EventHandler(this.ServicesBtn_Click);
            // 
            // AppointmentBtn
            // 
            this.AppointmentBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(158)))), ((int)(((byte)(189)))));
            this.AppointmentBtn.Enabled = false;
            this.AppointmentBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(158)))), ((int)(((byte)(189)))));
            this.AppointmentBtn.FlatAppearance.BorderSize = 0;
            this.AppointmentBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AppointmentBtn.Font = new System.Drawing.Font("Segoe UI Variable Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.AppointmentBtn.Location = new System.Drawing.Point(41, 363);
            this.AppointmentBtn.Name = "AppointmentBtn";
            this.AppointmentBtn.Size = new System.Drawing.Size(174, 42);
            this.AppointmentBtn.TabIndex = 92;
            this.AppointmentBtn.Text = "APPOINTMENT";
            this.AppointmentBtn.UseVisualStyleBackColor = false;
            this.AppointmentBtn.Click += new System.EventHandler(this.AppointmentBtn_Click);
            // 
            // EquipmentBtn
            // 
            this.EquipmentBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(158)))), ((int)(((byte)(189)))));
            this.EquipmentBtn.Enabled = false;
            this.EquipmentBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(158)))), ((int)(((byte)(189)))));
            this.EquipmentBtn.FlatAppearance.BorderSize = 0;
            this.EquipmentBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EquipmentBtn.Font = new System.Drawing.Font("Segoe UI Variable Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.EquipmentBtn.Location = new System.Drawing.Point(45, 431);
            this.EquipmentBtn.Name = "EquipmentBtn";
            this.EquipmentBtn.Size = new System.Drawing.Size(146, 35);
            this.EquipmentBtn.TabIndex = 92;
            this.EquipmentBtn.Text = "EQUIPMENT";
            this.EquipmentBtn.UseVisualStyleBackColor = false;
            this.EquipmentBtn.Click += new System.EventHandler(this.EquipmentBtn_Click);
            // 
            // LogoutBtn
            // 
            this.LogoutBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(158)))), ((int)(((byte)(189)))));
            this.LogoutBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(158)))), ((int)(((byte)(189)))));
            this.LogoutBtn.FlatAppearance.BorderSize = 0;
            this.LogoutBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LogoutBtn.Font = new System.Drawing.Font("Segoe UI Variable Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LogoutBtn.Location = new System.Drawing.Point(45, 585);
            this.LogoutBtn.Name = "LogoutBtn";
            this.LogoutBtn.Size = new System.Drawing.Size(146, 35);
            this.LogoutBtn.TabIndex = 93;
            this.LogoutBtn.Text = "LOG OUT";
            this.LogoutBtn.UseVisualStyleBackColor = false;
            this.LogoutBtn.Click += new System.EventHandler(this.LogoutBtn_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Symbol", 19.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(542, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(242, 45);
            this.label8.TabIndex = 115;
            this.label8.Text = "APPOINTMENT";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(158)))), ((int)(((byte)(189)))));
            this.button1.Location = new System.Drawing.Point(1151, 570);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(78, 29);
            this.button1.TabIndex = 116;
            this.button1.Text = "SEARCH";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // SearchTb
            // 
            this.SearchTb.Location = new System.Drawing.Point(942, 572);
            this.SearchTb.Name = "SearchTb";
            this.SearchTb.Size = new System.Drawing.Size(203, 27);
            this.SearchTb.TabIndex = 117;
            // 
            // Save
            // 
            this.Save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(158)))), ((int)(((byte)(189)))));
            this.Save.Location = new System.Drawing.Point(229, 572);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(78, 29);
            this.Save.TabIndex = 118;
            this.Save.Text = "SAVE LIST";
            this.Save.UseVisualStyleBackColor = false;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(988, 29);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(188, 152);
            this.pictureBox.TabIndex = 119;
            this.pictureBox.TabStop = false;
            // 
            // displayQr
            // 
            this.displayQr.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(158)))), ((int)(((byte)(189)))));
            this.displayQr.Location = new System.Drawing.Point(1006, 209);
            this.displayQr.Name = "displayQr";
            this.displayQr.Size = new System.Drawing.Size(156, 29);
            this.displayQr.TabIndex = 120;
            this.displayQr.Text = "Display QR";
            this.displayQr.UseVisualStyleBackColor = false;
            this.displayQr.Click += new System.EventHandler(this.displayQr_Click);
            // 
            // Appointment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1241, 640);
            this.Controls.Add(this.displayQr);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.SearchTb);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.PriorityCb);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.editBtn);
            this.Controls.Add(this.StartTimePicker);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.StaffComboBox);
            this.Controls.Add(this.Doctor);
            this.Controls.Add(this.ServiceComboBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.EquipmentComboBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PatientComboBox);
            this.Controls.Add(this.AppointmentDGV);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.AppointmentDatePicker);
            this.Controls.Add(this.label25);
            this.Name = "Appointment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Appointment";
            this.Load += new System.EventHandler(this.Appointment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.AppointmentDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView AppointmentDGV;
        private Label label21;
        private DateTimePicker AppointmentDatePicker;
        private Label label25;
        private ComboBox PatientComboBox;
        private Label label1;
        private ComboBox EquipmentComboBox;
        private Label label2;
        private ComboBox ServiceComboBox;
        private Label Doctor;
        private ComboBox StaffComboBox;
        private Label label3;
        private CheckBox checkBox1;
        private Label label4;
        private Label label5;
        private DateTimePicker StartTimePicker;
        private DateTimePicker EndTimePicker;
        private Button deleteBtn;
        private Button saveBtn;
        private Button editBtn;
        private ComboBox PriorityCb;
        private Label SEARCH;
        private BindingSource bindingSource1;
        private Panel panel2;
        private Button PatientBtn;
        private PictureBox pictureBox8;
        private PictureBox pictureBox9;
        private PictureBox pictureBox10;
        private Label label16;
        private PictureBox pictureBox11;
        private PictureBox pictureBox12;
        private PictureBox pictureBox13;
        private PictureBox pictureBox14;
        private Button StaffBtn;
        private Button ServicesBtn;
        private Button AppointmentBtn;
        private Button EquipmentBtn;
        private Button LogoutBtn;
        private Label label8;
        private PictureBox QrBox;
        private Button button1;
        private TextBox SearchTb;
        private Button Save;
        private PictureBox pictureBox;
        private Button displayQr;
    }
}