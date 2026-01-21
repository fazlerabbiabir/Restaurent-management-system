using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace RestaurentManagementSystem
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            display();
            display1();
            display2();
        }

        private void display()
        {
            SqlConnection con = new SqlConnection(@"Data Source=localhost\SQLEXPRESS02;Initial Catalog=restaurentdb;Integrated Security=True;TrustServerCertificate=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT COUNT (*) FROM foodtab", con);
            Int32 count = Convert.ToInt32(cmd.ExecuteScalar());
            if (count > 0)
            {
                label3.Text = Convert.ToString(count.ToString());
            }
            else
            {
                label3.Text = "0";
            }
            con.Close();

        }

        private void display1()
        {
            SqlConnection con = new SqlConnection(@"Data Source=localhost\SQLEXPRESS02;Initial Catalog=restaurentdb;Integrated Security=True;TrustServerCertificate=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT COUNT (*) FROM customertab", con);
            Int32 count = Convert.ToInt32(cmd.ExecuteScalar());
            if (count > 0)
            {
                label5.Text = Convert.ToString(count.ToString());
            }
            else
            {
                label5.Text = "0";
            }
            con.Close();

        }
        private void display2()
        {
            SqlConnection con = new SqlConnection(@"Data Source=localhost\SQLEXPRESS02;Initial Catalog=restaurentdb;Integrated Security=True;TrustServerCertificate=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT COUNT (*) FROM ordertab", con);
            Int32 count = Convert.ToInt32(cmd.ExecuteScalar());
            if (count > 0)
            {
                label7.Text = Convert.ToString(count.ToString());
            }
            else
            {
                label7.Text = "0";
            }
            con.Close();

        }

        }
}
