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
	public partial class Details : Form
	{
		OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:/VKS/databases/VKS.accdb");
		OleDbCommand cmd;
		public Details()
		{
			InitializeComponent();
		}

		private void இனறயமதபபToolStripMenuItem_Click(object sender, EventArgs e)
		{

		}

		private void Details_Load(object sender, EventArgs e)
		{
			dateTimePicker1.Format = DateTimePickerFormat.Custom;
			dateTimePicker1.CustomFormat = "yyyy-MM-dd";
			string year_num = dateTimePicker1.Value.Year.ToString();
			string month_num = dateTimePicker1.Value.Month.ToString();
			string day_num = dateTimePicker1.Value.Day.ToString();
			if (month_num.Length == 1)
				month_num = "0" + month_num;
			if (day_num.Length == 1)
				day_num = "0" + day_num;
			dateTimePicker1.MaxDate = new DateTime(Convert.ToInt32(year_num),Convert.ToInt32(month_num),Convert.ToInt32(day_num));
			//MessageBox.Show(year_num + '-' + month_num + '-' + day_num);
		}

		private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
		{
			
			//MessageBox.Show(dateTimePicker1.Value.Year.ToString()+'-'+ dateTimePicker1.Value.Month.ToString()+'-'+ dateTimePicker1.Value.Day.ToString());
		}

		private void button1_Click(object sender, EventArgs e)
		{
			try
			{
				string searchdate = dateTimePicker1.Value.Year.ToString() + '-' + dateTimePicker1.Value.Month.ToString("D2") + '-' + dateTimePicker1.Value.Day.ToString("D2");
				MessageBox.Show(searchdate);
				if (con.State == ConnectionState.Closed)
				{
					con.Open();
				}
				cmd = con.CreateCommand();
				cmd.CommandText = "select totalPrice from StoreOrderDetails where ordTime like '"+searchdate+"%'";
				OleDbDataReader reader = cmd.ExecuteReader();
				if (reader.HasRows)
				{
					MessageBox.Show("No rows");
				}
				while (reader.Read())
				{
					MessageBox.Show(reader["totalPrice"].ToString());
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
			//panel1.Hide();
		}

		private void panel1_Paint(object sender, PaintEventArgs e)
		{
		}
	}
}
