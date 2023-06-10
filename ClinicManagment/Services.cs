using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace ClinicManagment
{
    public partial class Services : Form
    {
        public Services()
        {
            InitializeComponent();
            ShowServices();
        }

        SqlConnection conn = new SqlConnection(@"Data Source=.\SQLEXPRESS; Initial Catalog=HospitalManagement; integrated security=SSPI;");
        private void saveBtn_Click(object sender, EventArgs e)
        {
            if (SName.Text == "" || (int)SDuration.Value == null )
            {
                MessageBox.Show("Missing Information");
            }

            else
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("INSERT INTO Service (Name, Duration, Description) VALUES (@SN,@SD, @dscp)", conn);
                    cmd.Parameters.AddWithValue("@SN", SName.Text);
                    cmd.Parameters.AddWithValue("@SD", (int)SDuration.Value);
                    cmd.Parameters.AddWithValue("@dscp", "Not mandatory");

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Service Saved!");
                    conn.Close();
                    ShowServices();
                    reset();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        private void ShowServices()
        {
            conn.Open();
            string Query = "Select  * from Service";
            // SqlDataAdapter sda = new SqlDataAdapter();
            SqlCommand command = new SqlCommand(Query, conn);
            SqlDataAdapter sda = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            ServicesDGV.DataSource = dt;
            conn.Close();
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            if (SName.Text == "" || (int)SDuration.Value == null)
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("UPDATE Service set Name=@SN, Duration=@SD where ServiceId=@EKey", conn);
                    cmd.Parameters.AddWithValue("@SN", SName.Text);
                    cmd.Parameters.AddWithValue("@SD", (int)SDuration.Value);
                    cmd.Parameters.AddWithValue("@EKey", Key);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Service Updated!");
                    conn.Close();
                    ShowServices();
                    reset();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
        }

        private void reset()
        {
            SName.Text = "";
            SDuration.Text = "";
            Key = 0;
        }
        int Key = 0;
        private void deleteBtn_Click(object sender, EventArgs e)
        {
            if (Key == 0)
            {
                MessageBox.Show("Select a service");
            }
            else
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("DELETE FROM Service where ServiceId=@Pkey", conn);

                    cmd.Parameters.AddWithValue("@PKey", Key);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Service Deleted!");
                    conn.Close();
                    ShowServices();
                    reset();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    conn.Close();
                }
            }
        }

        private void ServicesDGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            SName.Text = ServicesDGV.SelectedRows[0].Cells[1].Value.ToString();
            if (int.TryParse(ServicesDGV.SelectedRows[0].Cells[3].Value.ToString(), out int duration))
            {
                SDuration.Value = duration;
            }
            else
            {
                SDuration.Text = string.Empty;
            }

            if (SName.Text == "")
            {
                Key = 0;
            }
            else
            {
                Key = Convert.ToInt32(ServicesDGV.SelectedRows[0].Cells[0].Value.ToString());
            }
        }



        private void Services_Load(object sender, EventArgs e)
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
            this.Show();
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
    }
}
