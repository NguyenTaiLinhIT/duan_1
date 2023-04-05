namespace _3_PL
{
    partial class FrmBanHang
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
            button1 = new Button();
            button2 = new Button();
            btnQuanLyCuaHang = new Button();
            button4 = new Button();
            panel1 = new Panel();
            panel2 = new Panel();
            plChuaTatCaForm = new Panel();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ButtonHighlight;
            button1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(-1, 68);
            button1.Name = "button1";
            button1.Size = new Size(208, 65);
            button1.TabIndex = 0;
            button1.Text = "Trang chủ";
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ButtonHighlight;
            button2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(-1, 131);
            button2.Name = "button2";
            button2.Size = new Size(208, 65);
            button2.TabIndex = 1;
            button2.Text = "Bán hàng";
            button2.UseVisualStyleBackColor = false;
            // 
            // btnQuanLyCuaHang
            // 
            btnQuanLyCuaHang.BackColor = SystemColors.ButtonHighlight;
            btnQuanLyCuaHang.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnQuanLyCuaHang.Location = new Point(-2, 257);
            btnQuanLyCuaHang.Name = "btnQuanLyCuaHang";
            btnQuanLyCuaHang.Size = new Size(208, 65);
            btnQuanLyCuaHang.TabIndex = 3;
            btnQuanLyCuaHang.Text = "Quản lý cửa hàng";
            btnQuanLyCuaHang.UseVisualStyleBackColor = false;
            btnQuanLyCuaHang.Click += btnQuanLyCuaHang_Click;
            // 
            // button4
            // 
            button4.BackColor = SystemColors.ButtonHighlight;
            button4.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            button4.Location = new Point(-2, 194);
            button4.Name = "button4";
            button4.Size = new Size(208, 65);
            button4.TabIndex = 2;
            button4.Text = "Dịch vụ sửa chữa";
            button4.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ButtonFace;
            panel1.Location = new Point(-1, 68);
            panel1.Name = "panel1";
            panel1.Size = new Size(207, 581);
            panel1.TabIndex = 4;
            // 
            // panel2
            // 
            panel2.Location = new Point(-2, -3);
            panel2.Name = "panel2";
            panel2.Size = new Size(1348, 70);
            panel2.TabIndex = 5;
            // 
            // plChuaTatCaForm
            // 
            plChuaTatCaForm.Location = new Point(210, 73);
            plChuaTatCaForm.Name = "plChuaTatCaForm";
            plChuaTatCaForm.Size = new Size(1051, 576);
            plChuaTatCaForm.TabIndex = 6;
            plChuaTatCaForm.Paint += plChuaTatCaForm_Paint;
            // 
            // FrmBanHang
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1262, 673);
            Controls.Add(plChuaTatCaForm);
            Controls.Add(btnQuanLyCuaHang);
            Controls.Add(button4);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Name = "FrmBanHang";
            Text = "FrmBanHang";
            Load += FrmBanHang_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button btnQuanLyCuaHang;
        private Button button4;
        private Panel panel1;
        private Panel panel2;
        private Panel plChuaTatCaForm;
    }
}