namespace VKS
{
    partial class ProductDetails
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			this.label1 = new System.Windows.Forms.Label();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.back = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.productid = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.categoryname = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.productname = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.stockqty = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.weightType = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.productprice = new System.Windows.Forms.DataGridViewTextBoxColumn();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("News701 BT", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(419, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(489, 58);
			this.label1.TabIndex = 0;
			this.label1.Text = "பொருளின் விவரம்";
			// 
			// dataGridView1
			// 
			this.dataGridView1.AllowUserToAddRows = false;
			this.dataGridView1.AllowUserToDeleteRows = false;
			this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.productid,
            this.categoryname,
            this.productname,
            this.stockqty,
            this.weightType,
            this.productprice});
			this.dataGridView1.Location = new System.Drawing.Point(46, 124);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.ReadOnly = true;
			this.dataGridView1.Size = new System.Drawing.Size(1268, 471);
			this.dataGridView1.TabIndex = 1;
			// 
			// back
			// 
			this.back.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.back.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.back.ForeColor = System.Drawing.SystemColors.ControlText;
			this.back.Location = new System.Drawing.Point(1122, 665);
			this.back.Name = "back";
			this.back.Size = new System.Drawing.Size(153, 52);
			this.back.TabIndex = 2;
			this.back.Text = "பின் செல்ல";
			this.back.UseVisualStyleBackColor = false;
			this.back.Click += new System.EventHandler(this.back_Click);
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
			this.button1.Location = new System.Drawing.Point(96, 665);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(202, 52);
			this.button1.TabIndex = 3;
			this.button1.Text = "புதிய பொருள்";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// button2
			// 
			this.button2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
			this.button2.Location = new System.Drawing.Point(470, 665);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(221, 52);
			this.button2.TabIndex = 4;
			this.button2.Text = "பழைய பொருள்";
			this.button2.UseVisualStyleBackColor = false;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// productid
			// 
			this.productid.HeaderText = "பொருளின் எண்";
			this.productid.Name = "productid";
			this.productid.ReadOnly = true;
			// 
			// categoryname
			// 
			this.categoryname.HeaderText = "பொருளின் வகை";
			this.categoryname.Name = "categoryname";
			this.categoryname.ReadOnly = true;
			// 
			// productname
			// 
			this.productname.HeaderText = "பொருளின் பெயர்";
			this.productname.Name = "productname";
			this.productname.ReadOnly = true;
			// 
			// stockqty
			// 
			this.stockqty.HeaderText = "இருப்பு எண்ணிக்கை";
			this.stockqty.Name = "stockqty";
			this.stockqty.ReadOnly = true;
			// 
			// weightType
			// 
			this.weightType.HeaderText = "எடையின் வகை";
			this.weightType.Name = "weightType";
			this.weightType.ReadOnly = true;
			// 
			// productprice
			// 
			this.productprice.HeaderText = "பொருளின் விலை";
			this.productprice.Name = "productprice";
			this.productprice.ReadOnly = true;
			// 
			// ProductDetails
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1357, 749);
			this.ControlBox = false;
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.back);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.label1);
			this.Name = "ProductDetails";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Load += new System.EventHandler(this.ProductDetails_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
		private System.Windows.Forms.DataGridViewTextBoxColumn productid;
		private System.Windows.Forms.DataGridViewTextBoxColumn categoryname;
		private System.Windows.Forms.DataGridViewTextBoxColumn productname;
		private System.Windows.Forms.DataGridViewTextBoxColumn stockqty;
		private System.Windows.Forms.DataGridViewTextBoxColumn weightType;
		private System.Windows.Forms.DataGridViewTextBoxColumn productprice;
	}
}