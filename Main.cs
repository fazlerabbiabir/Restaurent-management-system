using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestaurentManagementSystem
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Food fd = new Food();
            fd.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Customer cr = new Customer();
            cr.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Order or = new Order();
            or.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Payment pt = new Payment();
            pt.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Dashboard dd = new Dashboard();
            dd.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Manager mg = new Manager();
            mg.Show();
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            Staff sf = new Staff();
            sf.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            Chef cf = new Chef();
            cf.Show();
        }
    }
}
