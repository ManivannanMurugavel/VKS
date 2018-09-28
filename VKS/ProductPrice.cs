using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Data.OleDb;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VKS
{
    public partial class ProductPrice : Form
    {
        OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:/VKS/databases/VKS.accdb");
        OleDbCommand cmd;
        public static string priceproductid = "";
        public static string priceproductname = "";
        public ProductPrice()
        {
            InitializeComponent();
        }

        private void ProductPrice_Load(object sender, EventArgs e)
        {
            productPriceGrid();
        }
        public void productPriceGrid()
        {
            try
            {
                dataGridView1.Rows.Clear();
                if (con.State == ConnectionState.Closed)
                    con.Open();
                cmd = con.CreateCommand();
                cmd.CommandText = "select * from StoreProductPrice";
                OleDbDataReader reader = cmd.ExecuteReader();
                while(reader.Read())
                {
                    dataGridView1.Rows.Add(reader["prdId"], reader["cateName"], reader["prdName"], reader["weight"], reader["price"], reader["userName"]);
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                    con.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int selectedrowindex = dataGridView1.SelectedCells[0].RowIndex;
            int totalrows = dataGridView1.Rows.Count;
            if(selectedrowindex == totalrows-1)
            {
                MessageBox.Show("சரியான பொருளை தேர்ந்தெடுங்கள்");
                return;
            }
            priceproductid = dataGridView1.Rows[selectedrowindex].Cells["prdId"].Value.ToString();
            priceproductname = dataGridView1.Rows[selectedrowindex].Cells["prdName"].Value.ToString();
            PriceChange pc = new PriceChange();
            pc.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //MainMenu mm = new MainMenu();
            //mm.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            productPriceGrid();
        }
    }
}
