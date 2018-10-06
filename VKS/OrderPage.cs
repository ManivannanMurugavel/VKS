using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace VKS
{
    public partial class OrderPage : Form
    {
        OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:/VKS/databases/VKS.accdb");
        OleDbCommand cmd;
        int num = 0;
        string name = "";
        double prdprice,quantity,original;
        string ordIdNum = "";
        double totalPrdQty = 0;
        string[,] orderProductsList;
        int row = 0;
        int col = 0;
        double currPrdAvaQty = 0;
        bool alreadySaved = false;
		bool check = false;
        public OrderPage()
        {
            InitializeComponent();
        }
        private void getOrderId()
        {
            OleDbDataReader reader = null;
            try
            {
                if (con.State == ConnectionState.Closed)
                    con.Open();
                cmd = con.CreateCommand();
                cmd.CommandText = "select strordid from IdRef";
                reader = cmd.ExecuteReader();
                reader.Read();
                ordIdNum = reader["strordid"].ToString();
                label5.Text = (Convert.ToInt32(ordIdNum) + 1).ToString();
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
        private void button1_Click(object sender, EventArgs e)
        {
			//MessageBox.Show(currPrdAvaQty.ToString());
			try
			{
				quantity = Convert.ToDouble(qtyValue.Text);
				original = quantity;
				string weighttype = "Kg";
				if (comboBox3.SelectedItem.ToString() == "லிட்டர்")
				{
					original = Convert.ToDouble(qtyValue.Text)*1.11;
					weighttype = "ltr";
				}
				if (quantity > currPrdAvaQty)
				{
					MessageBox.Show("இந்த பொருளின் இருப்பு " + currPrdAvaQty.ToString() + " உள்ளது", "ஆர்டர்", MessageBoxButtons.OK, MessageBoxIcon.Information);
					return;
				}
				if (alreadySaved)
				{
					alreadySaved = false;
					dataGridView1.Rows.Clear();
					dataGridView1.Refresh();
					getOrderId();
				}
				name = comboBox2.SelectedItem.ToString();
				prdprice = Convert.ToDouble(prdPrice.Text);

				totalPrdQty = totalPrdQty + quantity;
				num++;
				double totalamount = (quantity * prdprice);
				label4.Text = (Convert.ToDouble(label4.Text) + totalamount).ToString();
				dataGridView1.Rows.Add(num, textBox1.Text, name, prdprice, quantity, original, weighttype, totalamount);
				comboBox1.SelectedIndex = -1;
				comboBox2.SelectedIndex = -1;
				comboBox2.Items.Clear();
				textBox1.Text = "";
				comboBox1.Text = "தேர்ந்தெடு";
				comboBox2.Text = "தேர்ந்தெடு";
				prdPrice.Text = "";
				qtyValue.Text = "";
				row++;
			}
			catch (InvalidOperationException ex)
			{
				MessageBox.Show("இந்த பொருளின் விலை இல்லை", "ஆர்டர்", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			catch (NullReferenceException ex)
			{
				MessageBox.Show("பொருளின் பெயர் மற்றும் வகையை நிரப்பு", "ஆர்டர்", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			catch (FormatException)
			{
				MessageBox.Show("பொருளின் விலையை நிரப்பு", "ஆர்டர்", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			finally
			{
			}
        }

        private void qtyValue_ValueChanged(object sender, EventArgs e)
        {

        }

        private void prdPrice_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (comboBox1.SelectedIndex == -1 || comboBox2.SelectedIndex==0)
                    return;
                string catename = comboBox1.SelectedItem.ToString();
                string prdname = comboBox2.SelectedItem.ToString();
                if (con.State == ConnectionState.Closed)
                    con.Open();
                cmd = con.CreateCommand();
                cmd.CommandText = "select prdId from StoreProductDetails where cateName='"+catename+"' and prdName='"+prdname+"'";
                OleDbDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    reader.Read();
                    textBox1.Text = reader["prdId"].ToString();
                    cmd.CommandText = "select price from StoreProductPrice where prdId='"+textBox1.Text+"' and weightType='"+comboBox3.SelectedItem.ToString()+"'";
                    reader.Close();
                    reader = cmd.ExecuteReader();
                    reader.Read();
                    prdPrice.Text = reader["price"].ToString();
                    reader.Close();
                    cmd.CommandText = "select qty from StockDetails where prdId='" + textBox1.Text + "'";
                    reader = cmd.ExecuteReader();
                    reader.Read();
                    currPrdAvaQty = Convert.ToDouble(reader["qty"].ToString());
                }
                else
                { 
                    MessageBox.Show("இந்த பொருள் இல்லை");
                    textBox1.Text = "";
                    prdPrice.Text = "";
                }
                reader.Close();
            }
			catch (InvalidOperationException ex)
			{
				MessageBox.Show("இந்த பொருளின் விலை இல்லை", "ஆர்டர்", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string text;
            if (comboBox1.SelectedIndex == -1)
                return;
            string selectedItem = comboBox1.SelectedItem.ToString();
            string text_file = selectedItem + "_பொருள்.txt";
            bool test = File.Exists(@"C:\VKS\files\" + text_file);
            comboBox2.Text = "தேர்ந்தெடு";
            comboBox2.Items.Clear();
            if (test)
            {
                StreamReader file = new StreamReader(@"C:\VKS\files\" + text_file);
                while ((text = file.ReadLine()) != null)
                {
                    comboBox2.Items.Add(text);
                }
                file.Close();

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MainMenu mm = new MainMenu();
            mm.Show();
            this.Hide();
        }

        private void OrderPage_Load(object sender, EventArgs e)
        {
			comboBox3.SelectedIndex = 0;
            string text;
            bool test = File.Exists(@"C:\VKS\files\பொருளின்_பிரிவு.txt");
            if (test)
            {
                StreamReader file = new StreamReader(@"C:\VKS\files\பொருளின்_பிரிவு.txt");
                while ((text = file.ReadLine()) != null)
                {
                    comboBox1.Items.Add(text);
                }
                file.Close();

            }
            getOrderId();
        }

        private void qtyValue_KeyDown(object sender, KeyEventArgs e)
        {
            //MessageBox.Show(currPrdAvaQty.ToString());
            if (e.KeyCode == Keys.Enter)
            {
                button1_Click(this, new EventArgs());
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(dataGridView1.RowCount == 0)
            {
                MessageBox.Show("பொருளை சேர்க்கவும்", "ஆர்டர்", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (alreadySaved)
            {
                printPreviewDialog1.Document = printDocument1;

                printPreviewDialog1.ShowDialog();
                return;
            }

            DialogResult dr = MessageBox.Show("உங்களது பொருள்களை சேமிக்கலாமா", "ஆர்டர்",MessageBoxButtons.YesNo,MessageBoxIcon.Information);
            if(dr == DialogResult.Yes)
            {
                //MessageBox.Show(ordIdNum);
                try
                {
                    MessageBox.Show(ordIdNum);
                    if(ordIdNum.Length < 8)
                    {
                        ordIdNum = Convert.ToInt32(Convert.ToInt32(ordIdNum) + 1).ToString("D4");
                        ordIdNum = "VKSSTRORD" + ordIdNum;
                    }                       
                    string username = "";
					username = Login.userName;
                    string prdType = "StoreProduct";
                    if (con.State == ConnectionState.Closed)
                        con.Open();
                    cmd = con.CreateCommand();
                    cmd.CommandText = "insert into StoreOrderDetails(ordId,totalQty,totalPrice,userName,ordTime) values('"+ordIdNum+"',"+ totalPrdQty + ","+Convert.ToDouble(label4.Text)+",'"+username+"','"+ DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss tt") + "')";
                    cmd.ExecuteNonQuery();
                    int datagridlength = dataGridView1.RowCount;
                    //MessageBox.Show(datagridlength.ToString());
                    for (int i = 0; i < datagridlength; i++)
                    {
                        cmd.CommandText = "insert into StoreOrderItems(ordId,prdId,prdType,prdName,qty,price,totalPrice,userName,weightType) values('"+ ordIdNum + "','"+ dataGridView1.Rows[i].Cells["productid"].Value.ToString() + "','"+prdType+"','"+ dataGridView1.Rows[i].Cells["productname"].Value.ToString() + "',"+Convert.ToDouble(dataGridView1.Rows[i].Cells["qty"].Value.ToString()) +","+Convert.ToDouble(dataGridView1.Rows[i].Cells["price"].Value.ToString()) +","+Convert.ToDouble(dataGridView1.Rows[i].Cells["totalprice"].Value.ToString()) +",'"+username+"','" + dataGridView1.Rows[i].Cells["weightType"].Value.ToString() + "')";
                        cmd.ExecuteNonQuery();
                        cmd.CommandText = "update StockDetails set qty=qty-"+ Convert.ToDouble(dataGridView1.Rows[i].Cells["oriQty"].Value.ToString()) + " where prdId='"+ dataGridView1.Rows[i].Cells["productid"].Value.ToString() + "'";
                        cmd.ExecuteNonQuery();
                    }
                    cmd.CommandText = "update IdRef set strordid=strordid+1";
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("உங்களது பொருள்கள் சேமிக்கப்பட்டது", "ஆர்டர்", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
                finally
                {
                    if (con.State == ConnectionState.Open)
                        con.Close();
                    alreadySaved = true;
                }
                
            }
            else
            {
                MessageBox.Show("உங்களது பொருள்கள் சேமிக்கப்படவில்லை", "ஆர்டர்", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            printPreviewDialog1.Document = printDocument1;
            
            printPreviewDialog1.ShowDialog();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            int totalX = 0, totalY = 0;
            int gridRowCnt = dataGridView1.Rows.Count;
            // Title
            e.Graphics.DrawString("VKS", new Font("Modern No", 30, FontStyle.Bold), new SolidBrush(Color.Black), new RectangleF(400, 10, printDocument1.DefaultPageSettings.PrintableArea.Width, printDocument1.DefaultPageSettings.PrintableArea.Height));
            // Contact Details
            e.Graphics.DrawString("தொலைபேசி", new Font("Modern No", 20), new SolidBrush(Color.Black), 200, 80);
            e.Graphics.DrawString("7639288278", new Font("Modern No", 20), new SolidBrush(Color.Black), 500, 80);
            // Order Informations
            e.Graphics.DrawLine(new Pen(Color.Black, 2), 70, 150, 800, 150);
            e.Graphics.DrawString("எண்  :", new Font("Modern No", 20), new SolidBrush(Color.Black), 80, 170);
            e.Graphics.DrawString(ordIdNum, new Font("Modern No", 20), new SolidBrush(Color.Black), 200, 170);
            e.Graphics.DrawString("தேதி:", new Font("Modern No", 20), new SolidBrush(Color.Black), 500, 170);
            e.Graphics.DrawString(label2.Text.Split(' ')[0], new Font("Modern No", 20), new SolidBrush(Color.Black), 600, 170);
            e.Graphics.DrawLine(new Pen(Color.Black, 2), 70, 240, 800, 240);
            // Product List
            e.Graphics.DrawLine(new Pen(Color.Black, 2), 70, 310, 800, 310);
            e.Graphics.DrawLine(new Pen(Color.Black, 2), 70, 310, 70, 360);
            StringFormat format1 = new StringFormat();
            format1.Trimming = StringTrimming.EllipsisWord;
            e.Graphics.DrawString("வ\nஎண்", new Font("Modern No", 15, FontStyle.Bold), new SolidBrush(Color.Black), 80, 310, format1);
            e.Graphics.DrawLine(new Pen(Color.Black, 2), 150, 310, 150, 360);
            e.Graphics.DrawString("பொருளின் பெயர்", new Font("Modern No", 15,FontStyle.Bold), new SolidBrush(Color.Black), 260, 320);
            e.Graphics.DrawLine(new Pen(Color.Black, 2), 600, 310, 600, 360);
            e.Graphics.DrawString("அளவு", new Font("Modern No", 15,FontStyle.Bold), new SolidBrush(Color.Black), 610, 320);
            e.Graphics.DrawLine(new Pen(Color.Black, 2), 700, 310, 700, 360);
            e.Graphics.DrawString("மதிப்பு", new Font("Modern No", 15, FontStyle.Bold), new SolidBrush(Color.Black), 705, 320);
            e.Graphics.DrawLine(new Pen(Color.Black, 2), 800, 310, 800, 360);
            e.Graphics.DrawLine(new Pen(Color.Black, 2), 70, 360, 800, 360);

            int rowValue = 360;
            int y = 0;
            // Order List
            for(int irow=1;irow<=gridRowCnt;irow++)
            {
                y = rowValue + (irow * 50);
                e.Graphics.DrawLine(new Pen(Color.Black, 2), 70, y, 800, y);
                e.Graphics.DrawLine(new Pen(Color.Black, 2), 70, y-50, 70, y);
                e.Graphics.DrawString(irow.ToString(), new Font("Modern No", 15), new SolidBrush(Color.Black), 80, y - 40);
                e.Graphics.DrawLine(new Pen(Color.Black, 2), 150, y-50, 150, y);
                e.Graphics.DrawString(dataGridView1.Rows[irow-1].Cells["productname"].Value.ToString(), new Font("Modern No", 15), new SolidBrush(Color.Black), 160, y - 40);
                e.Graphics.DrawLine(new Pen(Color.Black, 2), 600, y - 50, 600, y);
                e.Graphics.DrawString(dataGridView1.Rows[irow - 1].Cells["qty"].Value.ToString()+""+ dataGridView1.Rows[irow - 1].Cells["weightType"].Value.ToString(), new Font("Modern No", 15), new SolidBrush(Color.Black), 620, y - 40);
                e.Graphics.DrawLine(new Pen(Color.Black, 2), 700, y - 50, 700, y);
                e.Graphics.DrawString(dataGridView1.Rows[irow - 1].Cells["totalprice"].Value.ToString(), new Font("Modern No", 15), new SolidBrush(Color.Black), 720, y - 40);
                e.Graphics.DrawLine(new Pen(Color.Black, 2), 800, y - 50, 800, y);
            }
            e.Graphics.DrawString("மொத்த மதிப்பு", new Font("Modern No", 20,FontStyle.Bold), new SolidBrush(Color.Black), 300, y+50);
            e.Graphics.DrawString("=", new Font("Modern No", 20, FontStyle.Bold), new SolidBrush(Color.Black), 600, y + 50);
            e.Graphics.DrawString(label4.Text, new Font("Modern No", 20, FontStyle.Bold), new SolidBrush(Color.Black), 700, y + 50);
            //MessageBox.Show(gridRowCnt.ToString());
        }

		private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
		{
			try
			{
				if (textBox1.Text == "" && check)
				{
					MessageBox.Show("பொருளை தேர்ந்தெடுங்கள்", "ஆர்டர்", MessageBoxButtons.OK, MessageBoxIcon.Information);
					return;
				}
				if (!check)
				{
					check = true;
					return;
				}
				if (con.State == ConnectionState.Closed)
					con.Open();
				cmd = con.CreateCommand();
				cmd.CommandText = "select price from StoreProductPrice where prdId='" + textBox1.Text + "' and weightType='" + comboBox3.SelectedItem.ToString() + "'";
				OleDbDataReader reader = cmd.ExecuteReader();
				reader.Read();
				prdPrice.Text = reader["price"].ToString();
				reader.Close();
				cmd.CommandText = "select qty from StockDetails where prdId='" + textBox1.Text + "'";
				reader = cmd.ExecuteReader();
				reader.Read();
				currPrdAvaQty = Convert.ToDouble(reader["qty"].ToString());
				reader.Close();
			}
			catch (InvalidOperationException ex)
			{
				MessageBox.Show("இந்த பொருளின் விலை இல்லை", "ஆர்டர்", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
			finally
			{
				if (con.State == ConnectionState.Open)
				{
					con.Close();
					cmd.Dispose();
				}
				
			}
		}

		private void qtyValue_TextChanged(object sender, EventArgs e)
		{

		}

		private void timer1_Tick(object sender, EventArgs e)
        {
            label2.Text = DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss");
        }
    }
}
