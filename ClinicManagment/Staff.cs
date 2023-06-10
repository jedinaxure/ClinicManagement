using System.Data;
using System.Data.SqlClient;
using System.Net;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Net.Mail;

namespace ClinicManagment
{
    public partial class Staff : Form
    {
        public Staff()
        {
            InitializeComponent();
            LoadRoles();
            ShowStaff();
        }

        

        SqlConnection conn = new SqlConnection(@"Data Source=.\SQLEXPRESS; Initial Catalog=HospitalManagement; integrated security=SSPI;");
       
       

        private void ShowStaff()
        {
            conn.Open();
            string query = "SELECT s.StaffId, r.Name AS RoleName, s.Name, s.DateOfBirth, s.Gender, s.Phone, s.Email, s.Address " +
                           "FROM Staff s " +
                           "INNER JOIN Role r ON s.RoleId = r.RoleId";
            SqlCommand command = new SqlCommand(query, conn);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            StaffDGV.DataSource = dt;
            conn.Close();
        }
       
        private void LoadRoles()
        {
            conn.Open();
            string query = "SELECT RoleId, Name FROM Role";
            SqlCommand command = new SqlCommand(query, conn);
            SqlDataReader reader = command.ExecuteReader();
            DataTable dtRoles = new DataTable();
            dtRoles.Load(reader);
            PositionCb.DataSource = dtRoles;
            PositionCb.DisplayMember = "Name";
            PositionCb.ValueMember = "RoleId";
            conn.Close();

        }


        private void saveBtn_Click(object sender, EventArgs e)
        {
            if (StaffName.Text == "" || GenderCb.SelectedIndex == -1 || StaffPhone.Text == "" || StaffEmail.Text == "" || StaffAddress.Text == "" || PositionCb.SelectedIndex == -1)
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
               int index = Convert.ToInt32(PositionCb.SelectedIndex)+1;
               MessageBox.Show("" + index);
                try
                {

                    conn.Open();
                    SqlCommand cmd = new SqlCommand("INSERT INTO Staff (RoleId, Name, DateOfBirth, Gender, Phone, Email, Address) " +
                                                    "VALUES (@RoleId, @Name, @DateOfBirth, @Gender, @Phone, @Email, @Address); SELECT SCOPE_IDENTITY();", conn);
                    cmd.Parameters.AddWithValue("@RoleId", index);
                    cmd.Parameters.AddWithValue("@Name", StaffName.Text);
                    cmd.Parameters.AddWithValue("@DateOfBirth", StaffDOB.Value.Date);
                    cmd.Parameters.AddWithValue("@Gender", GenderCb.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@Phone", StaffPhone.Text);
                    cmd.Parameters.AddWithValue("@Email", StaffEmail.Text);
                    cmd.Parameters.AddWithValue("@Address", StaffAddress.Text);

                    cmd.ExecuteNonQuery();

                    // Generate username and password
                    string username = StaffName.Text.ToLower();
                    string password = GenerateRandomPassword();
                    // RoleId = PositionCb.Text.ToString();

                    // Insert the username and password into the UserAccount table
                    SqlCommand userAccountCmd = new SqlCommand("INSERT INTO UserAccount (Username, Password, RoleId) VALUES (@Username, @Password, @RoleId)", conn);
                    userAccountCmd.Parameters.AddWithValue("@Username", username);
                    userAccountCmd.Parameters.AddWithValue("@Password", password);
                    userAccountCmd.Parameters.AddWithValue("@RoleId", index);
                    userAccountCmd.ExecuteNonQuery();
                    string email = StaffEmail.Text;

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
                        mail.To.Add(StaffEmail.Text);
                        mail.Subject = "";
                        mail.IsBodyHtml = false;
                        string body = "Your credentials" + Environment.NewLine +
                                      "Username: " + username + Environment.NewLine +
                                      "Password: " + password + Environment.NewLine;
                        mail.Body = body;

                        smtpServer.Send(mail);
                        MessageBox.Show("Mail Sent to patient.");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }


                    MessageBox.Show("Staff Member Saved!");
                    conn.Close();
                    ShowStaff();
                    ResetForm();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            if (StaffName.Text == "" || GenderCb.SelectedIndex == -1 || StaffPhone.Text == "" || StaffEmail.Text == "" || StaffAddress.Text == "" || PositionCb.SelectedIndex == -1)
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("UPDATE Staff SET RoleId = @RoleId, Name = @Name, DateOfBirth = @DateOfBirth, " +
                                                    "Gender = @Gender, Phone = @Phone, Email = @Email, Address = @Address " +
                                                    "WHERE StaffId = @StaffId", conn);
                    cmd.Parameters.AddWithValue("@RoleId", PositionCb.SelectedValue);
                    cmd.Parameters.AddWithValue("@Name", StaffName.Text);
                    cmd.Parameters.AddWithValue("@DateOfBirth", StaffDOB.Value.Date);
                    cmd.Parameters.AddWithValue("@Gender", GenderCb.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@Phone", StaffPhone.Text);
                    cmd.Parameters.AddWithValue("@Email", StaffEmail.Text);
                    cmd.Parameters.AddWithValue("@Address", StaffAddress.Text);
                    cmd.Parameters.AddWithValue("@StaffId", Key);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Staff Member Updated!");
                    conn.Close();
                    ShowStaff();
                    ResetForm();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        int Key = 0;

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            if (Key == 0)
            {
                MessageBox.Show("Select a staff member");
            }
            else
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("DELETE FROM Staff WHERE StaffId = @StaffId", conn);
                    cmd.Parameters.AddWithValue("@StaffId", Key);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Staff Member Deleted!");
                    conn.Close();
                    ShowStaff();
                    ResetForm();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

        }
        private void ResetForm()
        {
            StaffName.Text = "";
            GenderCb.SelectedIndex = -1;
            StaffPhone.Text = "";
            StaffEmail.Text = "";
            StaffAddress.Text = "";
            PositionCb.SelectedIndex = -1;
            Key = 0;
        }

        private string GenerateRandomPassword()
        {
            const string validChars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890";
            StringBuilder password = new StringBuilder();
            using (RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider())
            {
                byte[] uintBuffer = new byte[sizeof(uint)];

                while (password.Length < 8)
                {
                    rng.GetBytes(uintBuffer);
                    uint num = BitConverter.ToUInt32(uintBuffer, 0);
                    password.Append(validChars[(int)(num % (uint)validChars.Length)]);
                }
            }

            return password.ToString();
        }

        private void StaffDGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = StaffDGV.Rows[e.RowIndex];
                Key = Convert.ToInt32(row.Cells["StaffId"].Value);
                StaffName.Text = row.Cells["Name"].Value.ToString();
                GenderCb.SelectedItem = row.Cells["Gender"].Value.ToString();
                StaffDOB.Value = Convert.ToDateTime(row.Cells["DateOfBirth"].Value);
                StaffPhone.Text = row.Cells["Phone"].Value.ToString();
                StaffEmail.Text = row.Cells["Email"].Value.ToString();
                StaffAddress.Text = row.Cells["Address"].Value.ToString();
                PositionCb.Text = row.Cells["RoleName"].Value.ToString();
            }
        }

        
            private void PatientBtn_Click(object sender, EventArgs e)
            {
                Patient patientForm = new Patient();
                patientForm.Show();
                this.Hide();

            }

            private void StaffBtn_Click(object sender, EventArgs e)
            {
                this.Show();
            }

            private void ServicesBtn_Click(object sender, EventArgs e)
            {

            Services serviceForm = new Services();
            serviceForm.Show();
            this.Hide();
        }

            private void AppointmentBtn_Click(object sender, EventArgs e)
            {
            Appointment appointmentForm = new Appointment();
            appointmentForm.Show();
            this.Hide();
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


        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }
        private void Form1_Load(object sender, EventArgs e)
        {
        }
    }
    }

       
    
   
