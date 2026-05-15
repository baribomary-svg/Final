
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Data.SqlClient;
using System.Configuration;

namespace FinalProject
{
    public partial class LoginDashboard : Form
    {
        string connectionString =
            ConfigurationManager.ConnectionStrings["DB_FinalsProj"].ConnectionString;
        public LoginDashboard()
        {

            InitializeComponent();


        }


        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            SignIn register = new SignIn();
            register.Show();
            this.Hide();

            try
            {
                using (SqlConnection conn =
                    new SqlConnection(connectionString))
                {
                    conn.Open();

                    string query =
                    "INSERT INTO Users " +
                    "(first_name, last_name, email, username, password, role) " +
                    "OUTPUT INSERTED.user_ID " +
                    "VALUES (@fname, @lname, @email, @username, @password, @role)";

                    SqlCommand cmd =
                        new SqlCommand(query, conn);

                    cmd.Parameters.AddWithValue("@fname", txtFirstName.Text);
                    cmd.Parameters.AddWithValue("@lname", txtLastName.Text);
                    cmd.Parameters.AddWithValue("@email", txtEmail.Text);
                    cmd.Parameters.AddWithValue("@username", txtUserName.Text);
                    cmd.Parameters.AddWithValue("@password", txtPassword.Text);
                    cmd.Parameters.AddWithValue("@role", "Customer");

                    int generatedID =
                        Convert.ToInt32(cmd.ExecuteScalar());
                new AdminDashboard().Show();
                this.Hide();
            }
            else if (role == "Cashier" || role == "Staff")
            {
                new CashierDashboard().Show();
                this.Hide();
            }
            else if (role == "Technician")
            {
                new TechnicianDashboard().Show();
                this.Hide();
            }
            else if (role == "Customer")
            {
                new CustomerDashboard().Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid Login");
            }

        }

                    string formattedID =
                        "USR-" + generatedID.ToString("D3");

                    MessageBox.Show(
                        "Registered Successfully!\n\nUser ID: "
                        + formattedID);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void lblSignIn_Click(object sender, EventArgs e)
        {
            SignIn signin = new SignIn();
            signin.Show();
            this.Hide();

        private void pictureBox1_Click(object sender, EventArgs e)
        {
        }
    }
    }