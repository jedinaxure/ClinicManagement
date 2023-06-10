using System;
using System.Collections;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace ClinicManagment
{
    public partial class Patient : Form
    {
        public Patient()
        {
            InitializeComponent();
            ShowPatient();
        }

        SqlConnection conn = new SqlConnection(@"Data Source=.\SQLEXPRESS; Initial Catalog=HospitalManagement; integrated security=SSPI;");
        private void ShowPatient()
        {
            conn.Open();
            string Query = "Select  * from Patient";
           // SqlDataAdapter sda = new SqlDataAdapter();
            SqlCommand command = new SqlCommand(Query, conn);
            SqlDataAdapter sda = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            PatientDGV.DataSource = dt;
            conn.Close();
        }
        private void saveBtn_Click(object sender, EventArgs e)
{
    if (Name.Text == "" || Email.Text == "" || Phone.Text == "" || Address.Text == "" || Gender.SelectedIndex == -1)
    {
        MessageBox.Show("Missing Information");
    }
    else
    {
        try
        {
            conn.Open();
            
            // check if a patient with the same dob exists
            SqlCommand checkCommand = new SqlCommand("SELECT COUNT(*) FROM Patient WHERE Name = @Name AND DateOfBirth = @DOB", conn);
                    checkCommand.Parameters.AddWithValue("@Name", Name.Text);
                    checkCommand.Parameters.AddWithValue("@DOB", PatientDOB.Value.Date);
                    int existingPatientCount = (int)checkCommand.ExecuteScalar();
           
            if (existingPatientCount > 0)
            {
               
                var result = MessageBox.Show("A patient with the same name and date of birth already exists. Do you want to update the existing patient's information?", "Duplicate Patient", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                
                if (result == DialogResult.Yes)
                {
                            // update information
                            SqlCommand updateCommand = new SqlCommand("UPDATE Patient SET Gender=@PG, Phone=@PP, Email=@PE, Address= @PA WHERE Name=@Name AND DateOfBirth=@DOB", conn);
                            updateCommand.Parameters.AddWithValue("@PG", Gender.SelectedItem.ToString());
                            updateCommand.Parameters.AddWithValue("@PP", Phone.Text);
                            updateCommand.Parameters.AddWithValue("@PE", Email.Text);
                            updateCommand.Parameters.AddWithValue("@PA", Address.Text);
                            updateCommand.Parameters.AddWithValue("@Name", Name.Text);
                            updateCommand.Parameters.AddWithValue("@DOB", PatientDOB.Value.Date);
                            updateCommand.ExecuteNonQuery();
                            MessageBox.Show("Patient information updated!");
                        }
                else
                {
                            // not register patient
                            // MessageBox.Show("Patient not registered.");
                            SqlCommand cmd = new SqlCommand("INSERT INTO Patient (Name, Gender, DateOfBirth, Phone, Email, Address) VALUES (@PN, @PG, @PB, @PP, @PE, @PA)", conn);
                            cmd.Parameters.AddWithValue("@PN", Name.Text);
                            cmd.Parameters.AddWithValue("@PG", Gender.SelectedItem.ToString());
                            cmd.Parameters.AddWithValue("@PB", PatientDOB.Value.Date);
                            cmd.Parameters.AddWithValue("@PP", Phone.Text);
                            cmd.Parameters.AddWithValue("@PE", Email.Text);
                            cmd.Parameters.AddWithValue("@PA", Address.Text);
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Patient Saved!");
                        }
            }
            else
            {
                // No existing patient with the same dob, register the new patient
                SqlCommand cmd = new SqlCommand("INSERT INTO Patient (Name, Gender, DateOfBirth, Phone, Email, Address) VALUES (@PN, @PG, @PB, @PP, @PE, @PA)", conn);
                cmd.Parameters.AddWithValue("@PN", Name.Text);
                cmd.Parameters.AddWithValue("@PG", Gender.SelectedItem.ToString());
                cmd.Parameters.AddWithValue("@PB", PatientDOB.Value.Date);
                cmd.Parameters.AddWithValue("@PP", Phone.Text);
                cmd.Parameters.AddWithValue("@PE", Email.Text);
                cmd.Parameters.AddWithValue("@PA", Address.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Patient Saved!");
            }
            
            conn.Close();
            ShowPatient();
            reset();
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message);
        }
    }
}

        private void editBtn_Click(object sender, EventArgs e)
        {
            if (Name.Text == "" || Email.Text == "" || Phone.Text == "" || Address.Text == "" || Gender.SelectedIndex == -1)
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("UPDATE Patient set Name=@PN, Gender=@PG, DateOfBirth=@PB, Phone=@PP, Email=@PE, Address= @PA where PatientId=@PKey",conn);
                    cmd.Parameters.AddWithValue("@PN", Name.Text);
                    cmd.Parameters.AddWithValue("@PG", Gender.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@PB", PatientDOB.Value.Date);
                    cmd.Parameters.AddWithValue("@PP", Phone.Text);
                    cmd.Parameters.AddWithValue("@PE", Email.Text);
                    cmd.Parameters.AddWithValue("@PA", Address.Text);
                    cmd.Parameters.AddWithValue("@PKey", Key);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Patient Updated!");
                    conn.Close();
                    ShowPatient();
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
            Name.Text = "";
            Gender.SelectedIndex = -1;
            Phone.Text = "";
            Email.Text = "";
            Address.Text = "";
            Key = 0;
        }
        int Key = 0;

        private void PatientDGV_CellClick(object sender, DataGridViewCellEventArgs e)
        { 
            Name.Text = PatientDGV.SelectedRows[0].Cells[1].Value.ToString();
            Gender.SelectedItem = PatientDGV.SelectedRows[0].Cells[2].Value.ToString();
            PatientDOB.Text = PatientDGV.SelectedRows[0].Cells[3].Value.ToString();
            Phone.Text = PatientDGV.SelectedRows[0].Cells[4].Value.ToString();
            Email.Text = PatientDGV.SelectedRows[0].Cells[5].Value.ToString();
            Address.Text = PatientDGV.SelectedRows[0].Cells[6].Value.ToString();
            if(Name.Text == "")
            {
                Key = 0;
            }
            else {
                Key = Convert.ToInt32(PatientDGV.SelectedRows[0].Cells[0].Value.ToString());
            }

        }
        private void deleteBtn_Click(object sender, EventArgs e)
        {
            if(Key == 0)
            {
                MessageBox.Show("Select a patient");
            }
            else
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("DELETE FROM Patient where PatientId=@Pkey" , conn);
                    
                    cmd.Parameters.AddWithValue("@PKey", Key);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Patient Deleted!");
                    conn.Close();
                    ShowPatient();
                    reset();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                
            }
        }

        



        private void Patient_Load(object sender, EventArgs e)
        {
            int roleId = Role.RoleId;


            conn.Open();

            // Enable or disable buttons based on the role
            if (roleId == 1)
            {
                StaffBtn.Enabled = true;
                AppointmentBtn.Enabled = true;
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


        private void button1_Click(object sender, EventArgs e)
        {
            this.Show();
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
            Appointment AppointmentForm = new Appointment();
            AppointmentForm.Show();
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
    

