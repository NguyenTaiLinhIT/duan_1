namespace FrmDuAn1
{
    partial class BanHang
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            dateTimePicker1 = new DateTimePicker();
            groupBox1 = new GroupBox();
            button9 = new Button();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            dataGridView1 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            groupBox2 = new GroupBox();
            comboBox4 = new ComboBox();
            label18 = new Label();
            panel1 = new Panel();
            comboBox2 = new ComboBox();
            comboBox1 = new ComboBox();
            textBox6 = new TextBox();
            label8 = new Label();
            label7 = new Label();
            button8 = new Button();
            button7 = new Button();
            dataGridView2 = new DataGridView();
            Column7 = new DataGridViewTextBoxColumn();
            Column8 = new DataGridViewTextBoxColumn();
            Column9 = new DataGridViewTextBoxColumn();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            button5 = new Button();
            groupBox3 = new GroupBox();
            label19 = new Label();
            textBox10 = new TextBox();
            label16 = new Label();
            textBox9 = new TextBox();
            label17 = new Label();
            label14 = new Label();
            textBox8 = new TextBox();
            label15 = new Label();
            comboBox3 = new ComboBox();
            label13 = new Label();
            textBox7 = new TextBox();
            label12 = new Label();
            button6 = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(16, -2);
            label1.Name = "label1";
            label1.Size = new Size(150, 41);
            label1.TabIndex = 0;
            label1.Text = "Bán hàng";
            label1.Click += label1_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(1000, 12);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(250, 27);
            dateTimePicker1.TabIndex = 1;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.LightBlue;
            groupBox1.Controls.Add(button9);
            groupBox1.Controls.Add(button4);
            groupBox1.Controls.Add(button3);
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(dataGridView1);
            groupBox1.ForeColor = Color.Black;
            groupBox1.Location = new Point(25, 59);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(748, 288);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Giỏ hàng";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // button9
            // 
            button9.Location = new Point(290, 238);
            button9.Name = "button9";
            button9.Size = new Size(115, 29);
            button9.TabIndex = 5;
            button9.Text = "Tăng số lượng";
            button9.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(554, 238);
            button4.Name = "button4";
            button4.Size = new Size(153, 29);
            button4.TabIndex = 4;
            button4.Text = "Thêm vào đơn hàng";
            button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(421, 238);
            button3.Name = "button3";
            button3.Size = new Size(120, 29);
            button3.TabIndex = 3;
            button3.Text = "Giảm số lượng";
            button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(152, 238);
            button2.Name = "button2";
            button2.Size = new Size(119, 29);
            button2.TabIndex = 2;
            button2.Text = "Xóa giỏ hàng";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(23, 238);
            button1.Name = "button1";
            button1.Size = new Size(113, 29);
            button1.TabIndex = 1;
            button1.Text = "Xóa sản phẩm";
            button1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeight = 29;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column6 });
            dataGridView1.Location = new Point(23, 28);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(684, 204);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Column1
            // 
            Column1.HeaderText = "Mã sản phẩm";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            // 
            // Column2
            // 
            Column2.HeaderText = "Tên sản phẩm";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            // 
            // Column3
            // 
            Column3.HeaderText = "Đơn giá";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            // 
            // Column4
            // 
            Column4.HeaderText = "Số lượng";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            // 
            // Column6
            // 
            Column6.HeaderText = "Thành tiền";
            Column6.MinimumWidth = 6;
            Column6.Name = "Column6";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(comboBox4);
            groupBox2.Controls.Add(label18);
            groupBox2.Controls.Add(panel1);
            groupBox2.Controls.Add(comboBox2);
            groupBox2.Controls.Add(comboBox1);
            groupBox2.Controls.Add(textBox6);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(button8);
            groupBox2.Controls.Add(button7);
            groupBox2.Controls.Add(dataGridView2);
            groupBox2.Location = new Point(25, 353);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(748, 308);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "Danh sách sản phẩm";
            // 
            // comboBox4
            // 
            comboBox4.FormattingEnabled = true;
            comboBox4.Location = new Point(375, 73);
            comboBox4.Name = "comboBox4";
            comboBox4.Size = new Size(151, 28);
            comboBox4.TabIndex = 11;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(333, 78);
            label18.Name = "label18";
            label18.Size = new Size(31, 20);
            label18.TabIndex = 10;
            label18.Text = "Giá";
            label18.Click += label18_Click;
            // 
            // panel1
            // 
            panel1.Location = new Point(533, 152);
            panel1.Name = "panel1";
            panel1.Size = new Size(209, 138);
            panel1.TabIndex = 9;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(141, 117);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(151, 28);
            comboBox2.TabIndex = 8;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(141, 73);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 28);
            comboBox1.TabIndex = 7;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(23, 31);
            textBox6.Name = "textBox6";
            textBox6.PlaceholderText = "Nhập tên sản phẩm";
            textBox6.Size = new Size(504, 27);
            textBox6.TabIndex = 6;
            textBox6.TextChanged += textBox6_TextChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(19, 120);
            label8.Name = "label8";
            label8.Size = new Size(108, 20);
            label8.TabIndex = 5;
            label8.Text = "Loại điện thoại";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(19, 78);
            label7.Name = "label7";
            label7.Size = new Size(113, 20);
            label7.TabIndex = 4;
            label7.Text = "Hãng sản phẩm";
            // 
            // button8
            // 
            button8.Location = new Point(591, 114);
            button8.Name = "button8";
            button8.Size = new Size(94, 29);
            button8.TabIndex = 3;
            button8.Text = "Quét mã";
            button8.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            button7.Location = new Point(573, 31);
            button7.Name = "button7";
            button7.Size = new Size(134, 29);
            button7.TabIndex = 2;
            button7.Text = "Tìm kiếm";
            button7.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView2.ColumnHeadersHeight = 29;
            dataGridView2.Columns.AddRange(new DataGridViewColumn[] { Column7, Column8, Column9 });
            dataGridView2.Location = new Point(15, 152);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.RowTemplate.Height = 29;
            dataGridView2.Size = new Size(512, 138);
            dataGridView2.TabIndex = 1;
            // 
            // Column7
            // 
            Column7.HeaderText = "Mã sản phẩm";
            Column7.MinimumWidth = 6;
            Column7.Name = "Column7";
            // 
            // Column8
            // 
            Column8.HeaderText = "Tên sản phẩm";
            Column8.MinimumWidth = 6;
            Column8.Name = "Column8";
            // 
            // Column9
            // 
            Column9.HeaderText = "Đơn giá";
            Column9.MinimumWidth = 6;
            Column9.Name = "Column9";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(376, 411);
            label9.Name = "label9";
            label9.Size = new Size(40, 20);
            label9.TabIndex = 34;
            label9.Text = "VND";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(376, 373);
            label10.Name = "label10";
            label10.Size = new Size(40, 20);
            label10.TabIndex = 33;
            label10.Text = "VND";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(376, 221);
            label11.Name = "label11";
            label11.Size = new Size(40, 20);
            label11.TabIndex = 32;
            label11.Text = "VND";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(195, 370);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(169, 27);
            textBox4.TabIndex = 31;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(195, 408);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(169, 27);
            textBox5.TabIndex = 30;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(195, 144);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(169, 27);
            textBox3.TabIndex = 29;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(195, 107);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(169, 27);
            textBox2.TabIndex = 28;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(195, 218);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(169, 27);
            textBox1.TabIndex = 27;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(47, 411);
            label6.Name = "label6";
            label6.Size = new Size(71, 20);
            label6.TabIndex = 26;
            label6.Text = "Tiền thừa";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(47, 373);
            label5.Name = "label5";
            label5.Size = new Size(124, 20);
            label5.TabIndex = 25;
            label5.Text = "Khách thanh toán";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(47, 221);
            label4.Name = "label4";
            label4.Size = new Size(72, 20);
            label4.TabIndex = 24;
            label4.Text = "Tổng tiền";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(47, 147);
            label3.Name = "label3";
            label3.Size = new Size(97, 20);
            label3.TabIndex = 23;
            label3.Text = "Số điện thoại";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(47, 110);
            label2.Name = "label2";
            label2.Size = new Size(111, 20);
            label2.TabIndex = 22;
            label2.Text = "Tên khách hàng";
            // 
            // button5
            // 
            button5.Location = new Point(270, 503);
            button5.Name = "button5";
            button5.Size = new Size(94, 29);
            button5.TabIndex = 20;
            button5.Text = "Thanh toán";
            button5.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(button6);
            groupBox3.Controls.Add(label19);
            groupBox3.Controls.Add(textBox10);
            groupBox3.Controls.Add(label16);
            groupBox3.Controls.Add(textBox9);
            groupBox3.Controls.Add(label17);
            groupBox3.Controls.Add(label14);
            groupBox3.Controls.Add(textBox8);
            groupBox3.Controls.Add(label15);
            groupBox3.Controls.Add(comboBox3);
            groupBox3.Controls.Add(label13);
            groupBox3.Controls.Add(textBox7);
            groupBox3.Controls.Add(label12);
            groupBox3.Controls.Add(textBox2);
            groupBox3.Controls.Add(label9);
            groupBox3.Controls.Add(button5);
            groupBox3.Controls.Add(label10);
            groupBox3.Controls.Add(label11);
            groupBox3.Controls.Add(label2);
            groupBox3.Controls.Add(textBox4);
            groupBox3.Controls.Add(label3);
            groupBox3.Controls.Add(textBox5);
            groupBox3.Controls.Add(label4);
            groupBox3.Controls.Add(textBox3);
            groupBox3.Controls.Add(label5);
            groupBox3.Controls.Add(label6);
            groupBox3.Controls.Add(textBox1);
            groupBox3.Location = new Point(779, 59);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(471, 602);
            groupBox3.TabIndex = 35;
            groupBox3.TabStop = false;
            groupBox3.Text = "Thông tin đơn hàng";
            groupBox3.Enter += groupBox3_Enter;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new Point(47, 184);
            label19.Name = "label19";
            label19.Size = new Size(137, 20);
            label19.TabIndex = 45;
            label19.Text = "Số lượng sản phẩm";
            // 
            // textBox10
            // 
            textBox10.Location = new Point(195, 181);
            textBox10.Name = "textBox10";
            textBox10.Size = new Size(169, 27);
            textBox10.TabIndex = 46;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(376, 335);
            label16.Name = "label16";
            label16.Size = new Size(40, 20);
            label16.TabIndex = 44;
            label16.Text = "VND";
            // 
            // textBox9
            // 
            textBox9.Location = new Point(195, 332);
            textBox9.Name = "textBox9";
            textBox9.Size = new Size(169, 27);
            textBox9.TabIndex = 43;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(47, 335);
            label17.Name = "label17";
            label17.Size = new Size(104, 20);
            label17.TabIndex = 42;
            label17.Text = "Khách phải trả";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(376, 296);
            label14.Name = "label14";
            label14.Size = new Size(40, 20);
            label14.TabIndex = 41;
            label14.Text = "VND";
            // 
            // textBox8
            // 
            textBox8.Location = new Point(195, 293);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(169, 27);
            textBox8.TabIndex = 40;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(47, 296);
            label15.Name = "label15";
            label15.Size = new Size(69, 20);
            label15.TabIndex = 39;
            label15.Text = "Giảm giá";
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Location = new Point(195, 254);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(169, 28);
            comboBox3.TabIndex = 38;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(47, 258);
            label13.Name = "label13";
            label13.Size = new Size(86, 20);
            label13.TabIndex = 37;
            label13.Text = "Khuyến mãi";
            // 
            // textBox7
            // 
            textBox7.Location = new Point(195, 73);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(169, 27);
            textBox7.TabIndex = 36;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(47, 76);
            label12.Name = "label12";
            label12.Size = new Size(83, 20);
            label12.TabIndex = 35;
            label12.Text = "ID hóa đơn";
            // 
            // button6
            // 
            button6.Location = new Point(79, 499);
            button6.Name = "button6";
            button6.Size = new Size(119, 29);
            button6.TabIndex = 47;
            button6.Text = "Hủy đơn hàng";
            button6.UseVisualStyleBackColor = true;
            // 
            // BanHang
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightBlue;
            ClientSize = new Size(1262, 673);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(dateTimePicker1);
            Controls.Add(label1);
            Name = "BanHang";
            Text = "BanHang";
            Load += BanHang_Load;
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DateTimePicker dateTimePicker1;
        private GroupBox groupBox1;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button1;
        private DataGridView dataGridView1;
        private GroupBox groupBox2;
        private ComboBox comboBox2;
        private ComboBox comboBox1;
        private TextBox textBox6;
        private Label label8;
        private Label label7;
        private Button button8;
        private Button button7;
        private DataGridView dataGridView2;
        private DataGridViewTextBoxColumn Column7;
        private DataGridViewTextBoxColumn Column8;
        private DataGridViewTextBoxColumn Column9;
        private Panel panel1;
        private Label label9;
        private Label label10;
        private Label label11;
        private TextBox textBox4;
        private TextBox textBox5;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Button button5;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column6;
        private Button button9;
        private GroupBox groupBox3;
        private ComboBox comboBox4;
        private Label label18;
        private Label label16;
        private TextBox textBox9;
        private Label label17;
        private Label label14;
        private TextBox textBox8;
        private Label label15;
        private ComboBox comboBox3;
        private Label label13;
        private TextBox textBox7;
        private Label label12;
        private Label label19;
        private TextBox textBox10;
        private Button button6;
    }
}