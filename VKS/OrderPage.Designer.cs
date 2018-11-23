namespace VKS
{
    partial class OrderPage
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
			this.components = new System.ComponentModel.Container();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrderPage));
			this.label1 = new System.Windows.Forms.Label();
			this.comboBox2 = new System.Windows.Forms.ComboBox();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.prdPrice = new System.Windows.Forms.TextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.comboBox3 = new System.Windows.Forms.ComboBox();
			this.qtyValue = new System.Windows.Forms.TextBox();
			this.button2 = new System.Windows.Forms.Button();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.productid = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.productname = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.oriQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.weightType = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.totalprice = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.label2 = new System.Windows.Forms.Label();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.button3 = new System.Windows.Forms.Button();
			this.printDocument1 = new System.Drawing.Printing.PrintDocument();
			this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
			this.label5 = new System.Windows.Forms.Label();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.label12 = new System.Windows.Forms.Label();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.groupBox2.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Wide Latin", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(426, 21);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(499, 59);
			this.label1.TabIndex = 0;
			this.label1.Text = "பொருள் விற்பனை";
			// 
			// comboBox2
			// 
			this.comboBox2.Font = new System.Drawing.Font("News706 BT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.comboBox2.FormattingEnabled = true;
			this.comboBox2.Location = new System.Drawing.Point(481, 35);
			this.comboBox2.Name = "comboBox2";
			this.comboBox2.Size = new System.Drawing.Size(165, 27);
			this.comboBox2.TabIndex = 14;
			this.comboBox2.Text = "தேர்ந்தெடு";
			this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
			// 
			// comboBox1
			// 
			this.comboBox1.Font = new System.Drawing.Font("News706 BT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Location = new System.Drawing.Point(253, 35);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(165, 27);
			this.comboBox1.TabIndex = 13;
			this.comboBox1.Text = "தேர்ந்தெடு";
			this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
			// 
			// textBox1
			// 
			this.textBox1.Enabled = false;
			this.textBox1.Font = new System.Drawing.Font("News706 BT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBox1.Location = new System.Drawing.Point(20, 35);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(165, 27);
			this.textBox1.TabIndex = 12;
			this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
			// 
			// prdPrice
			// 
			this.prdPrice.Font = new System.Drawing.Font("News706 BT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.prdPrice.Location = new System.Drawing.Point(720, 35);
			this.prdPrice.Name = "prdPrice";
			this.prdPrice.Size = new System.Drawing.Size(109, 27);
			this.prdPrice.TabIndex = 15;
			this.prdPrice.TextChanged += new System.EventHandler(this.prdPrice_TextChanged);
			this.prdPrice.DoubleClick += new System.EventHandler(this.Price_Change);
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.Color.White;
			this.button1.Font = new System.Drawing.Font("News701 BT", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.button1.Location = new System.Drawing.Point(1137, 29);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(119, 40);
			this.button1.TabIndex = 17;
			this.button1.Text = "சேர்";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.comboBox3);
			this.groupBox1.Controls.Add(this.qtyValue);
			this.groupBox1.Controls.Add(this.comboBox1);
			this.groupBox1.Controls.Add(this.button1);
			this.groupBox1.Controls.Add(this.textBox1);
			this.groupBox1.Controls.Add(this.comboBox2);
			this.groupBox1.Controls.Add(this.prdPrice);
			this.groupBox1.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox1.Location = new System.Drawing.Point(25, 144);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(1275, 92);
			this.groupBox1.TabIndex = 18;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "பொருளின் விவரம்";
			// 
			// comboBox3
			// 
			this.comboBox3.Font = new System.Drawing.Font("News706 BT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.comboBox3.FormattingEnabled = true;
			this.comboBox3.Items.AddRange(new object[] {
            "கிலோ",
            "லிட்டர்"});
			this.comboBox3.Location = new System.Drawing.Point(989, 35);
			this.comboBox3.Name = "comboBox3";
			this.comboBox3.Size = new System.Drawing.Size(75, 27);
			this.comboBox3.TabIndex = 19;
			this.comboBox3.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
			// 
			// qtyValue
			// 
			this.qtyValue.Font = new System.Drawing.Font("News706 BT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.qtyValue.Location = new System.Drawing.Point(905, 35);
			this.qtyValue.Name = "qtyValue";
			this.qtyValue.Size = new System.Drawing.Size(85, 27);
			this.qtyValue.TabIndex = 18;
			this.qtyValue.TextChanged += new System.EventHandler(this.qtyValue_TextChanged);
			this.qtyValue.KeyDown += new System.Windows.Forms.KeyEventHandler(this.qtyValue_KeyDown);
			// 
			// button2
			// 
			this.button2.BackColor = System.Drawing.Color.White;
			this.button2.Font = new System.Drawing.Font("News701 BT", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.button2.Location = new System.Drawing.Point(1121, 662);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(148, 46);
			this.button2.TabIndex = 18;
			this.button2.Text = "பின் செல்ல";
			this.button2.UseVisualStyleBackColor = false;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// dataGridView1
			// 
			this.dataGridView1.AllowUserToAddRows = false;
			this.dataGridView1.AllowUserToDeleteRows = false;
			this.dataGridView1.AllowUserToResizeColumns = false;
			this.dataGridView1.AllowUserToResizeRows = false;
			dataGridViewCellStyle1.BackColor = System.Drawing.Color.Silver;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
			this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
			this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.productid,
            this.productname,
            this.price,
            this.qty,
            this.oriQty,
            this.weightType,
            this.totalprice});
			this.dataGridView1.Location = new System.Drawing.Point(25, 358);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(1018, 329);
			this.dataGridView1.TabIndex = 19;
			// 
			// id
			// 
			this.id.FillWeight = 94.68761F;
			this.id.HeaderText = "வரிசை எண்";
			this.id.Name = "id";
			// 
			// productid
			// 
			this.productid.HeaderText = "Product ID";
			this.productid.Name = "productid";
			this.productid.Visible = false;
			// 
			// productname
			// 
			this.productname.FillWeight = 99.5038F;
			this.productname.HeaderText = "பொருளின் பெயர்";
			this.productname.Name = "productname";
			// 
			// price
			// 
			this.price.FillWeight = 103.0859F;
			this.price.HeaderText = "பொருளின் விலை";
			this.price.Name = "price";
			// 
			// qty
			// 
			this.qty.FillWeight = 102.4721F;
			this.qty.HeaderText = "எண்ணிக்கை";
			this.qty.Name = "qty";
			// 
			// oriQty
			// 
			this.oriQty.HeaderText = "OriginalQuantity";
			this.oriQty.Name = "oriQty";
			this.oriQty.Visible = false;
			// 
			// weightType
			// 
			this.weightType.FillWeight = 50F;
			this.weightType.HeaderText = "எ.வகை";
			this.weightType.Name = "weightType";
			// 
			// totalprice
			// 
			this.totalprice.FillWeight = 100.2506F;
			this.totalprice.HeaderText = "மொத்த விலை";
			this.totalprice.Name = "totalprice";
			// 
			// label2
			// 
			this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(1079, 42);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(180, 21);
			this.label2.TabIndex = 0;
			this.label2.Text = "2018:10:21 08:08:32";
			// 
			// timer1
			// 
			this.timer1.Enabled = true;
			this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(723, 719);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(154, 25);
			this.label3.TabIndex = 20;
			this.label3.Text = "மொத்த விலை";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(927, 719);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(25, 25);
			this.label4.TabIndex = 21;
			this.label4.Text = "0";
			// 
			// button3
			// 
			this.button3.BackColor = System.Drawing.Color.White;
			this.button3.Font = new System.Drawing.Font("News701 BT", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.button3.Location = new System.Drawing.Point(1121, 290);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(148, 46);
			this.button3.TabIndex = 22;
			this.button3.Text = "அச்சிடு";
			this.button3.UseVisualStyleBackColor = false;
			this.button3.Click += new System.EventHandler(this.button3_Click);
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
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("News706 BT", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(1146, 84);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(51, 39);
			this.label5.TabIndex = 23;
			this.label5.Text = "10";
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.textBox3);
			this.groupBox2.Controls.Add(this.textBox2);
			this.groupBox2.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold);
			this.groupBox2.Location = new System.Drawing.Point(25, 260);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(529, 67);
			this.groupBox2.TabIndex = 24;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "வாடிக்கையாளர் விவரம்";
			// 
			// textBox3
			// 
			this.textBox3.Font = new System.Drawing.Font("News706 BT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBox3.Location = new System.Drawing.Point(319, 29);
			this.textBox3.Name = "textBox3";
			this.textBox3.Size = new System.Drawing.Size(158, 27);
			this.textBox3.TabIndex = 17;
			this.textBox3.Enter += new System.EventHandler(this.textBox3_Enter);
			this.textBox3.Leave += new System.EventHandler(this.textBox3_Leave);
			// 
			// textBox2
			// 
			this.textBox2.Font = new System.Drawing.Font("News706 BT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBox2.Location = new System.Drawing.Point(71, 29);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(158, 27);
			this.textBox2.TabIndex = 16;
			this.textBox2.Enter += new System.EventHandler(this.textBox2_Enter);
			this.textBox2.Leave += new System.EventHandler(this.textBox2_Leave);
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.label6.Font = new System.Drawing.Font("News706 BT", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(1055, 392);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(296, 31);
			this.label6.TabIndex = 25;
			this.label6.Text = "கடைசி விற்பனை விவரம்";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.label7.Font = new System.Drawing.Font("News701 BT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(1094, 459);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(116, 22);
			this.label7.TabIndex = 26;
			this.label7.Text = "விற்பனை எண்";
			this.label7.Click += new System.EventHandler(this.label7_Click);
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.label8.Font = new System.Drawing.Font("News701 BT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.Location = new System.Drawing.Point(1049, 517);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(161, 22);
			this.label8.TabIndex = 27;
			this.label8.Text = "மொத்த எண்ணிக்கை";
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.label9.Font = new System.Drawing.Font("News701 BT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label9.Location = new System.Drawing.Point(1095, 576);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(115, 22);
			this.label9.TabIndex = 28;
			this.label9.Text = "மொத்த மதிப்பு";
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.label10.Font = new System.Drawing.Font("News701 BT", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label10.Location = new System.Drawing.Point(1215, 462);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(132, 18);
			this.label10.TabIndex = 29;
			this.label10.Text = "VKSSTRORD0001";
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.label11.Font = new System.Drawing.Font("News701 BT", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label11.Location = new System.Drawing.Point(1215, 520);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(38, 18);
			this.label11.TabIndex = 30;
			this.label11.Text = "1000";
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.label12.Font = new System.Drawing.Font("News701 BT", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label12.Location = new System.Drawing.Point(1215, 580);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(60, 18);
			this.label12.TabIndex = 31;
			this.label12.Text = "1,00,000";
			// 
			// OrderPage
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
			this.ClientSize = new System.Drawing.Size(1357, 755);
			this.ControlBox = false;
			this.Controls.Add(this.label12);
			this.Controls.Add(this.label11);
			this.Controls.Add(this.label10);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.label1);
			this.Name = "OrderPage";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Load += new System.EventHandler(this.OrderPage_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox prdPrice;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox qtyValue;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.Label label5;
		private System.Windows.Forms.ComboBox comboBox3;
		private System.Windows.Forms.DataGridViewTextBoxColumn id;
		private System.Windows.Forms.DataGridViewTextBoxColumn productid;
		private System.Windows.Forms.DataGridViewTextBoxColumn productname;
		private System.Windows.Forms.DataGridViewTextBoxColumn price;
		private System.Windows.Forms.DataGridViewTextBoxColumn qty;
		private System.Windows.Forms.DataGridViewTextBoxColumn oriQty;
		private System.Windows.Forms.DataGridViewTextBoxColumn weightType;
		private System.Windows.Forms.DataGridViewTextBoxColumn totalprice;
		private System.Drawing.Printing.PrintDocument printDocument1;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.TextBox textBox3;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label label12;
	}
}