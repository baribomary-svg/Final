
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
    public partial class LogIn : Form
    {
        private bool isPasswordVisible = false;
        private bool isConfirmVisible = false;


        string connectionString =
            ConfigurationManager.ConnectionStrings["DB_FinalsProj"].ConnectionString;
        public LogIn()
        {

            InitializeComponent();

            txtPassword.UseSystemPasswordChar = true;
            txtConfirm.UseSystemPasswordChar = true;

            // Default button text
            btnTogglePassword.Text = "🚫👁";
            btnToggleConfirm.Text = "🚫👁";

        }


        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    string query =
                        "INSERT INTO Users " +
                        "(first_name, last_name, email, username, password, role) " +
                        "OUTPUT INSERTED.user_ID " +
                        "VALUES (@fname, @lname, @email, @username, @password, @role)";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@fname", txtFirstName.Text);
                    cmd.Parameters.AddWithValue("@lname", txtLastName.Text);
                    cmd.Parameters.AddWithValue("@email", txtEmail.Text);
                    cmd.Parameters.AddWithValue("@username", txtUserName.Text);
                    cmd.Parameters.AddWithValue("@password", txtPassword.Text);
                    cmd.Parameters.AddWithValue("@role", "Customer");

                    int generatedID = Convert.ToInt32(cmd.ExecuteScalar());
                    string formattedID = "USR-" + generatedID.ToString("D3");

                    MessageBox.Show("Registered Successfully!\n\nUser ID: " + formattedID);

                    SignIn signin = new SignIn();
                    signin.Show();
                    this.Hide();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void lblSignIn_Click(object sender, EventArgs e)
        {
          
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
        }

        private void lblSignIn_Click_1(object sender, EventArgs e)
        {
            SignIn signin = new SignIn();
            signin.Show();
            this.Hide();
        }

        private void btnTogglePassword_Click(object sender, EventArgs e)
        {
            isPasswordVisible = !isPasswordVisible;

            txtPassword.UseSystemPasswordChar = !isPasswordVisible;

            if (isPasswordVisible)
            {
                btnTogglePassword.Text = "👁";
            }
            else
            {
                btnTogglePassword.Text = "🚫👁";
            }
        }

        private void btnToggleConfirm_Click(object sender, EventArgs e)
        {
            isConfirmVisible = !isConfirmVisible;

            txtConfirm.UseSystemPasswordChar = !isConfirmVisible;

            if (isConfirmVisible)
            {
                btnToggleConfirm.Text = "👁";
            }
            else
            {
                btnToggleConfirm.Text = "🚫👁";
            }
        }
    }
}
    
    