using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QRCoder;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using ClinicManagment;
using System.Xml.Linq;
using System.Reflection.Metadata;
using OfficeOpenXml;
using System.Windows.Forms;
using System.IO;
using LicenseContext = OfficeOpenXml.LicenseContext;

namespace ClinicManagment
{
    public partial class Appointment : Form
    {
        public Appointment()
        {

            InitializeComponent();
            ShowAppointments();
            LoadComboBoxes();

        }
        SqlConnection conn = new SqlConnection(@"Data Source=.\SQLEXPRESS; Initial Catalog=HospitalManagement; integrated security=SSPI;");



        private void ShowAppointments()
        {
            conn.Open();
            string query = "SELECT a.AppointmentId, p.Name AS PatientName, e.Name AS EquipmentName, s.Name AS StaffName, sv.Name AS ServiceName, a.HasPriority, a.Date, a.StartTime, a.EndTime " +
                           "FROM Appointment a " +
                           "INNER JOIN Patient p ON a.PatientId = p.PatientId " +
                           "INNER JOIN Equipment e ON a.EquipmentId = e.EquipmentId " +
                           "INNER JOIN Staff s ON a.StaffId = s.StaffId " +
                           "INNER JOIN Service sv ON a.ServiceId = sv.ServiceId";
            SqlCommand command = new SqlCommand(query, conn);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            AppointmentDGV.DataSource = dt;
            conn.Close();


        }
        private void LoadComboBoxes()
        {
            // Load patients
            conn.Open();
            string queryPatients = "SELECT PatientId, Name FROM Patient";
            SqlCommand commandPatients = new SqlCommand(queryPatients, conn);
            SqlDataReader readerPatients = commandPatients.ExecuteReader();
            DataTable dtPatients = new DataTable();
            dtPatients.Load(readerPatients);
            PatientComboBox.DataSource = dtPatients;
            PatientComboBox.DisplayMember = "Name";
            PatientComboBox.ValueMember = "PatientId";
            conn.Close();

            // Load equipment
            conn.Open();
            string queryEquipment = "SELECT EquipmentId, Name FROM Equipment";
            SqlCommand commandEquipment = new SqlCommand(queryEquipment, conn);
            SqlDataReader readerEquipment = commandEquipment.ExecuteReader();
            DataTable dtEquipment = new DataTable();
            dtEquipment.Load(readerEquipment);
            EquipmentComboBox.DataSource = dtEquipment;
            EquipmentComboBox.DisplayMember = "Name";
            EquipmentComboBox.ValueMember = "EquipmentId";
            conn.Close();

            // Load staff
            conn.Open();
            string queryStaff = "SELECT StaffId, Name FROM Staff WHERE Name='doctor'";
            SqlCommand commandStaff = new SqlCommand(queryStaff, conn);
            SqlDataReader readerStaff = commandStaff.ExecuteReader();
            DataTable dtStaff = new DataTable();
            dtStaff.Load(readerStaff);
            StaffComboBox.DataSource = dtStaff;
            StaffComboBox.DisplayMember = "Name";
            StaffComboBox.ValueMember = "StaffId";
            conn.Close();

            // Load services
            conn.Open();
            string queryServices = "SELECT ServiceId, Name FROM Service";
            SqlCommand commandServices = new SqlCommand(queryServices, conn);
            SqlDataReader readerServices = commandServices.ExecuteReader();
            DataTable dtServices = new DataTable();
            dtServices.Load(readerServices);
            ServiceComboBox.DataSource = dtServices;
            ServiceComboBox.DisplayMember = "Name";
            ServiceComboBox.ValueMember = "ServiceId";
            conn.Close();
        }



        private void saveBtn_Click(object sender, EventArgs e)
        {
            if (PriorityCb.SelectedItem == null)
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    conn.Open();

                    SqlCommand durationCmd = new SqlCommand("SELECT Duration FROM Service WHERE ServiceId = @ServiceId", conn);
                    durationCmd.Parameters.AddWithValue("@ServiceId", ServiceComboBox.SelectedValue);
                    int duration = 0; // Default duration value
                    object result = durationCmd.ExecuteScalar();
                    if (result != null && result != DBNull.Value)
                    {
                        duration = Convert.ToInt32(result);

                    }

                    DateTime startTime = StartTimePicker.Value;
                    MessageBox.Show("Duration: " + duration);
                    DateTime endTime = startTime.AddMinutes(duration);


                    SqlCommand cmd = new SqlCommand("INSERT INTO Appointment (PatientId, EquipmentId, StaffId, ServiceId, hasPriority, Date, StartTime, EndTime) " +
                                                    "VALUES (@PatientId, @EquipmentId, @StaffId, @ServiceId, @hasPriority, @Date, @StartTime, @EndTime)", conn);
                    cmd.Parameters.AddWithValue("@PatientId", PatientComboBox.SelectedValue);
                    cmd.Parameters.AddWithValue("@EquipmentId", EquipmentComboBox.SelectedValue);
                    cmd.Parameters.AddWithValue("@StaffId", (StaffComboBox.SelectedValue != null && !string.IsNullOrEmpty(StaffComboBox.SelectedValue.ToString())) ? StaffComboBox.SelectedValue : (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@ServiceId", ServiceComboBox.SelectedValue);
                    cmd.Parameters.AddWithValue("@hasPriority", PriorityCb.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@Date", AppointmentDatePicker.Value.Date);
                    cmd.Parameters.AddWithValue("@StartTime", StartTimePicker.Value);
                    cmd.Parameters.AddWithValue("@EndTime", endTime);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Appointment Saved!");
                    conn.Close();
                    UpdateEquipmentQuantity(int.Parse(EquipmentComboBox.SelectedValue.ToString()), -1);

                    conn.Close();

                    // Get the patient's email
                    string email = GetPatientEmail(int.Parse(PatientComboBox.SelectedValue.ToString()));


                    string appointmentId = GetLastAppointmentId().ToString(); // Get the last inserted appointment ID
                    string qrText = $"Appointment ID: {appointmentId}\nPatient: {PatientComboBox.Text}\nDate: {AppointmentDatePicker.Value.ToShortDateString()}\nStart Time: {StartTimePicker.Value.ToShortTimeString()}\nEnd Time: {endTime}";
                    QRCodeGenerator qrGenerator = new QRCodeGenerator();
                    QRCodeData qrCodeData = qrGenerator.CreateQrCode(qrText, QRCodeGenerator.ECCLevel.Q);
                    QRCode qrCode = new QRCode(qrCodeData);
                    Bitmap qrCodeImage = qrCode.GetGraphic(10);

                    byte[] qrCodeImageData;
                    using (MemoryStream ms = new MemoryStream())
                    {
                        qrCodeImage.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                        qrCodeImageData = ms.ToArray();
                    }
                    conn.Open();
                    SqlCommand qrCodeCmd = new SqlCommand("INSERT INTO QRCode (AppointmentId, QRCodeImage) VALUES (@AppointmentId, @QRCodeImage)", conn);
                    qrCodeCmd.Parameters.AddWithValue("@AppointmentId", appointmentId);
                    qrCodeCmd.Parameters.AddWithValue("@QRCodeImage", qrCodeImageData);
                    qrCodeCmd.ExecuteNonQuery();
                    MessageBox.Show("QR saved in db");


                    try
                    {
                        SmtpClient smtpServer = new SmtpClient();
                        MailMessage mail = new MailMessage();

                        smtpServer.EnableSsl = true;
                        smtpServer.UseDefaultCredentials = false;
                        smtpServer.Credentials = new NetworkCredential("jedinaxure14@gmail.com", "adkbuchvondbbjse");
                        smtpServer.Port = 587;
                        smtpServer.Host = "smtp.gmail.com";

                        mail.From = new MailAddress("jedinaxure14@gmail.com");
                        mail.To.Add(email);
                        mail.Subject = "Appointment details";
                        mail.IsBodyHtml = false;
                        string body = "Please find the appointment details and QR code attached.";
                        mail.Attachments.Add(new Attachment(new MemoryStream(ImageToByte(qrCodeImage)), "QRCode.png"));
                        mail.Body = body;

                        smtpServer.Send(mail);
                        MessageBox.Show("Mail Sent to patient.");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }


                    conn.Close();
                    ShowAppointments();
                    ResetForm();


                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    conn.Close();
                }
            }
        }
        private string GetPatientEmail(int patientId)
        {
            string email = string.Empty;
            conn.Open();
            string query = "SELECT Email FROM Patient WHERE PatientId = @PatientId";
            SqlCommand command = new SqlCommand(query, conn);
            command.Parameters.AddWithValue("@PatientId", patientId);
            SqlDataReader reader = command.ExecuteReader();

            if (reader.Read())
            {
                email = reader["Email"].ToString();
            }

            reader.Close();
            conn.Close();

            return email;
        }
        private int GetLastAppointmentId()
        {
            int lastAppointmentId = 0;
            conn.Open();
            string query = "SELECT TOP 1 AppointmentId FROM Appointment ORDER BY AppointmentId DESC";
            SqlCommand command = new SqlCommand(query, conn);
            SqlDataReader reader = command.ExecuteReader();

            if (reader.Read())
            {
                lastAppointmentId = int.Parse(reader["AppointmentId"].ToString());
            }

            reader.Close();
            conn.Close();

            return lastAppointmentId;
        }
        private byte[] ImageToByte(Image image)
        {
            using (MemoryStream stream = new MemoryStream())
            {
                image.Save(stream, System.Drawing.Imaging.ImageFormat.Png);
                return stream.ToArray();
            }
        }
        private int GetAppointmentEquipmentId(int appointmentId)
        {
            int equipmentId = 0;
            conn.Open();
            string query = "SELECT EquipmentId FROM Appointment WHERE AppointmentId = @AppointmentId";
            SqlCommand command = new SqlCommand(query, conn);
            command.Parameters.AddWithValue("@AppointmentId", appointmentId);
            SqlDataReader reader = command.ExecuteReader();

            if (reader.Read())
            {
                equipmentId = int.Parse(reader["EquipmentId"].ToString());
            }

            reader.Close();
            conn.Close();

            return equipmentId;
        }
        private void UpdateEquipmentQuantity(int equipmentId, int quantityChange)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("UPDATE Equipment SET Quantity = Quantity + @QuantityChange WHERE EquipmentId = @EquipmentId", conn);
            cmd.Parameters.AddWithValue("@QuantityChange", quantityChange);
            cmd.Parameters.AddWithValue("@EquipmentId", equipmentId);
            cmd.ExecuteNonQuery();
            conn.Close();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            string searchValue = SearchTb.Text;

            if (AppointmentDGV.DataSource is DataTable dataTable)
            {
                // Construct the row filter dynamically for all columns
                string rowFilter = string.Empty;
                foreach (DataColumn column in dataTable.Columns)
                {
                    if (!string.IsNullOrEmpty(rowFilter))
                        rowFilter += " OR ";
                    rowFilter += $"CONVERT([{column.ColumnName}], System.String) LIKE '%{searchValue}%'";
                }

                // Apply the row filter
                dataTable.DefaultView.RowFilter = rowFilter;

                // Clear the selection
                AppointmentDGV.ClearSelection();
            }


        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("UPDATE Appointment " +
                                                "SET PatientId = @PatientId, EquipmentId = @EquipmentId, StaffId = @StaffId, ServiceId = @ServiceId, " +
                                            "Date = @Date, StartTime = @StartTime, EndTime = @EndTime " +
                                                "WHERE AppointmentId = @AppointmentId", conn);
                cmd.Parameters.AddWithValue("@PatientId", PatientComboBox.SelectedValue);
                cmd.Parameters.AddWithValue("@EquipmentId", EquipmentComboBox.SelectedValue);
                cmd.Parameters.AddWithValue("@StaffId", (StaffComboBox.SelectedValue != null && !string.IsNullOrEmpty(StaffComboBox.SelectedValue.ToString())) ? StaffComboBox.SelectedValue : (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@ServiceId", ServiceComboBox.SelectedValue);
                cmd.Parameters.AddWithValue("@Date", AppointmentDatePicker.Value.Date);
                cmd.Parameters.AddWithValue("@StartTime", StartTimePicker.Value);
                cmd.Parameters.AddWithValue("@EndTime", EndTimePicker.Value);
                cmd.Parameters.AddWithValue("@AppointmentId", int.Parse(AppointmentDGV.CurrentRow.Cells["AppointmentId"].Value.ToString()));
                cmd.ExecuteNonQuery();
                MessageBox.Show("Appointment Updated!");
                conn.Close();

                // Get the patient's email
                string email = GetPatientEmail(int.Parse(PatientComboBox.SelectedValue.ToString()));

                int appointmentId = int.Parse(AppointmentDGV.CurrentRow.Cells["AppointmentId"].Value.ToString());

                string qrText = $"Appointment ID: {appointmentId}\nPatient: {PatientComboBox.Text}\nDate: {AppointmentDatePicker.Value.ToShortDateString()}\nStart Time: {StartTimePicker.Value.ToShortTimeString()}\nEnd Time: {EndTimePicker.Value.ToShortTimeString()}";
                QRCodeGenerator qrGenerator = new QRCodeGenerator();
                QRCodeData qrCodeData = qrGenerator.CreateQrCode(qrText, QRCodeGenerator.ECCLevel.Q);
                QRCode qrCode = new QRCode(qrCodeData);
                Bitmap qrCodeImage = qrCode.GetGraphic(10);

                try
                {
                    SmtpClient smtpServer = new SmtpClient();
                    MailMessage mail = new MailMessage();

                    smtpServer.EnableSsl = true;
                    smtpServer.UseDefaultCredentials = false;
                    smtpServer.Credentials = new NetworkCredential("jedinaxure14@gmail.com", "adkbuchvondbbjse");
                    smtpServer.Port = 587;
                    smtpServer.Host = "smtp.gmail.com";

                    mail.From = new MailAddress("jedinaxure14@gmail.com");
                    mail.To.Add(email);
                    mail.Subject = "Appointment details";
                    mail.IsBodyHtml = false;
                    string body = "Your appointment date has been changed, please find attached the details:\n";
                    body += $"Date: {AppointmentDatePicker.Value.ToShortDateString()}\n";
                    body += $"Start Time: {StartTimePicker.Value.ToShortTimeString()}\n";
                    mail.Attachments.Add(new Attachment(new MemoryStream(ImageToByte(qrCodeImage)), "QRCode.png"));
                    mail.Body = body;

                    smtpServer.Send(mail);
                    MessageBox.Show("Mail Sent to patient.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }

                conn.Close();
                ShowAppointments();
                ResetForm();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }

        }
        private void deleteBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (AppointmentDGV.SelectedRows.Count > 0)
                {
                    int appointmentId = int.Parse(AppointmentDGV.CurrentRow.Cells["AppointmentId"].Value.ToString());
                    int equipmentId = GetAppointmentEquipmentId(appointmentId);
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("DELETE FROM Appointment WHERE AppointmentId = @AppointmentId", conn);
                    cmd.Parameters.AddWithValue("@AppointmentId", appointmentId);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Appointment Deleted!");
                    conn.Close();
                    ShowAppointments();
                    ResetForm();
                    UpdateEquipmentQuantity(equipmentId, 1);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ResetForm()
        {
            PatientComboBox.SelectedIndex = -1;
            EquipmentComboBox.SelectedIndex = -1;
            StaffComboBox.SelectedIndex = -1;
            ServiceComboBox.SelectedIndex = -1;
            PriorityCb.SelectedItem = "No";
            AppointmentDatePicker.Value = DateTime.Now.Date;
            StartTimePicker.Value = DateTime.Now;
            // EndTimePicker.Value = DateTime.Now;
        }

        private void AppointmentDGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (AppointmentDGV.SelectedRows.Count > 0)
            {
                int appointmentId = int.Parse(AppointmentDGV.CurrentRow.Cells["AppointmentId"].Value.ToString());
                conn.Open();
                string query = "SELECT a.PatientId, a.EquipmentId, a.StaffId, a.ServiceId, a.hasPriority, a.Date, a.StartTime, a.EndTime " +
                               "FROM Appointment a " +
                               "WHERE a.AppointmentId = @AppointmentId";
                SqlCommand command = new SqlCommand(query, conn);
                command.Parameters.AddWithValue("@AppointmentId", appointmentId);
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    PatientComboBox.SelectedValue = int.Parse(reader["PatientId"].ToString());
                    PatientComboBox.Enabled = false;
                    EquipmentComboBox.SelectedValue = int.Parse(reader["EquipmentId"].ToString());
                    EquipmentComboBox.Enabled = false;
                    StaffComboBox.SelectedValue = int.Parse(reader["StaffId"].ToString());
                    StaffComboBox.Enabled = false;
                    ServiceComboBox.SelectedValue = int.Parse(reader["ServiceId"].ToString());
                    ServiceComboBox.Enabled = false;
                    PriorityCb.Text = reader["hasPriority"].ToString();
                    PriorityCb.Enabled = false;
                    AppointmentDatePicker.Value = Convert.ToDateTime(reader["Date"]);
                    StartTimePicker.Value = Convert.ToDateTime(reader["StartTime"]);
                    // EndTimePicker.Value = Convert.ToDateTime(reader["EndTime"]);
                }

                reader.Close();
                conn.Close();
            }


        }


        private void SaveToExcel(DataGridView dataGridView)
        {
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;

            // Create a new Excel package
            using (ExcelPackage package = new ExcelPackage())
            {
                // Create a new worksheet
                ExcelWorksheet worksheet = package.Workbook.Worksheets.Add("Sheet1");

                // Write the column headers
                for (int col = 0; col < dataGridView.Columns.Count; col++)
                {
                    worksheet.Cells[1, col + 1].Value = dataGridView.Columns[col].HeaderText;
                }

                // Write the data rows
                for (int row = 0; row < dataGridView.Rows.Count; row++)
                {
                    for (int col = 0; col < dataGridView.Columns.Count; col++)
                    {
                        worksheet.Cells[row + 2, col + 1].Value = dataGridView.Rows[row].Cells[col].Value;
                    }
                }

                using (FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog())
                {
                    folderBrowserDialog.Description = "Select Folder to Save Excel File";

                    // Display the FolderBrowserDialog and get the selected folder path
                    DialogResult dialogResult = folderBrowserDialog.ShowDialog();

                    // Check if the user clicked the OK button
                    if (dialogResult == DialogResult.OK)
                    {
                        string folderPath = folderBrowserDialog.SelectedPath;
                        string filePath = Path.Combine(folderPath, "data.xlsx");

                        // Save the Excel package to the selected file path
                        File.WriteAllBytes(filePath, package.GetAsByteArray());

                        // Show a success message
                        MessageBox.Show("File saved successfully.");
                    }
                }
            }

        }
        private void displayQr_Click(object sender, EventArgs e)
        {
            if (AppointmentDGV.SelectedRows.Count > 0)
            {
                int appointmentId = int.Parse(AppointmentDGV.CurrentRow.Cells["AppointmentId"].Value.ToString());
                byte[] qrCodeData = GetQRCodeData(appointmentId);
                if (qrCodeData != null)
                {
                    Image qrCodeImage = ConvertByteArrayToImage(qrCodeData);
                    pictureBox.Image = qrCodeImage;
                }
                else
                {
                    MessageBox.Show("QR Code data not found for the selected appointment.");
                }
            }
        }

        private void Appointment_Load(object sender, EventArgs e)
        {
            int roleId = Role.RoleId;


            conn.Open();

            // Enable or disable buttons based on the role
            if (roleId == 1)
            {
                StaffBtn.Enabled = true;
                AppointmentBtn.Enabled = true;
                PatientBtn.Enabled = true;
                ServicesBtn.Enabled = true;
                EquipmentBtn.Enabled = true;


            }

            else if (roleId == 2)
            {
                AppointmentBtn.Enabled = true;

            }

            else if (roleId == 3)
            {
                AppointmentBtn.Enabled = true;
                PatientBtn.Enabled = true;
            }
            conn.Close();
        }

        private void PatientBtn_Click(object sender, EventArgs e)
        {
            Patient patientForm = new Patient();
            patientForm.Show();
            this.Hide();

        }

        private void StaffBtn_Click(object sender, EventArgs e)
        {

            Staff staffForm = new Staff();
            staffForm.Show();
            this.Hide();
        }

        private void ServicesBtn_Click(object sender, EventArgs e)
        {

            Services serviceForm = new Services();
            serviceForm.Show();
            this.Hide();
        }

        private void AppointmentBtn_Click(object sender, EventArgs e)
        {
            this.Show();
        }

        private void EquipmentBtn_Click(object sender, EventArgs e)
        {

            Equipments equipmentForm = new Equipments();
            equipmentForm.Show();
            this.Hide();
        }

        private void LogoutBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            Login loginForm = new Login();
            loginForm.Show();
        }

        private void Save_Click(object sender, EventArgs e)
        {
            SaveToExcel(AppointmentDGV);
        }
        private byte[] GetQRCodeData(int appointmentId)
        {
            conn.Open();
            string query = "SELECT QRCodeImage FROM QRCode WHERE AppointmentId = @AppointmentId";
            SqlCommand command = new SqlCommand(query, conn);
            command.Parameters.AddWithValue("@AppointmentId", appointmentId);
            byte[] qrCodeData = (byte[])command.ExecuteScalar();
            conn.Close();
            return qrCodeData;
        }
        private Image ConvertByteArrayToImage(byte[] byteArray)
        {
            using (MemoryStream memoryStream = new MemoryStream(byteArray))
            {
                return Image.FromStream(memoryStream);

            }

        }
    }





}

    


       

        
   