using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.Data.OleDb;

namespace VKS
{
    public partial class UserDetails : Form
    {
        OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:/VKS/databases/VKS.accdb");
        OleDbCommand cmd;
        public UserDetails()
        {
            InitializeComponent();
        }

        private void UserDetails_Paint(object sender, PaintEventArgs e)
        {
           try
            {
               
                using (LinearGradientBrush br = new LinearGradientBrush(new Rectangle(0,0, 1373, 788), Color.Wheat, Color.FromArgb(1,255, 192, 128), 0f))
                    e.Graphics.FillRectangle(br, new Rectangle(0, 0, 1373, 788));
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void UserDetails_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedItem = "தேர்ந்தெடு";
            
            textBox1.Text = "பயனர் பெயர்";
            textBox1.ForeColor = Color.Gray;
            textBox2.Text = "கடவுச்சொல்";
            textBox2.ForeColor = Color.Gray;
            textBox3.Text = "கடவுச்சொல்";
            textBox3.ForeColor = Color.Gray;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MainMenu mm = new MainMenu();
            mm.Show();
            this.Hide();
        }
        private int passwordMatching(string pass1,string pass2)
        {
            int i = string.Compare(pass1, pass2, false);
            return i;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("கடவுச்சொல் காலியாக உள்ளது", "பயனர்  விவரம்", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            int result = passwordMatching(textBox2.Text, textBox3.Text);
            if(result != 0)
            {
                MessageBox.Show("இரண்டும் சரியானது இல்லை", "பயனர்  விவரம்", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if(comboBox1.SelectedItem.ToString() == "தேர்ந்தெடு")
            {
                MessageBox.Show("Enter User Type", "பயனர்  விவரம்", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string username = textBox1.Text;
            string password = textBox2.Text;
            string usertype = comboBox1.SelectedItem.ToString();
            try
            {
                if (con.State == ConnectionState.Closed)
                    con.Open();
                cmd = con.CreateCommand();
                cmd.CommandText = "insert into VKS_UserDetails(userName,userPassword,userType) values('" + username + "','"+password+"','"+usertype+"')";
                result = cmd.ExecuteNonQuery();
                if(result > 0)
                {
                    MessageBox.Show("பயனர் சேர்க்கப்பட்டது", "பயனர்  விவரம்", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("மீண்டும் முயற்சிக்கவும்");
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
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

        private void textBox3_Enter(object sender, EventArgs e)
        {
            if (textBox3.Text == "கடவுச்சொல்")
            {
                textBox3.Text = "";
                textBox3.ForeColor = Color.Black;
                textBox3.PasswordChar = '*';
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
                textBox2.Text = "கடவுச்சொல்";
                textBox2.ForeColor = Color.Gray;
            }
        }

        private void textBox3_Leave(object sender, EventArgs e)
        {
            if (textBox3.Text == "")
            {
                textBox3.Text = "கடவுச்சொல்";
                textBox3.ForeColor = Color.Gray;
            }
        }
    }
}
