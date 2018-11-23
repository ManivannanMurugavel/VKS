using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Data.OleDb;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VKS
{
    public partial class ProductDetails : Form
    {
        OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:/VKS/databases/VKS.accdb");
        OleDbCommand cmd;
        public static string product = "";
        public static string product_id = "";
        public static string cateName = "";
        public static string prdname = "";
        string tablename = "";
        public ProductDetails()
        {
            InitializeComponent();
        }

        private void ProductDetails_Load(object sender, EventArgs e)
        {
			try
			{
				tablename = MainMenu.tableName;
				if (con.State == ConnectionState.Closed)
					con.Open();
				cmd = con.CreateCommand();
				cmd.CommandText = "select prdId,cateName,prdName,qty,price from " + tablename;
				if (tablename == "StoreProductDetails")
				{
					cmd.CommandText = "select distinct a.prdId as prdId,a.cateName as cateName,a.prdName as prdName,b.qty as qty,c.weightType,c.price as price from StoreProductDetails a,StockDetails b,StoreProductPrice c where a.prdId=b.prdId and a.prdId=c.prdId";
				}
				OleDbDataReader reader = cmd.ExecuteReader();
				if (reader.HasRows)
				{
					while (reader.Read())
					{
						dataGridView1.Rows.Add(reader["prdId"], reader["cateName"], reader["prdName"], reader["qty"], reader["weightType"], reader["price"]);
					}
				}
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

        private void back_Click(object sender, EventArgs e)
        {
            //this.Close();
            MainMenu mm = new MainMenu();
            mm.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            product = "new";
            addProduct ap = new addProduct();
            ap.ShowDialog(this);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                product = "old";
                int selectedrowindex = dataGridView1.SelectedCells[0].RowIndex;
                int totalrows = dataGridView1.Rows.Count;
                if (selectedrowindex == totalrows)
                {
                    MessageBox.Show("சரியான பொருளை தேர்ந்தெடுங்கள்");
                    return;
                }
                product_id = dataGridView1.Rows[selectedrowindex].Cells["productid"].Value.ToString();
                cateName = dataGridView1.Rows[selectedrowindex].Cells["categoryname"].Value.ToString();
                prdname = dataGridView1.Rows[selectedrowindex].Cells["productname"].Value.ToString();
                addProduct ap = new addProduct();
                ap.ShowDialog(this);
            }
            catch(ArgumentOutOfRangeException)
            {
                MessageBox.Show("உங்களால் பழைய பொருளை உருவாக்க முடியாது", "பொருளின் விவரம்",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
    }
}
