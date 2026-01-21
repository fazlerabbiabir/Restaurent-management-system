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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace RestaurentManagementSystem
{
    public partial class Order : Form
    {
        public Order()
        {
            InitializeComponent();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            dateTimePicker1.CustomFormat = "dd/MM/yyyy";
        }

        private void dateTimePicker1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Back)

            {
                dateTimePicker1.CustomFormat = "";
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=localhost\SQLEXPRESS02;Initial Catalog=restaurentdb;Integrated Security=True;TrustServerCertificate=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into ordertab values(@orderid,@customername,@food1,@food2,@food3,@orderdate)", con);
            cmd.Parameters.AddWithValue("@OrderId", int.Parse(textBox1.Text));
            cmd.Parameters.AddWithValue("@CustomerName", textBox2.Text);
            cmd.Parameters.AddWithValue("@Food1", textBox3.Text);
            cmd.Parameters.AddWithValue("@Food2", textBox4.Text);
            cmd.Parameters.AddWithValue("@Food3", textBox6.Text);
            cmd.Parameters.AddWithValue("@OrderDate", dateTimePicker1.Value);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Record Save Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=localhost\SQLEXPRESS02;Initial Catalog=restaurentdb;Integrated Security=True;TrustServerCertificate=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from ordertab", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox6.Text = "";

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=localhost\SQLEXPRESS02;Initial Catalog=restaurentdb;Integrated Security=True;TrustServerCertificate=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("update ordertab set customername=@customername,food1=@food1,food2=@food2,food3=@food3,orderdate=@orderdate where orderid=@orderid", con);
            cmd.Parameters.AddWithValue("@OrderId", int.Parse(textBox1.Text));
            cmd.Parameters.AddWithValue("@CustomerName", textBox2.Text);
            cmd.Parameters.AddWithValue("@Food1", textBox3.Text);
            cmd.Parameters.AddWithValue("@Food2", textBox4.Text);
            cmd.Parameters.AddWithValue("@Food3", textBox6.Text);
            cmd.Parameters.AddWithValue("@OrderDate", dateTimePicker1.Value);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Record Updated Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=localhost\SQLEXPRESS02;Initial Catalog=restaurentdb;Integrated Security=True;TrustServerCertificate=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("delete ordertab where orderid=@orderid", con);
            cmd.Parameters.AddWithValue("@OrderId", int.Parse(textBox1.Text));
            
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Record Deleted Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection(@"Data Source=localhost\SQLEXPRESS02;Initial Catalog=restaurentdb;Integrated Security=True;TrustServerCertificate=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from ordertab", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void Order_Load(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection(@"Data Source=localhost\SQLEXPRESS02;Initial Catalog=restaurentdb;Integrated Security=True;TrustServerCertificate=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from ordertab", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
    }
}