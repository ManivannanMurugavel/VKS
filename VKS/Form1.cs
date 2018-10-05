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
    public partial class addProduct : Form
    {
        OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:/VKS/databases/VKS.accdb");
        OleDbCommand cmd;
        string tableName = "";
        string field = "";
        string prdType = "";
        string product = "new";
        public addProduct()
        {
            InitializeComponent();
        }

        private void addProduct_Load(object sender, EventArgs e)
        {
            try
            {
				comboBox4.SelectedIndex = 1;   
                tableName = MainMenu.tableName;
                if (radioButton1.Checked == true)
                {
                    setProductId(tableName);
                }
                comboBox3.SelectedIndex = 1;
                if (tableName == "HomeProductDetails")
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
                product = ProductDetails.product;
                if (product == "new")
                    radioButton1.Checked = true;
                else
                {
                    radioButton2.Checked = true;
                }
                //con.Open();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void setProductId(string tableName)
        {
            string prdId = "";
            string label = "";
            OleDbDataReader reader;
            try
            {
                
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                cmd = con.CreateCommand();
                if (tableName == "HomeProductDetails")
                { 
                    field = "hmeprdid";
                    label = "VKSHMEPRD";
                    prdType = "வீட்டு பொருள்";
                }
                else
                {
                    field = "strprdid";
                    label = "VKSSTRPRD";
                    prdType = "கடை பொருள்";
                }
                cmd.CommandText = "select "+field+" from IdRef";
                reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    reader.Read();
                    prdId = reader[field].ToString();
                    prdId = Convert.ToInt32(Convert.ToInt32(prdId) + 1).ToString("D4");
                    textBox1.Text = label + prdId;
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
                {
                    con.Close();
                    
                }
                cmd.Dispose();
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if(con.State == ConnectionState.Open)
                {
                    MessageBox.Show("SHow");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string text;
            string selectedItem = comboBox1.SelectedItem.ToString();
            string text_file = selectedItem + "_பொருள்.txt";
            bool test = File.Exists(@"C:\VKS\files\"+ text_file);
            comboBox2.Text = "தேர்ந்தெடு";
            comboBox2.Items.Clear();
            if (test)
            {
                StreamReader file = new StreamReader(@"C:\VKS\files\"+ text_file);
                while ((text = file.ReadLine()) != null)
                {
                    comboBox2.Items.Add(text);
                }
                file.Close();

            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            decimal prdqty = qtyValue.Value;
            if (prdPrice.Text != "")
            {
                int price = int.Parse(prdPrice.Text);
                ttlPrice.Text = (prdqty * price).ToString();
            }
        }

        private void prdPrice_TextChanged(object sender, EventArgs e)
        {
            decimal prdqty = qtyValue.Value;
            if (prdPrice.Text != "")
            {
                int price = int.Parse(prdPrice.Text);
                ttlPrice.Text = (prdqty * price).ToString();
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            //MessageBox.Show(radioButton2.Checked.ToString());
            product = "old";
            //textBox1.Text = "";
            //comboBox1.Text = "தேர்ந்தெடு";
            //comboBox2.Text = "தேர்ந்தெடு";
            prdPrice.Text = "";
            qtyValue.Value = 1;
            ttlPrice.Text = "";
            if(radioButton2.Checked == true)
            { 
                textBox1.Text = ProductDetails.product_id;
                comboBox1.SelectedItem = ProductDetails.cateName;
                comboBox2.SelectedItem = ProductDetails.prdname;
                comboBox1.Enabled = false;
                comboBox2.Enabled = false;
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            product = "new";
            try
            {
                if (radioButton1.Checked == true)
                {
                    comboBox1.SelectedItem = "தேர்ந்தெடு";
                    comboBox2.SelectedItem = "தேர்ந்தெடு";
                    comboBox1.Enabled = true;
                    comboBox2.Enabled = true;
                    setProductId(tableName);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private DateTime GetDateWithoutMilliseconds(DateTime d)
        {
            return new DateTime(d.Year, d.Month, d.Day, d.Hour, d.Minute, d.Second);
        }
        private void storeStockDetails(OleDbCommand cmd,string prdId,string prdType,string cateName,string prdName,int qty)
        {
            try
            {
                if (con.State == ConnectionState.Closed)
                    con.Open();
                cmd.CommandText = "update StockDetails set qty = qty+" + qty +" where prdId='"+prdId+"'"; 
                int result = cmd.ExecuteNonQuery();
                if(result == 0)
                {
                    cmd.CommandText = "insert into StockDetails(prdId,prdType,cateName,prdName,qty) values('"+prdId+"','"+prdType+"','"+cateName+"','"+prdName+"',"+qty+")";
                    cmd.ExecuteNonQuery();
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
        //private void addProductPrice()
        private bool productExist(string cateName,string prdName)
        {
            cmd.CommandText = "select prdId from "+tableName+" where cateName='"+cateName+"' and prdName='"+prdName+"'";
            OleDbDataReader reader = cmd.ExecuteReader();
            bool returnValue = reader.HasRows;
            reader.Close();
            return returnValue;
        }
        private void storeProductPrice(OleDbCommand cmd,string id,string catePrd,string prdName,int price,string username)
        {
            try
            {
                if (con.State == ConnectionState.Closed)
                    con.Open();
                cmd.CommandText = "update StoreProductPrice set price="+price+" where prdId='"+id+"'";
                int result = cmd.ExecuteNonQuery();
                if (result > 0)
                    MessageBox.Show("பொருளின் விலை சேர்க்கப்பட்டது");
                else
                {
                    cmd.CommandText = "insert into StoreProductPrice(prdId,cateName,prdName,weightType,weight,price,userName) values('" + id + "','" + catePrd + "','" + prdName + "','கிலோ',1," + price + ",'" + username + "')";
                    result = cmd.ExecuteNonQuery();
					cmd.CommandText = "insert into StoreProductPrice(prdId,cateName,prdName,weightType,weight,price,userName) values('" + id + "','" + catePrd + "','" + prdName + "','லிட்டர்',1," + price + ",'" + username + "')";
					result = cmd.ExecuteNonQuery();
					if (result > 0)
                        MessageBox.Show("பொருளின் விலை சேர்க்கப்பட்டது");
                    else
                        MessageBox.Show("பொருளின் விலை சேர்க்கப்படவில்லை");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                if(con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                string id = textBox1.Text;
                string catePrd = comboBox1.SelectedItem.ToString();
                string prdName = comboBox2.SelectedItem.ToString();
                string table = MainMenu.tableName;
                int price = Convert.ToInt32(prdPrice.Text);
                int qty = Convert.ToInt32(qtyValue.Value);
                int totalPrice = Convert.ToInt32(ttlPrice.Text);
                string dateTime = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                string username = "";
                cmd = con.CreateCommand();
                if(product == "new")
                {
                    if(productExist(catePrd,prdName))
                    {
                        MessageBox.Show("இந்த பொருள் ஏற்கனவே உள்ளது");
                        return;
                    }
                }
                cmd.CommandText = "insert into "+ table + "(prdId,cateName,prdName,qty,price,totalPrice,userName,isDeleted,prdTime) values('"+id+"','"+catePrd+"','"+prdName+"',"+qty+","+price+","+totalPrice+",'"+username+"',"+0+",'" + dateTime + "')";
                int result = cmd.ExecuteNonQuery();
                if (result > 0)
                {
                    MessageBox.Show("பொருள் சேமிக்கப்பட்டது");
                    if(product != "old")
                    { 
                        cmd.CommandText = "update IdRef set " + field +"="+ field+" + 1";
                        cmd.ExecuteNonQuery();
                    }
                    storeStockDetails(cmd, id, prdType, catePrd, prdName, qty);
                    if (table == "StoreProductDetails")
                        storeProductPrice(cmd, id, catePrd, prdName, price, username);
                }
                
            }
            catch(NullReferenceException)
            {
                MessageBox.Show("பொருளின் வகை மற்றும் விலையை நிரப்பு");
            }
            catch(FormatException)
            {
                MessageBox.Show("பொருளின் விலையை நிரப்பு");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                //textBox1.Text = "";
                if (con.State == ConnectionState.Open)
                    con.Close();
                cmd.Dispose();
                comboBox1.SelectedItem = "தேர்ந்தெடு";
                comboBox2.SelectedItem = "தேர்ந்தெடு";
                prdPrice.Text = "";
                ttlPrice.Text = "";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
			//MessageBox.Show(comboBox4.SelectedItem.ToString());
            this.Close();
        }
    }
}
