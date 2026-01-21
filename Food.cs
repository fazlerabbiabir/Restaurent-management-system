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
    public partial class Food : Form
    {
        public Food()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=localhost\SQLEXPRESS02;Initial Catalog=restaurentdb;Integrated Security=True;TrustServerCertificate=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into foodtab values(@foodid,@foodname,@price,@quantity,@status)", con);
            cmd.Parameters.AddWithValue("@FoodId", int.Parse(textBox1.Text));
            cmd.Parameters.AddWithValue("@FoodName",textBox2.Text);
            cmd.Parameters.AddWithValue("@Price", textBox3.Text);
            cmd.Parameters.AddWithValue("@Quantity", textBox4.Text);
            cmd.Parameters.AddWithValue("@Status", textBox5.Text);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Record Save Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=localhost\SQLEXPRESS02;Initial Catalog=restaurentdb;Integrated Security=True;TrustServerCertificate=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from foodtab", con);
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
            textBox5.Text = "";





        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=localhost\SQLEXPRESS02;Initial Catalog=restaurentdb;Integrated Security=True;TrustServerCertificate=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("update foodtab set foodname=@foodname,price=@price,quantity=@quantity,status=@status where foodid=@foodid", con);
            cmd.Parameters.AddWithValue("@FoodId", int.Parse(textBox1.Text));
            cmd.Parameters.AddWithValue("@FoodName", textBox2.Text);
            cmd.Parameters.AddWithValue("@Price", textBox3.Text);
            cmd.Parameters.AddWithValue("@Quantity", textBox4.Text);
            cmd.Parameters.AddWithValue("@Status", textBox5.Text);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Record Updated Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=localhost\SQLEXPRESS02;Initial Catalog=restaurentdb;Integrated Security=True;TrustServerCertificate=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("delete foodtab where foodid=@foodid", con);
            cmd.Parameters.AddWithValue("@FoodId", int.Parse(textBox1.Text));
           
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Record Deleted Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=localhost\SQLEXPRESS02;Initial Catalog=restaurentdb;Integrated Security=True;TrustServerCertificate=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from foodtab", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void Food_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=localhost\SQLEXPRESS02;Initial Catalog=restaurentdb;Integrated Security=True;TrustServerCertificate=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from foodtab", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
    }
}
