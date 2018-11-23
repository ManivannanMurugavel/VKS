using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VKS
{
    public partial class MainMenu : Form
    {
        public static string tableName = "";
        public MainMenu()
        {
            InitializeComponent();
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {
			if (Login.usertype == "User")
			{
				button1.Enabled = false;
				button2.Enabled = false;
				button4.Enabled = false;
				button5.Enabled = false;
				button7.Enabled = false;
			}
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tableName = "HomeProductDetails";
            ProductDetails pd = new ProductDetails();
            pd.Show();
            this.Hide();
            //this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tableName = "StoreProductDetails";
            ProductDetails pd = new ProductDetails();
            pd.Show();
            this.Hide();
            //this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Login l = new Login();
            l.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ProductPrice pp = new ProductPrice();
			pp.ShowDialog(this);
            //this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            UserDetails ud = new UserDetails();
            ud.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            OrderPage op = new OrderPage();
            op.Show();
            this.Hide();
        }

		private void button7_Click(object sender, EventArgs e)
		{
			Details dt = new Details();
			dt.Show();
			this.Hide();
		}
	}
}
