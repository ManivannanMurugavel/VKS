namespace VKS
{
	partial class Details
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Details));
			this.label1 = new System.Windows.Forms.Label();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.வறறமதபபToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.இனறயமதபபToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.இனறயமதததறகனமதபபToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.panel1 = new System.Windows.Forms.Panel();
			this.button1 = new System.Windows.Forms.Button();
			this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
			this.label2 = new System.Windows.Forms.Label();
			this.printDocument1 = new System.Drawing.Printing.PrintDocument();
			this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
			this.label3 = new System.Windows.Forms.Label();
			this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
			this.dateTimePicker3 = new System.Windows.Forms.DateTimePicker();
			this.panel2 = new System.Windows.Forms.Panel();
			this.button2 = new System.Windows.Forms.Button();
			this.menuStrip1.SuspendLayout();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(582, 35);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(196, 39);
			this.label1.TabIndex = 0;
			this.label1.Text = "விவரங்கள்";
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.வறறமதபபToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(1357, 24);
			this.menuStrip1.TabIndex = 1;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// வறறமதபபToolStripMenuItem
			// 
			this.வறறமதபபToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.இனறயமதபபToolStripMenuItem,
            this.இனறயமதததறகனமதபபToolStripMenuItem});
			this.வறறமதபபToolStripMenuItem.Name = "வறறமதபபToolStripMenuItem";
			this.வறறமதபபToolStripMenuItem.Size = new System.Drawing.Size(104, 20);
			this.வறறமதபபToolStripMenuItem.Text = "விற்ற மதிப்பு";
			// 
			// இனறயமதபபToolStripMenuItem
			// 
			this.இனறயமதபபToolStripMenuItem.Name = "இனறயமதபபToolStripMenuItem";
			this.இனறயமதபபToolStripMenuItem.Size = new System.Drawing.Size(247, 22);
			this.இனறயமதபபToolStripMenuItem.Text = "ஒரு நாள் மதிப்பு";
			this.இனறயமதபபToolStripMenuItem.Click += new System.EventHandler(this.இனறயமதபபToolStripMenuItem_Click);
			// 
			// இனறயமதததறகனமதபபToolStripMenuItem
			// 
			this.இனறயமதததறகனமதபபToolStripMenuItem.Name = "இனறயமதததறகனமதபபToolStripMenuItem";
			this.இனறயமதததறகனமதபபToolStripMenuItem.Size = new System.Drawing.Size(247, 22);
			this.இனறயமதததறகனமதபபToolStripMenuItem.Text = "ஒரு மாதத்திற்கான மதிப்பு";
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.Olive;
			this.panel1.Controls.Add(this.button1);
			this.panel1.Controls.Add(this.dateTimePicker1);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Location = new System.Drawing.Point(176, 201);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(401, 448);
			this.panel1.TabIndex = 2;
			this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
			// 
			// button1
			// 
			this.button1.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button1.Location = new System.Drawing.Point(124, 312);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(155, 41);
			this.button1.TabIndex = 2;
			this.button1.Text = "அச்சிடு";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// dateTimePicker1
			// 
			this.dateTimePicker1.CustomFormat = "";
			this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dateTimePicker1.Location = new System.Drawing.Point(100, 203);
			this.dateTimePicker1.Name = "dateTimePicker1";
			this.dateTimePicker1.Size = new System.Drawing.Size(205, 31);
			this.dateTimePicker1.TabIndex = 1;
			this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.BackColor = System.Drawing.Color.White;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(96, 104);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(210, 25);
			this.label2.TabIndex = 0;
			this.label2.Text = "தேதியை தேர்ந்தெடு";
			// 
			// printDocument1
			// 
			this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
			// 
			// printPreviewDialog1
			// 
			this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
			this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
			this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
			this.printPreviewDialog1.Enabled = true;
			this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
			this.printPreviewDialog1.Name = "printPreviewDialog1";
			this.printPreviewDialog1.Visible = false;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.BackColor = System.Drawing.Color.White;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(95, 77);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(210, 25);
			this.label3.TabIndex = 3;
			this.label3.Text = "தேதியை தேர்ந்தெடு";
			// 
			// dateTimePicker2
			// 
			this.dateTimePicker2.CustomFormat = "";
			this.dateTimePicker2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dateTimePicker2.Location = new System.Drawing.Point(100, 161);
			this.dateTimePicker2.Name = "dateTimePicker2";
			this.dateTimePicker2.Size = new System.Drawing.Size(205, 31);
			this.dateTimePicker2.TabIndex = 4;
			// 
			// dateTimePicker3
			// 
			this.dateTimePicker3.CustomFormat = "";
			this.dateTimePicker3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dateTimePicker3.Location = new System.Drawing.Point(100, 242);
			this.dateTimePicker3.Name = "dateTimePicker3";
			this.dateTimePicker3.Size = new System.Drawing.Size(205, 31);
			this.dateTimePicker3.TabIndex = 5;
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.Teal;
			this.panel2.Controls.Add(this.button2);
			this.panel2.Controls.Add(this.label3);
			this.panel2.Controls.Add(this.dateTimePicker3);
			this.panel2.Controls.Add(this.dateTimePicker2);
			this.panel2.Location = new System.Drawing.Point(751, 201);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(401, 448);
			this.panel2.TabIndex = 6;
			// 
			// button2
			// 
			this.button2.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button2.Location = new System.Drawing.Point(127, 337);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(155, 41);
			this.button2.TabIndex = 3;
			this.button2.Text = "அச்சிடு";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// Details
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.ClientSize = new System.Drawing.Size(1357, 726);
			this.ControlBox = false;
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.menuStrip1);
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "Details";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Load += new System.EventHandler(this.Details_Load);
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem வறறமதபபToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem இனறயமதபபToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem இனறயமதததறகனமதபபToolStripMenuItem;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.DateTimePicker dateTimePicker1;
		private System.Windows.Forms.Button button1;
		private System.Drawing.Printing.PrintDocument printDocument1;
		private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
		private System.Windows.Forms.DateTimePicker dateTimePicker3;
		private System.Windows.Forms.DateTimePicker dateTimePicker2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Button button2;
	}
}