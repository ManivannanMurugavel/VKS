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
			this.label1 = new System.Windows.Forms.Label();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.வறறமதபபToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.இனறயமதபபToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.இனறயமதததறகனமதபபToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.panel1 = new System.Windows.Forms.Panel();
			this.label2 = new System.Windows.Forms.Label();
			this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
			this.button1 = new System.Windows.Forms.Button();
			this.menuStrip1.SuspendLayout();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(647, 35);
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
			this.panel1.Controls.Add(this.button1);
			this.panel1.Controls.Add(this.dateTimePicker1);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Location = new System.Drawing.Point(107, 113);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(1151, 518);
			this.panel1.TabIndex = 2;
			this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.BackColor = System.Drawing.Color.White;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(341, 58);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(273, 31);
			this.label2.TabIndex = 0;
			this.label2.Text = "தேதியை தேர்ந்தெடு";
			// 
			// dateTimePicker1
			// 
			this.dateTimePicker1.CustomFormat = "";
			this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dateTimePicker1.Location = new System.Drawing.Point(666, 59);
			this.dateTimePicker1.Name = "dateTimePicker1";
			this.dateTimePicker1.Size = new System.Drawing.Size(188, 35);
			this.dateTimePicker1.TabIndex = 1;
			this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
			// 
			// button1
			// 
			this.button1.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button1.Location = new System.Drawing.Point(545, 150);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(199, 49);
			this.button1.TabIndex = 2;
			this.button1.Text = "அச்சிடு";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// Details
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(1357, 726);
			this.ControlBox = false;
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
	}
}