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
    public partial class Login : Form
    {
        OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:/VKS/databases/VKS.accdb");
        OleDbCommand cmd;
        public static string usertype = "";
        public static string userName = "";
        MainMenu mm = new MainMenu();
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            this.ActiveControl = label1;
            textBox1.Text = "பயனர் பெயர்";
            textBox1.ForeColor = Color.Gray;
            textBox2.Text = "கடவுச்சொல்";
            textBox2.ForeColor = Color.Gray;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text;
            string password = textBox2.Text;
            try
            {
                if (con.State == ConnectionState.Closed)
                    con.Open();
                cmd = con.CreateCommand();
                cmd.CommandText = "select userType from VKS_UserDetails where userName='"+username+"' and userPassword='"+password+"'";
                OleDbDataReader reader = cmd.ExecuteReader();
                if(reader.HasRows)
                {
					reader.Read();
					usertype = reader["userType"].ToString();
                    MessageBox.Show("சரியான தகவல்கள்", "உள்நுழை",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    mm.Show();
                    this.Hide();
                    
                }
                else
                {
                    MessageBox.Show("தவறான தகவல்கள்", "உள்நுழை", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (textBox1.Text == "பயனர் பெயர்")
            {
                textBox1.Text = "";
                textBox1.ForeColor = Color.Black;
            }
        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            if (textBox2.Text == "கடவுச்சொல்")
            {
                textBox2.Text = "";
                textBox2.ForeColor = Color.Black;
                textBox2.PasswordChar = '*';
            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = "பயனர் பெயர்";
                textBox1.ForeColor = Color.Gray;
            }
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
            {
                textBox2.PasswordChar = '\0' ;
                textBox2.Text = "கடவுச்சொல்";
                textBox2.ForeColor = Color.Gray;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
