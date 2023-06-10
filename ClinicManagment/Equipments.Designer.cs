namespace ClinicManagment
{
    partial class Equipments
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Equipments));
            this.EquipmentsDGV = new System.Windows.Forms.DataGridView();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.saveBtn = new System.Windows.Forms.Button();
            this.editBtn = new System.Windows.Forms.Button();
            this.EqName = new System.Windows.Forms.TextBox();
            this.EqDesciption = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.EqQuantity = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
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
            ((System.ComponentModel.ISupportInitialize)(this.EquipmentsDGV)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox14)).BeginInit();
            this.SuspendLayout();
            // 
            // EquipmentsDGV
            // 
            this.EquipmentsDGV.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.EquipmentsDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.EquipmentsDGV.Location = new System.Drawing.Point(326, 225);
            this.EquipmentsDGV.Name = "EquipmentsDGV";
            this.EquipmentsDGV.RowHeadersWidth = 51;
            this.EquipmentsDGV.RowTemplate.Height = 29;
            this.EquipmentsDGV.Size = new System.Drawing.Size(845, 365);
            this.EquipmentsDGV.TabIndex = 46;
            this.EquipmentsDGV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.EquipmentsDGV_CellClick);
            // 
            // deleteBtn
            // 
            this.deleteBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(158)))), ((int)(((byte)(189)))));
            this.deleteBtn.Location = new System.Drawing.Point(834, 169);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(156, 29);
            this.deleteBtn.TabIndex = 45;
            this.deleteBtn.Text = "DELETE";
            this.deleteBtn.UseVisualStyleBackColor = false;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // saveBtn
            // 
            this.saveBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(158)))), ((int)(((byte)(189)))));
            this.saveBtn.Location = new System.Drawing.Point(663, 169);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(156, 29);
            this.saveBtn.TabIndex = 44;
            this.saveBtn.Text = "SAVE";
            this.saveBtn.UseVisualStyleBackColor = false;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // editBtn
            // 
            this.editBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(158)))), ((int)(((byte)(189)))));
            this.editBtn.Location = new System.Drawing.Point(487, 169);
            this.editBtn.Name = "editBtn";
            this.editBtn.Size = new System.Drawing.Size(156, 29);
            this.editBtn.TabIndex = 43;
            this.editBtn.Text = "EDIT";
            this.editBtn.UseVisualStyleBackColor = false;
            this.editBtn.Click += new System.EventHandler(this.editBtn_Click);
            // 
            // EqName
            // 
            this.EqName.Location = new System.Drawing.Point(395, 118);
            this.EqName.Name = "EqName";
            this.EqName.Size = new System.Drawing.Size(147, 27);
            this.EqName.TabIndex = 42;
            // 
            // EqDesciption
            // 
            this.EqDesciption.Location = new System.Drawing.Point(758, 118);
            this.EqDesciption.Multiline = true;
            this.EqDesciption.Name = "EqDesciption";
            this.EqDesciption.Size = new System.Drawing.Size(355, 27);
            this.EqDesciption.TabIndex = 41;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label12.Location = new System.Drawing.Point(395, 86);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(64, 28);
            this.label12.TabIndex = 40;
            this.label12.Text = "Name";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(758, 85);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(112, 28);
            this.label11.TabIndex = 39;
            this.label11.Text = "Description";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Symbol", 19.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(643, 25);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(219, 45);
            this.label8.TabIndex = 38;
            this.label8.Text = "EQUIPMENTS";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // EqQuantity
            // 
            this.EqQuantity.Location = new System.Drawing.Point(565, 118);
            this.EqQuantity.Multiline = true;
            this.EqQuantity.Name = "EqQuantity";
            this.EqQuantity.Size = new System.Drawing.Size(150, 27);
            this.EqQuantity.TabIndex = 47;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(565, 87);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(88, 28);
            this.label9.TabIndex = 48;
            this.label9.Text = "Quantity";
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
            this.panel2.TabIndex = 49;
            // 
            // PatientBtn
            // 
            this.PatientBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(158)))), ((int)(((byte)(189)))));
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
            // Equipments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1241, 640);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.EqQuantity);
            this.Controls.Add(this.EquipmentsDGV);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.editBtn);
            this.Controls.Add(this.EqName);
            this.Controls.Add(this.EqDesciption);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label8);
            this.Name = "Equipments";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Equipments";
            this.Load += new System.EventHandler(this.Equipments_Load);
            ((System.ComponentModel.ISupportInitialize)(this.EquipmentsDGV)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox14)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView EquipmentsDGV;
        private Button deleteBtn;
        private Button saveBtn;
        private Button editBtn;
        private TextBox textBox3;
        private TextBox textBox2;
        private Label label12;
        private Label label11;
        private Label label8;
        private TextBox textBox1;
        private Label label9;
        private TextBox EqName;
        private TextBox EqDesciption;
        private TextBox EqQuantity;
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
    }
}