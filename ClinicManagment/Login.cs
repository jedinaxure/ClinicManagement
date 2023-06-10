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


namespace ClinicManagment
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }
        private void label4_Click(object sender, EventArgs e)
        {

        }
        private void label4_Click_1(object sender, EventArgs e)
        {
        }

        SqlConnection conn = new SqlConnection(@"Data Source=.\SQLEXPRESS; Initial Catalog=HospitalManagement; integrated security=SSPI;");
       

        private void loginBtn_Click(object sender, EventArgs e)
        {
            string username, user_password;
            username = textUsername.Text;
            user_password = textPassword.Text;

           
            {
                try
                {
                    conn.Open();
                    String Query = "SELECT * FROM UserAccount WHERE username = '" + textUsername.Text + "' AND password = '" + textPassword.Text + "'";
                    SqlCommand command = new SqlCommand(Query, conn);
                    SqlDataAdapter sda = new SqlDataAdapter(command);
                    DataTable dt = new DataTable();

                    sda.Fill(dt);

                    if (dt.Rows.Count > 0)
                    {
                        int roleId = Convert.ToInt32(dt.Rows[0]["roleId"]);
                        Role.RoleId = roleId;

                        switch (roleId)
                        {
                            case 1: // Admin
                                Staff staff = new Staff();
                                staff.Show();
                                break;
                            case 2: // Doctor
                                Appointment appointment = new Appointment();
                                appointment.Show();
                                break;
                            case 3: // Receptionist
                                Appointment appointment1  = new Appointment();
                                appointment1.Show();
                                break;
                            default:
                                MessageBox.Show("Invalid role ID");
                                break;
                        }

                        this.Hide();
                    }
                    else
                        MessageBox.Show("Invalid Login details", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textUsername.Clear();
                    textPassword.Clear();
                }
                catch(Exception ex) 
                {
                    //MessageBox.Show("Login not valid!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    MessageBox.Show(ex.Message);
                }
                finally
                { 
                    conn.Close(); 
                }
            }
           
        }
    }
}
