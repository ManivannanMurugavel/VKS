using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace VKS
{
    public partial class PriceChange : Form
    {
        string productid = "";
        OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:/VKS/databases/VKS.accdb");
        OleDbCommand cmd;
        public PriceChange()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if(textBox2.Text == "")
                {
                    MessageBox.Show("பொருளின் விலையை நிரப்பு");
                    return;
                }
                int price = Convert.ToInt32(textBox2.Text);
                if (con.State == ConnectionState.Closed)
                    con.Open();
                cmd = con.CreateCommand();
                cmd.CommandText = "update StoreProductPrice set price="+price+" where prdId='"+ productid + "'";
                int result = cmd.ExecuteNonQuery();
                if (result > 0)
                { 
                    MessageBox.Show("பொருளின் விலை மாற்றப்பட்டது");
                    
                    this.Close();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                    con.Close();
            }
        }

        private void PriceChange_Load(object sender, EventArgs e)
        {
            textBox1.Text = ProductPrice.priceproductname;
            productid = ProductPrice.priceproductid;
        }

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button1_Click(this, new EventArgs());
            }
        }
    }
}
