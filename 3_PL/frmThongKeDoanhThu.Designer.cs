namespace FrmDuAn1
{
    partial class frmThongKeDoanhThu
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
            label1 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            dateTimePicker1 = new DateTimePicker();
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            comboBox3 = new ComboBox();
            groupBox1 = new GroupBox();
            panel1 = new Panel();
            label2 = new Label();
            label3 = new Label();
            panel2 = new Panel();
            label5 = new Label();
            label4 = new Label();
            label6 = new Label();
            panel3 = new Panel();
            label8 = new Label();
            label7 = new Label();
            dataGridView1 = new DataGridView();
            Column5 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column1 = new DataGridViewTextBoxColumn();
            groupBox2 = new GroupBox();
            groupBox1.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(17, 9);
            label1.Name = "label1";
            label1.Size = new Size(303, 41);
            label1.TabIndex = 0;
            label1.Text = "Thống kê doanh thu";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(27, 29);
            label9.Name = "label9";
            label9.Size = new Size(78, 20);
            label9.TabIndex = 0;
            label9.Text = "Theo ngày";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(27, 72);
            label10.Name = "label10";
            label10.Size = new Size(120, 20);
            label10.TabIndex = 1;
            label10.Text = "Theo tháng, năm";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(433, 29);
            label11.Name = "label11";
            label11.Size = new Size(96, 20);
            label11.TabIndex = 2;
            label11.Text = "Sắp xếp theo";
            label11.Click += label11_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(149, 27);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(250, 27);
            dateTimePicker1.TabIndex = 3;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(151, 69);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(90, 28);
            comboBox1.TabIndex = 4;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(283, 69);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(116, 28);
            comboBox2.TabIndex = 5;
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Location = new Point(536, 26);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(151, 28);
            comboBox3.TabIndex = 6;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.LightBlue;
            groupBox1.Controls.Add(comboBox3);
            groupBox1.Controls.Add(comboBox2);
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Controls.Add(dateTimePicker1);
            groupBox1.Controls.Add(label11);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(label9);
            groupBox1.Location = new Point(44, 79);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(706, 125);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Lọc";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // panel1
            // 
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(92, 26);
            panel1.Name = "panel1";
            panel1.Size = new Size(250, 125);
            panel1.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(31, 20);
            label2.Name = "label2";
            label2.Size = new Size(121, 20);
            label2.TabIndex = 0;
            label2.Text = "Tổng số hóa đơn";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(105, 73);
            label3.Name = "label3";
            label3.Size = new Size(25, 20);
            label3.TabIndex = 1;
            label3.Text = "30";
            // 
            // panel2
            // 
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label5);
            panel2.Location = new Point(405, 26);
            panel2.Name = "panel2";
            panel2.Size = new Size(250, 125);
            panel2.TabIndex = 2;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(31, 20);
            label5.Name = "label5";
            label5.Size = new Size(78, 20);
            label5.TabIndex = 0;
            label5.Text = "Doanh thu";
            label5.Click += label5_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(68, 73);
            label4.Name = "label4";
            label4.Size = new Size(87, 20);
            label4.TabIndex = 1;
            label4.Text = "100.000.000";
            label4.Click += label4_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(153, 73);
            label6.Name = "label6";
            label6.Size = new Size(40, 20);
            label6.TabIndex = 2;
            label6.Text = "VND";
            // 
            // panel3
            // 
            panel3.Controls.Add(label7);
            panel3.Controls.Add(label8);
            panel3.Location = new Point(711, 26);
            panel3.Name = "panel3";
            panel3.Size = new Size(236, 125);
            panel3.TabIndex = 2;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(32, 20);
            label8.Name = "label8";
            label8.Size = new Size(180, 20);
            label8.TabIndex = 0;
            label8.Text = "Tổng số sản phẩm đã bán";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(105, 73);
            label7.Name = "label7";
            label7.Size = new Size(25, 20);
            label7.TabIndex = 1;
            label7.Text = "40";
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeight = 29;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5 });
            dataGridView1.Location = new Point(27, 172);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.ScrollBars = ScrollBars.None;
            dataGridView1.Size = new Size(1120, 240);
            dataGridView1.TabIndex = 3;
            // 
            // Column5
            // 
            Column5.HeaderText = "Doanh thu";
            Column5.MinimumWidth = 6;
            Column5.Name = "Column5";
            // 
            // Column4
            // 
            Column4.HeaderText = "Số lượng bán";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            // 
            // Column3
            // 
            Column3.HeaderText = "Giá bán";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            // 
            // Column2
            // 
            Column2.HeaderText = "Tên sản phẩm";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            // 
            // Column1
            // 
            Column1.HeaderText = "Mã sản phẩm";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dataGridView1);
            groupBox2.Controls.Add(panel3);
            groupBox2.Controls.Add(panel2);
            groupBox2.Controls.Add(panel1);
            groupBox2.Location = new Point(44, 228);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1176, 419);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Thống kê";
            // 
            // ThongKeDoanhThu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightBlue;
            ClientSize = new Size(1262, 673);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Name = "ThongKeDoanhThu";
            Text = "ThongKeDoanhThu";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label9;
        private Label label10;
        private Label label11;
        private DateTimePicker dateTimePicker1;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private ComboBox comboBox3;
        private GroupBox groupBox1;
        private Panel panel1;
        private Label label3;
        private Label label2;
        private Panel panel2;
        private Label label6;
        private Label label4;
        private Label label5;
        private Panel panel3;
        private Label label7;
        private Label label8;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private GroupBox groupBox2;
    }
}