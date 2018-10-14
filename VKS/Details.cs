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
				if (con.State == ConnectionState.Closed)
				{
					con.Open();
				}
				cmd = con.CreateCommand();
				cmd.CommandText = "select count(b.prdName) as ProductName,b.weightType as WeightType,sum(b.qty) as TotalQty,sum(b.totalPrice) as TotalPrice from StoreOrderDetails a,StoreOrderItems b where  left(a.ordTime,10) = '" + searchdate + "' and a.ordId=b.ordId group by b.prdName,b.weightType";
				int rowcount = 0;
				OleDbDataReader reader = cmd.ExecuteReader();
				while (reader.Read())
				{
					rowcount++;
				}
				rowcount = 180 + (rowcount * 30);
				//MessageBox.Show(rowcount.ToString());
				reader.Close();
				con.Close();
				printDocument1.DefaultPageSettings.PaperSize = new System.Drawing.Printing.PaperSize("custom", 400, rowcount);
				printPreviewDialog1.Document = printDocument1;
				printPreviewDialog1.ShowDialog();
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

		private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
		{
			try
			{
				string searchdate = dateTimePicker1.Value.Year.ToString() + '-' + dateTimePicker1.Value.Month.ToString("D2") + '-' + dateTimePicker1.Value.Day.ToString("D2");
				e.Graphics.DrawString("VKS Traders", new Font("Modern No", 15, FontStyle.Bold), new SolidBrush(Color.Black), new RectangleF(140, 10, printDocument1.DefaultPageSettings.PrintableArea.Width, printDocument1.DefaultPageSettings.PrintableArea.Height));
				e.Graphics.DrawString(searchdate, new Font("Modern No", 10), new SolidBrush(Color.Black), 165, 40);
				e.Graphics.DrawLine(new Pen(Color.Black, 1), 0, 60, 400, 60);
				e.Graphics.DrawLine(new Pen(Color.Black, 1), 0, 90, 400, 90);
				e.Graphics.DrawLine(new Pen(Color.Black, 1), 0, 60, 0, 90);
				e.Graphics.DrawString("பொருளின் பெயர்", new Font("Modern No", 10), new SolidBrush(Color.Black), 25, 68);
				e.Graphics.DrawLine(new Pen(Color.Black, 1), 190, 60, 190, 90);
				e.Graphics.DrawString("அளவு", new Font("Modern No", 10), new SolidBrush(Color.Black), 205, 68);
				e.Graphics.DrawLine(new Pen(Color.Black, 1), 260, 60, 260, 90);
				e.Graphics.DrawString("அலகு", new Font("Modern No", 10), new SolidBrush(Color.Black), 275, 68);
				e.Graphics.DrawLine(new Pen(Color.Black, 1), 330, 60, 330, 90);
				e.Graphics.DrawString("மதிப்பு", new Font("Modern No", 10), new SolidBrush(Color.Black), 335, 68);
				e.Graphics.DrawLine(new Pen(Color.Black, 1), 400, 60, 400, 90);
				int y = 90;
				int i = 1;
				if (con.State == ConnectionState.Closed)
				{
					con.Open();
				}
				cmd = con.CreateCommand();
				cmd.CommandText = "select b.prdName as ProductName,b.weightType as WeightType,sum(b.qty) as TotalQty,sum(b.totalPrice) as TotalPrice from StoreOrderDetails a,StoreOrderItems b where  left(a.ordTime,10) = '" + searchdate + "' and a.ordId=b.ordId group by b.prdName,b.weightType";
				OleDbDataReader reader = cmd.ExecuteReader();
				double totalQTY = 0;
				double totalPRZ = 0;
				while (reader.Read())
				{
					totalQTY = totalQTY + Convert.ToDouble(reader["TotalQty"].ToString());
					totalPRZ = totalPRZ + Convert.ToDouble(reader["TotalPrice"].ToString());
					e.Graphics.DrawLine(new Pen(Color.Black, 1), 0, (y+(i*30)), 400, (y + (i * 30)));
					e.Graphics.DrawLine(new Pen(Color.Black, 1), 0, (y + ((i-1) * 30)), 0, (y + (i * 30)));
					e.Graphics.DrawString(reader["ProductName"].ToString(), new Font("Modern No", 10), new SolidBrush(Color.Black), 15, (y + ((i - 1) * 30))+8);
					e.Graphics.DrawLine(new Pen(Color.Black, 1), 190, (y + ((i - 1) * 30)), 190, (y + (i * 30)));
					e.Graphics.DrawString(reader["TotalQty"].ToString(), new Font("Modern No", 10), new SolidBrush(Color.Black), 195, (y + ((i - 1) * 30)) + 8);
					e.Graphics.DrawLine(new Pen(Color.Black, 1), 260, (y + ((i - 1) * 30)), 260, (y + (i * 30)));
					e.Graphics.DrawString(reader["WeightType"].ToString(), new Font("Modern No", 10), new SolidBrush(Color.Black), 265, (y + ((i - 1) * 30)) + 8);
					e.Graphics.DrawLine(new Pen(Color.Black, 1), 330, (y + ((i - 1) * 30)), 330, (y + (i * 30)));
					e.Graphics.DrawString(reader["TotalPrice"].ToString(), new Font("Modern No", 10), new SolidBrush(Color.Black), 335, (y + ((i - 1) * 30)) + 8);
					e.Graphics.DrawLine(new Pen(Color.Black, 1), 400, (y + ((i - 1) * 30)), 400, (y + (i * 30)));
					//MessageBox.Show(reader["TotalQty"].ToString()+"--"+reader["WeightType"].ToString());
					i++;
				}
				y = (y + (i * 30));
				e.Graphics.DrawLine(new Pen(Color.Black, 1), 50, y, 350, y);
				e.Graphics.DrawLine(new Pen(Color.Black, 1), 50, y-30, 50, y);
				e.Graphics.DrawLine(new Pen(Color.Black, 1), 220, y - 30, 220, y);
				e.Graphics.DrawString("மொத்த எண்ணிக்கை", new Font("Modern No", 8, FontStyle.Bold), new SolidBrush(Color.Black), 60, y -22);
				e.Graphics.DrawString(totalQTY.ToString(), new Font("Modern No", 10, FontStyle.Bold), new SolidBrush(Color.Black), 120, y+8);
				e.Graphics.DrawLine(new Pen(Color.Black, 1), 350, y - 30, 350, y);
				e.Graphics.DrawLine(new Pen(Color.Black, 1), 50, y+30, 350, y+30);
				e.Graphics.DrawLine(new Pen(Color.Black, 1), 50, y, 50, y+30);
				e.Graphics.DrawLine(new Pen(Color.Black, 1), 220, y, 220, y+30);
				e.Graphics.DrawString("மொத்த விலை", new Font("Modern No", 8, FontStyle.Bold), new SolidBrush(Color.Black), 230, y -22);
				e.Graphics.DrawString(totalPRZ.ToString(), new Font("Modern No", 10, FontStyle.Bold), new SolidBrush(Color.Black), 270, y + 8);
				e.Graphics.DrawLine(new Pen(Color.Black, 1), 350, y, 350, y + 30);
				e.Graphics.DrawString("மீண்டும் வருக", new Font("Modern No", 8, FontStyle.Bold), new SolidBrush(Color.Black), 160, y + 40);

			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
		}
	}
}
