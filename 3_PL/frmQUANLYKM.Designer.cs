namespace _3_PL
{
    partial class frmQUANLYKM
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btxoaKM = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btresetdatagv = new System.Windows.Forms.Button();
            this.dtgv = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NGAYBATDAU = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NGAYKETTHUC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DIENRAKM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btTimkiemKMTheoTime = new System.Windows.Forms.Button();
            this.btThemKM = new System.Windows.Forms.Button();
            this.btSUa = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btcliar = new System.Windows.Forms.Button();
            this.dtngaykethuc = new System.Windows.Forms.DateTimePicker();
            this.dtngaybatdau = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbptKM = new System.Windows.Forms.TextBox();
            this.tbTenKM = new System.Windows.Forms.TextBox();
            this.tbidKM = new System.Windows.Forms.TextBox();
            this.btXUatex = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.LightBlue;
            this.groupBox1.Controls.Add(this.btxoaKM);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.btThemKM);
            this.groupBox1.Controls.Add(this.btSUa);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.btXUatex);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(13, 12);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Size = new System.Drawing.Size(1115, 696);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "QUẢN LÝ KHUYẾN MÃI";
            // 
            // btxoaKM
            // 
            this.btxoaKM.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btxoaKM.Location = new System.Drawing.Point(670, 148);
            this.btxoaKM.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btxoaKM.Name = "btxoaKM";
            this.btxoaKM.Size = new System.Drawing.Size(161, 41);
            this.btxoaKM.TabIndex = 7;
            this.btxoaKM.Text = "XÓA KHUYẾN MÃI";
            this.btxoaKM.UseVisualStyleBackColor = true;
            this.btxoaKM.Click += new System.EventHandler(this.button7_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btresetdatagv);
            this.groupBox3.Controls.Add(this.dtgv);
            this.groupBox3.Controls.Add(this.btTimkiemKMTheoTime);
            this.groupBox3.Location = new System.Drawing.Point(8, 372);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox3.Size = new System.Drawing.Size(1114, 318);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Danh Sách Khuyến Mãi";
            // 
            // btresetdatagv
            // 
            this.btresetdatagv.Location = new System.Drawing.Point(824, 32);
            this.btresetdatagv.Name = "btresetdatagv";
            this.btresetdatagv.Size = new System.Drawing.Size(161, 27);
            this.btresetdatagv.TabIndex = 16;
            this.btresetdatagv.Text = "Refresh";
            this.btresetdatagv.UseVisualStyleBackColor = true;
            this.btresetdatagv.Click += new System.EventHandler(this.button4_Click_1);
            // 
            // dtgv
            // 
            this.dtgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.NGAYBATDAU,
            this.NGAYKETTHUC,
            this.DIENRAKM,
            this.dataGridViewTextBoxColumn1});
            this.dtgv.Location = new System.Drawing.Point(7, 67);
            this.dtgv.Name = "dtgv";
            this.dtgv.ReadOnly = true;
            this.dtgv.RowTemplate.Height = 25;
            this.dtgv.Size = new System.Drawing.Size(1083, 245);
            this.dtgv.TabIndex = 9;
            this.dtgv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // ID
            // 
            this.ID.DataPropertyName = "Id";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // NGAYBATDAU
            // 
            this.NGAYBATDAU.DataPropertyName = "Name";
            this.NGAYBATDAU.HeaderText = "TÊN KHUYẾN MÃI";
            this.NGAYBATDAU.Name = "NGAYBATDAU";
            this.NGAYBATDAU.ReadOnly = true;
            // 
            // NGAYKETTHUC
            // 
            this.NGAYKETTHUC.DataPropertyName = "CreateDate";
            this.NGAYKETTHUC.HeaderText = "NGÀY BẮT ĐẦU";
            this.NGAYKETTHUC.Name = "NGAYKETTHUC";
            this.NGAYKETTHUC.ReadOnly = true;
            // 
            // DIENRAKM
            // 
            this.DIENRAKM.DataPropertyName = "EndDate";
            this.DIENRAKM.HeaderText = "NGÀY KẾT THÚC";
            this.DIENRAKM.Name = "DIENRAKM";
            this.DIENRAKM.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Index";
            this.dataGridViewTextBoxColumn1.HeaderText = "% KHUYẾN MÃI";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // btTimkiemKMTheoTime
            // 
            this.btTimkiemKMTheoTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btTimkiemKMTheoTime.Location = new System.Drawing.Point(420, 32);
            this.btTimkiemKMTheoTime.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btTimkiemKMTheoTime.Name = "btTimkiemKMTheoTime";
            this.btTimkiemKMTheoTime.Size = new System.Drawing.Size(167, 25);
            this.btTimkiemKMTheoTime.TabIndex = 3;
            this.btTimkiemKMTheoTime.Text = "TÌM KIẾM KHUYẾN MÃI THEO THỜI GIAN";
            this.btTimkiemKMTheoTime.UseVisualStyleBackColor = true;
            this.btTimkiemKMTheoTime.Click += new System.EventHandler(this.button1_Click);
            // 
            // btThemKM
            // 
            this.btThemKM.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btThemKM.Location = new System.Drawing.Point(670, 213);
            this.btThemKM.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btThemKM.Name = "btThemKM";
            this.btThemKM.Size = new System.Drawing.Size(161, 41);
            this.btThemKM.TabIndex = 5;
            this.btThemKM.Text = "Thêm Khuyến Mãi";
            this.btThemKM.UseVisualStyleBackColor = true;
            this.btThemKM.Click += new System.EventHandler(this.button3_Click);
            // 
            // btSUa
            // 
            this.btSUa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btSUa.Location = new System.Drawing.Point(871, 147);
            this.btSUa.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btSUa.Name = "btSUa";
            this.btSUa.Size = new System.Drawing.Size(161, 41);
            this.btSUa.TabIndex = 4;
            this.btSUa.Text = "Sửa Khuyến Mãi";
            this.btSUa.UseVisualStyleBackColor = true;
            this.btSUa.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.LightBlue;
            this.groupBox2.Controls.Add(this.btcliar);
            this.groupBox2.Controls.Add(this.dtngaykethuc);
            this.groupBox2.Controls.Add(this.dtngaybatdau);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.tbptKM);
            this.groupBox2.Controls.Add(this.tbTenKM);
            this.groupBox2.Controls.Add(this.tbidKM);
            this.groupBox2.Location = new System.Drawing.Point(43, 63);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox2.Size = new System.Drawing.Size(552, 286);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông Tin KM";
            // 
            // btcliar
            // 
            this.btcliar.Location = new System.Drawing.Point(447, 21);
            this.btcliar.Name = "btcliar";
            this.btcliar.Size = new System.Drawing.Size(88, 33);
            this.btcliar.TabIndex = 8;
            this.btcliar.Text = "Làm Mới";
            this.btcliar.UseVisualStyleBackColor = true;
            this.btcliar.Click += new System.EventHandler(this.button8_Click);
            this.btcliar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.button8_MouseDown);
            // 
            // dtngaykethuc
            // 
            this.dtngaykethuc.CustomFormat = "dd/MM/yyyy";
            this.dtngaykethuc.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtngaykethuc.Location = new System.Drawing.Point(148, 188);
            this.dtngaykethuc.Name = "dtngaykethuc";
            this.dtngaykethuc.Size = new System.Drawing.Size(119, 21);
            this.dtngaykethuc.TabIndex = 15;
            // 
            // dtngaybatdau
            // 
            this.dtngaybatdau.CustomFormat = "dd/MM/yyyy";
            this.dtngaybatdau.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtngaybatdau.Location = new System.Drawing.Point(148, 138);
            this.dtngaybatdau.Name = "dtngaybatdau";
            this.dtngaybatdau.RightToLeftLayout = true;
            this.dtngaybatdau.Size = new System.Drawing.Size(119, 21);
            this.dtngaybatdau.TabIndex = 14;
            this.dtngaybatdau.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(12, 244);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 16);
            this.label5.TabIndex = 13;
            this.label5.Text = "SỐ %";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(12, 191);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 16);
            this.label4.TabIndex = 12;
            this.label4.Text = "Ngày Kết Thúc";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(12, 143);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(90, 16);
            this.label8.TabIndex = 11;
            this.label8.Text = "Ngày Bắt Đầu";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(12, 85);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(103, 16);
            this.label7.TabIndex = 10;
            this.label7.Text = "Tên Khuyến Mãi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 87);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 16);
            this.label3.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(12, 38);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "ID Khuyến Mãi";
            // 
            // tbptKM
            // 
            this.tbptKM.Location = new System.Drawing.Point(148, 239);
            this.tbptKM.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbptKM.Name = "tbptKM";
            this.tbptKM.Size = new System.Drawing.Size(241, 21);
            this.tbptKM.TabIndex = 4;
            // 
            // tbTenKM
            // 
            this.tbTenKM.Location = new System.Drawing.Point(148, 84);
            this.tbTenKM.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbTenKM.Name = "tbTenKM";
            this.tbTenKM.Size = new System.Drawing.Size(241, 21);
            this.tbTenKM.TabIndex = 1;
            // 
            // tbidKM
            // 
            this.tbidKM.Location = new System.Drawing.Point(148, 31);
            this.tbidKM.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbidKM.Name = "tbidKM";
            this.tbidKM.Size = new System.Drawing.Size(241, 21);
            this.tbidKM.TabIndex = 0;
            // 
            // btXUatex
            // 
            this.btXUatex.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btXUatex.Location = new System.Drawing.Point(871, 213);
            this.btXUatex.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btXUatex.Name = "btXUatex";
            this.btXUatex.Size = new System.Drawing.Size(161, 41);
            this.btXUatex.TabIndex = 6;
            this.btXUatex.Text = "Xuất THÔNG TIN KM";
            this.btXUatex.UseVisualStyleBackColor = true;
            this.btXUatex.Click += new System.EventHandler(this.button5_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(357, 17);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "THÔNG TIN KHUYẾN MÃI";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmQUANLYKM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1141, 714);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmQUANLYKM";
            this.Text = "frmQUANLYKM";
            this.Load += new System.EventHandler(this.frmQUANLYKM_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgv)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private Button btXUatex;
        private GroupBox groupBox3;
        private Button btThemKM;
        private Button btSUa;
        private Button btTimkiemKMTheoTime;
        private GroupBox groupBox2;
        private Label label5;
        private Label label4;
        private Label label8;
        private Label label7;
        private Label label3;
        private Label label2;
        private TextBox tbptKM;
        private TextBox tbTenKM;
        private TextBox tbidKM;
        private Label label1;
        private DateTimePicker dtngaykethuc;
        private DateTimePicker dtngaybatdau;
        private DataGridView dtgv;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn NGAYBATDAU;
        private DataGridViewTextBoxColumn NGAYKETTHUC;
        private DataGridViewTextBoxColumn DIENRAKM;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private Button btxoaKM;
        private Button btcliar;
        private Button btresetdatagv;
        private ErrorProvider errorProvider1;
    }
}