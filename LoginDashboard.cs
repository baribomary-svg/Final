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

namespace FinalProject
{
    public partial class LoginDashboard : Form
    {
        public LoginDashboard()
        {
            InitializeComponent();
        }

       
        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            string username = txtUserName.Text;
            string password = txtPassword.Text;
            string role = cmbRole.Text;

            if (username == "Admin" && password == "123" && role == "Admin")
            {
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

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }
    }
}

    