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
	public partial class Details : Form
	{
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
			panel1.Hide();
		}

		private void panel1_Paint(object sender, PaintEventArgs e)
		{
		}
	}
}
