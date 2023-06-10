using System.Data;
using System.Data.SqlClient;

namespace ClinicManagment
{
    public partial class Equipments : Form
    {
        public Equipments()
        {
            InitializeComponent();
            ShowEquipment();
        }

        SqlConnection conn = new SqlConnection(@"Data Source=.\SQLEXPRESS; Initial Catalog=HospitalManagement; integrated security=SSPI;");
        private void ShowEquipment()
        {
            conn.Open();
            string Query = "Select  * from Equipment";
            // SqlDataAdapter sda = new SqlDataAdapter();
            SqlCommand command = new SqlCommand(Query, conn);
            SqlDataAdapter sda = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            EquipmentsDGV.DataSource = dt;
            conn.Close();
        }

        private void saveBtn_Click(object sender, EventArgs e)
{
    if (EqName.Text == "" || EqQuantity.Text == "" || EqDesciption.Text == "")
    {
        MessageBox.Show("Missing Information");
    }
    else
    {
        try
        {
            conn.Open();

            // Check if the equipment with the same name already exists
            SqlCommand checkCmd = new SqlCommand("SELECT COUNT(*) FROM Equipment WHERE Name = @EN", conn);
            checkCmd.Parameters.AddWithValue("@EN", EqName.Text);
            int count = Convert.ToInt32(checkCmd.ExecuteScalar());

            if (count > 0)
            {
                // Update the quantity
                SqlCommand updateCmd = new SqlCommand("UPDATE Equipment SET Quantity = Quantity + @EQ WHERE Name = @EN", conn);
                updateCmd.Parameters.AddWithValue("@EQ", Convert.ToInt32(EqQuantity.Text));
                updateCmd.Parameters.AddWithValue("@EN", EqName.Text);
                updateCmd.ExecuteNonQuery();
                MessageBox.Show("Equipment quantity updated!");
            }
            else
            {
                // Insert a new record
                SqlCommand insertCmd = new SqlCommand("INSERT INTO Equipment (Name, Quantity, Description) VALUES (@EN, @EQ, @ED)", conn);
                insertCmd.Parameters.AddWithValue("@EN", EqName.Text);
                insertCmd.Parameters.AddWithValue("@EQ", Convert.ToInt32(EqQuantity.Text));
                insertCmd.Parameters.AddWithValue("@ED", EqDesciption.Text);
                insertCmd.ExecuteNonQuery();
                MessageBox.Show("Equipment Saved!");
            }

            conn.Close();
            ShowEquipment();
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
            
                if (EqName.Text == "" || EqQuantity.Text == "" || EqDesciption.Text == "" )
                {
                    MessageBox.Show("Missing Information");
                }
                else
                {
                    try
                    {
                    conn.Open();
                        SqlCommand cmd = new SqlCommand("UPDATE Equipment set Name=@EN, Quantity=@EQ, Description=@ED where EquipmentId=@EKey", conn);
                        cmd.Parameters.AddWithValue("@EN", EqName.Text);
                        cmd.Parameters.AddWithValue("@EQ", Convert.ToInt32(EqQuantity.Text));
                        cmd.Parameters.AddWithValue("@ED", EqDesciption.Text);
                    cmd.Parameters.AddWithValue("@EKey", Key);
                    cmd.ExecuteNonQuery();
                        MessageBox.Show("Equipment Updated!");
                        conn.Close();
                        ShowEquipment();
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
            EqName.Text = "";
            EqQuantity.Text = "";
            EqDesciption.Text = "";
            Key = 0;
        }
        int Key = 0;

        private void EquipmentsDGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            EqName.Text = EquipmentsDGV.SelectedRows[0].Cells[1].Value.ToString();
            EqQuantity.Text = EquipmentsDGV.SelectedRows[0].Cells[2].Value.ToString();
            EqDesciption.Text = EquipmentsDGV.SelectedRows[0].Cells[3].Value.ToString();

            if (EqName.Text == "")
            {
                Key = 0;
            }
            else
            {
                Key = Convert.ToInt32(EquipmentsDGV.SelectedRows[0].Cells[0].Value.ToString());
            }
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            if (Key == 0)
            {
                MessageBox.Show("Select an equipment");
            }
            else
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("DELETE FROM Equipment where EquipmentId=@Pkey", conn);

                    cmd.Parameters.AddWithValue("@PKey", Key);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Equipment Deleted!");
                    conn.Close();
                    ShowEquipment();
                    reset();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }


        private void Equipments_Load(object sender, EventArgs e)
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




        private void label8_Click(object sender, EventArgs e)
        {

        }

       

        private void label9_Click(object sender, EventArgs e)
        {

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
            Appointment appointmentForm = new Appointment();
            appointmentForm.Show();
            this.Hide();
        }

        private void EquipmentBtn_Click(object sender, EventArgs e)
        {
            this.Show();
        }

        private void LogoutBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            Login loginForm = new Login();
            loginForm.Show();
        }
    }
}
