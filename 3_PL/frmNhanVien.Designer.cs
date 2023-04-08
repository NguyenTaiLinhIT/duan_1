namespace _3_PL
{
    partial class frmNhanVien
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btn_suanv = new System.Windows.Forms.Button();
            this.btn_themnv = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cbb_loc_theo_trang_thai = new System.Windows.Forms.ComboBox();
            this.cbb_loc_theo_chuc_vu = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dgv_danhsach = new System.Windows.Forms.DataGridView();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txb_timkiem = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.rb_nhanvien = new System.Windows.Forms.RadioButton();
            this.rb_quanly = new System.Windows.Forms.RadioButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.rb_khonghd = new System.Windows.Forms.RadioButton();
            this.rb_danghd = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rb_nu = new System.Windows.Forms.RadioButton();
            this.rb_nam = new System.Windows.Forms.RadioButton();
            this.ptb_nhanvien = new System.Windows.Forms.PictureBox();
            this.txb_matkhau = new System.Windows.Forms.TextBox();
            this.txb_taikhoan = new System.Windows.Forms.TextBox();
            this.dtp_ngaysinh = new System.Windows.Forms.DateTimePicker();
            this.txb_sdt = new System.Windows.Forms.TextBox();
            this.txb_hovaten = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lb_hovatennv = new System.Windows.Forms.Label();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_danhsach)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_nhanvien)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.LightBlue;
            this.groupBox3.Controls.Add(this.btn_suanv);
            this.groupBox3.Controls.Add(this.btn_themnv);
            this.groupBox3.Location = new System.Drawing.Point(1134, 40);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Size = new System.Drawing.Size(214, 462);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Chức Năng:";
            // 
            // btn_suanv
            // 
            this.btn_suanv.Location = new System.Drawing.Point(33, 99);
            this.btn_suanv.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_suanv.Name = "btn_suanv";
            this.btn_suanv.Size = new System.Drawing.Size(151, 38);
            this.btn_suanv.TabIndex = 2;
            this.btn_suanv.Text = "Sửa Nhân Viên";
            this.btn_suanv.UseVisualStyleBackColor = true;
            this.btn_suanv.Click += new System.EventHandler(this.btn_suanv_Click);
            // 
            // btn_themnv
            // 
            this.btn_themnv.Location = new System.Drawing.Point(33, 38);
            this.btn_themnv.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_themnv.Name = "btn_themnv";
            this.btn_themnv.Size = new System.Drawing.Size(151, 38);
            this.btn_themnv.TabIndex = 1;
            this.btn_themnv.Text = "Thêm Nhân Viên";
            this.btn_themnv.UseVisualStyleBackColor = true;
            this.btn_themnv.Click += new System.EventHandler(this.btn_themnv_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.LightBlue;
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.cbb_loc_theo_trang_thai);
            this.groupBox2.Controls.Add(this.cbb_loc_theo_chuc_vu);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.dgv_danhsach);
            this.groupBox2.Controls.Add(this.txb_timkiem);
            this.groupBox2.Location = new System.Drawing.Point(11, 296);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(1117, 230);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh Sách";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(786, 20);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(115, 15);
            this.label10.TabIndex = 35;
            this.label10.Text = "Lọc Theo Trạng Thái:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(469, 20);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(106, 15);
            this.label9.TabIndex = 34;
            this.label9.Text = "Lọc Theo Chức Vụ:";
            // 
            // cbb_loc_theo_trang_thai
            // 
            this.cbb_loc_theo_trang_thai.FormattingEnabled = true;
            this.cbb_loc_theo_trang_thai.Location = new System.Drawing.Point(918, 18);
            this.cbb_loc_theo_trang_thai.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbb_loc_theo_trang_thai.Name = "cbb_loc_theo_trang_thai";
            this.cbb_loc_theo_trang_thai.Size = new System.Drawing.Size(187, 23);
            this.cbb_loc_theo_trang_thai.TabIndex = 22;
            // 
            // cbb_loc_theo_chuc_vu
            // 
            this.cbb_loc_theo_chuc_vu.FormattingEnabled = true;
            this.cbb_loc_theo_chuc_vu.Location = new System.Drawing.Point(588, 18);
            this.cbb_loc_theo_chuc_vu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbb_loc_theo_chuc_vu.Name = "cbb_loc_theo_chuc_vu";
            this.cbb_loc_theo_chuc_vu.Size = new System.Drawing.Size(193, 23);
            this.cbb_loc_theo_chuc_vu.TabIndex = 20;
            this.cbb_loc_theo_chuc_vu.SelectedIndexChanged += new System.EventHandler(this.cbb_loc_theo_chuc_vu_SelectedIndexChanged);
            this.cbb_loc_theo_chuc_vu.TextChanged += new System.EventHandler(this.cbb_loc_theo_chuc_vu_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(30, 18);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 15);
            this.label8.TabIndex = 18;
            this.label8.Text = "Tìm Kiếm";
            // 
            // dgv_danhsach
            // 
            this.dgv_danhsach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_danhsach.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9,
            this.Column10,
            this.Column11});
            this.dgv_danhsach.Location = new System.Drawing.Point(30, 60);
            this.dgv_danhsach.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgv_danhsach.Name = "dgv_danhsach";
            this.dgv_danhsach.RowHeadersWidth = 51;
            this.dgv_danhsach.RowTemplate.Height = 29;
            this.dgv_danhsach.Size = new System.Drawing.Size(1074, 159);
            this.dgv_danhsach.TabIndex = 0;
            this.dgv_danhsach.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_danhsach_CellClick);
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Id";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 125;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Mã Nhân Viên";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 125;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Họ Và Tên";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 125;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Số Điện Thoại";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 125;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Ngày Sinh";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Width = 125;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Giới Tính";
            this.Column7.MinimumWidth = 6;
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Width = 125;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Chức Vụ";
            this.Column8.MinimumWidth = 6;
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            this.Column8.Width = 125;
            // 
            // Column9
            // 
            this.Column9.HeaderText = "Tài Khoản";
            this.Column9.MinimumWidth = 6;
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            this.Column9.Width = 125;
            // 
            // Column10
            // 
            this.Column10.HeaderText = "Mật Khẩu";
            this.Column10.MinimumWidth = 6;
            this.Column10.Name = "Column10";
            this.Column10.ReadOnly = true;
            this.Column10.Width = 125;
            // 
            // Column11
            // 
            this.Column11.HeaderText = "Trạng Thái";
            this.Column11.MinimumWidth = 6;
            this.Column11.Name = "Column11";
            this.Column11.ReadOnly = true;
            this.Column11.Width = 125;
            // 
            // txb_timkiem
            // 
            this.txb_timkiem.Location = new System.Drawing.Point(153, 18);
            this.txb_timkiem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txb_timkiem.Name = "txb_timkiem";
            this.txb_timkiem.Size = new System.Drawing.Size(289, 23);
            this.txb_timkiem.TabIndex = 0;
            this.txb_timkiem.TextChanged += new System.EventHandler(this.txb_timkiem_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.LightBlue;
            this.groupBox1.Controls.Add(this.panel3);
            this.groupBox1.Controls.Add(this.panel2);
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Controls.Add(this.ptb_nhanvien);
            this.groupBox1.Controls.Add(this.txb_matkhau);
            this.groupBox1.Controls.Add(this.txb_taikhoan);
            this.groupBox1.Controls.Add(this.dtp_ngaysinh);
            this.groupBox1.Controls.Add(this.txb_sdt);
            this.groupBox1.Controls.Add(this.txb_hovaten);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.lb_hovatennv);
            this.groupBox1.Location = new System.Drawing.Point(11, 34);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(1117, 264);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Tin Nhân Viên";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.rb_nhanvien);
            this.panel3.Controls.Add(this.rb_quanly);
            this.panel3.Location = new System.Drawing.Point(557, 92);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(289, 46);
            this.panel3.TabIndex = 33;
            // 
            // rb_nhanvien
            // 
            this.rb_nhanvien.AutoSize = true;
            this.rb_nhanvien.Location = new System.Drawing.Point(173, 14);
            this.rb_nhanvien.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rb_nhanvien.Name = "rb_nhanvien";
            this.rb_nhanvien.Size = new System.Drawing.Size(80, 19);
            this.rb_nhanvien.TabIndex = 29;
            this.rb_nhanvien.TabStop = true;
            this.rb_nhanvien.Text = "Nhân Viên";
            this.rb_nhanvien.UseVisualStyleBackColor = true;
            // 
            // rb_quanly
            // 
            this.rb_quanly.AutoSize = true;
            this.rb_quanly.Location = new System.Drawing.Point(5, 14);
            this.rb_quanly.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rb_quanly.Name = "rb_quanly";
            this.rb_quanly.Size = new System.Drawing.Size(71, 19);
            this.rb_quanly.TabIndex = 28;
            this.rb_quanly.TabStop = true;
            this.rb_quanly.Text = " Quản Lý";
            this.rb_quanly.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.rb_khonghd);
            this.panel2.Controls.Add(this.rb_danghd);
            this.panel2.Location = new System.Drawing.Point(153, 205);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(289, 58);
            this.panel2.TabIndex = 32;
            // 
            // rb_khonghd
            // 
            this.rb_khonghd.AutoSize = true;
            this.rb_khonghd.Location = new System.Drawing.Point(154, 21);
            this.rb_khonghd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rb_khonghd.Name = "rb_khonghd";
            this.rb_khonghd.Size = new System.Drawing.Size(121, 19);
            this.rb_khonghd.TabIndex = 27;
            this.rb_khonghd.TabStop = true;
            this.rb_khonghd.Text = "Không Hoạt Động";
            this.rb_khonghd.UseVisualStyleBackColor = true;
            // 
            // rb_danghd
            // 
            this.rb_danghd.AutoSize = true;
            this.rb_danghd.Location = new System.Drawing.Point(18, 21);
            this.rb_danghd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rb_danghd.Name = "rb_danghd";
            this.rb_danghd.Size = new System.Drawing.Size(114, 19);
            this.rb_danghd.TabIndex = 26;
            this.rb_danghd.TabStop = true;
            this.rb_danghd.Text = "Đang Hoạt Động";
            this.rb_danghd.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rb_nu);
            this.panel1.Controls.Add(this.rb_nam);
            this.panel1.Location = new System.Drawing.Point(153, 158);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(289, 42);
            this.panel1.TabIndex = 31;
            // 
            // rb_nu
            // 
            this.rb_nu.AutoSize = true;
            this.rb_nu.Location = new System.Drawing.Point(154, 11);
            this.rb_nu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rb_nu.Name = "rb_nu";
            this.rb_nu.Size = new System.Drawing.Size(41, 19);
            this.rb_nu.TabIndex = 25;
            this.rb_nu.TabStop = true;
            this.rb_nu.Text = "Nữ";
            this.rb_nu.UseVisualStyleBackColor = true;
            // 
            // rb_nam
            // 
            this.rb_nam.AutoSize = true;
            this.rb_nam.Location = new System.Drawing.Point(18, 11);
            this.rb_nam.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rb_nam.Name = "rb_nam";
            this.rb_nam.Size = new System.Drawing.Size(51, 19);
            this.rb_nam.TabIndex = 24;
            this.rb_nam.TabStop = true;
            this.rb_nam.Text = "Nam";
            this.rb_nam.UseVisualStyleBackColor = true;
            // 
            // ptb_nhanvien
            // 
            this.ptb_nhanvien.BackColor = System.Drawing.Color.MediumTurquoise;
            this.ptb_nhanvien.Location = new System.Drawing.Point(864, 20);
            this.ptb_nhanvien.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ptb_nhanvien.Name = "ptb_nhanvien";
            this.ptb_nhanvien.Size = new System.Drawing.Size(240, 244);
            this.ptb_nhanvien.TabIndex = 30;
            this.ptb_nhanvien.TabStop = false;
            this.ptb_nhanvien.Click += new System.EventHandler(this.ptb_nhanvien_Click);
            // 
            // txb_matkhau
            // 
            this.txb_matkhau.Location = new System.Drawing.Point(557, 56);
            this.txb_matkhau.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txb_matkhau.Name = "txb_matkhau";
            this.txb_matkhau.Size = new System.Drawing.Size(289, 23);
            this.txb_matkhau.TabIndex = 29;
            // 
            // txb_taikhoan
            // 
            this.txb_taikhoan.Location = new System.Drawing.Point(557, 28);
            this.txb_taikhoan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txb_taikhoan.Name = "txb_taikhoan";
            this.txb_taikhoan.Size = new System.Drawing.Size(289, 23);
            this.txb_taikhoan.TabIndex = 28;
            // 
            // dtp_ngaysinh
            // 
            this.dtp_ngaysinh.Location = new System.Drawing.Point(153, 127);
            this.dtp_ngaysinh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtp_ngaysinh.Name = "dtp_ngaysinh";
            this.dtp_ngaysinh.Size = new System.Drawing.Size(289, 23);
            this.dtp_ngaysinh.TabIndex = 21;
            // 
            // txb_sdt
            // 
            this.txb_sdt.Location = new System.Drawing.Point(153, 92);
            this.txb_sdt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txb_sdt.Name = "txb_sdt";
            this.txb_sdt.Size = new System.Drawing.Size(289, 23);
            this.txb_sdt.TabIndex = 20;
            // 
            // txb_hovaten
            // 
            this.txb_hovaten.Location = new System.Drawing.Point(153, 28);
            this.txb_hovaten.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txb_hovaten.Name = "txb_hovaten";
            this.txb_hovaten.Size = new System.Drawing.Size(289, 23);
            this.txb_hovaten.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(469, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 15);
            this.label2.TabIndex = 17;
            this.label2.Text = "Mật Khẩu:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(469, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 15);
            this.label1.TabIndex = 16;
            this.label1.Text = "Tài Khoản:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(469, 94);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 15);
            this.label7.TabIndex = 15;
            this.label7.Text = "Chức Vụ:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(28, 204);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 15);
            this.label6.TabIndex = 14;
            this.label6.Text = "Trạng Thái:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 158);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 15);
            this.label5.TabIndex = 13;
            this.label5.Text = "Giới Tính:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 15);
            this.label4.TabIndex = 12;
            this.label4.Text = "Ngày Sinh:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 15);
            this.label3.TabIndex = 11;
            this.label3.Text = "Số Điện Thoại:";
            // 
            // lb_hovatennv
            // 
            this.lb_hovatennv.AutoSize = true;
            this.lb_hovatennv.Location = new System.Drawing.Point(30, 28);
            this.lb_hovatennv.Name = "lb_hovatennv";
            this.lb_hovatennv.Size = new System.Drawing.Size(62, 15);
            this.lb_hovatennv.TabIndex = 10;
            this.lb_hovatennv.Text = "Họ Và Tên:";
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Mã Nhân Viên";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 125;
            // 
            // frmNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(1361, 536);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmNhanVien";
            this.Text = "frmNhanVien";
            this.Load += new System.EventHandler(this.frmNhanVien_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_danhsach)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_nhanvien)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox3;
        private Button btn_suanv;
        private Button btn_themnv;
        private GroupBox groupBox2;
        private Label label8;
        private DataGridView dgv_danhsach;
        private TextBox txb_timkiem;
        private GroupBox groupBox1;
        private PictureBox ptb_nhanvien;
        private TextBox txb_matkhau;
        private TextBox txb_taikhoan;
        private DateTimePicker dtp_ngaysinh;
        private TextBox txb_sdt;
        private TextBox txb_hovaten;
        private Label label2;
        private Label label1;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label lb_hovatennv;
        private Panel panel3;
        private RadioButton rb_nhanvien;
        private RadioButton rb_quanly;
        private Panel panel2;
        private RadioButton rb_khonghd;
        private RadioButton rb_danghd;
        private Panel panel1;
        private RadioButton rb_nu;
        private RadioButton rb_nam;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column7;
        private DataGridViewTextBoxColumn Column8;
        private DataGridViewTextBoxColumn Column9;
        private DataGridViewTextBoxColumn Column10;
        private DataGridViewTextBoxColumn Column11;
        private Label label10;
        private Label label9;
        private ComboBox cbb_loc_theo_trang_thai;
        private ComboBox cbb_loc_theo_chuc_vu;
    }
}