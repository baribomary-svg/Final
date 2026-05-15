using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject
{
    public partial class SignIn : Form
    {
        public SignIn()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = txtUserName.Text;
            string password = txtPassword.Text;
            string role = cmbRole.Text;

            if (username == "admin" && password == "123" && role == "Admin")
            {
                MessageBox.Show("Admin Login Successful");

                AdminDashboard admin = new AdminDashboard();
                admin.Show();
                this.Hide();
            }

          
            else if (username == "cashier" && password == "123" && role == "Cashier")
            {
                MessageBox.Show("Cashier Login Successful");

                CashierDashboard cashier = new CashierDashboard();
                cashier.Show();
                this.Hide();
            }

           
            else if (username == "technician" && password == "123" && role == "Technician")
            {
                MessageBox.Show("Technician Login Successful");

                TechnicianDashboard tech = new TechnicianDashboard();
                tech.Show();
                this.Hide();
            }

            else
            {
                MessageBox.Show("Invalid Username, Password, or Role");
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void SignIn_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {
            LoginDashboard signup = new LoginDashboard();
            signup.Show();
            this.Hide();
        }
    }
    }

