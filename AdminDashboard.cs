
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
    public partial class AdminDashboard : Form
    {
        public AdminDashboard()
        {
            InitializeComponent();

            btnDashboard.MouseEnter += (s, e) => ((Button)s).BackColor = Color.OliveDrab;
            btnDashboard.MouseLeave += (s, e) => ((Button)s).BackColor = Color.DarkGreen;
            btnDashboard.MouseDown += (s, e) => ((Button)s).BackColor = Color.FromArgb(40, 90, 40);
            btnDashboard.MouseUp += (s, e) => ((Button)s).BackColor = Color.OliveDrab;

           

        }



        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void AdminDashboard_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void btnViewAll_Click(object sender, EventArgs e)
        {

        }
    }
}

