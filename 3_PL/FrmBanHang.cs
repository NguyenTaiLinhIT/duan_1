using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3_PL
{
    public partial class FrmBanHang : Form
    {
        public FrmBanHang()
        {
            InitializeComponent();
            Panel plChuaTatCaForm = new Panel();
        }

        private void FrmBanHang_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
        }

        private void btnQuanLyCuaHang_Click(object sender, EventArgs e)
        {
            frmHang frmHang = new frmHang();
            frmHang.TopLevel = false;
            frmHang.Dock = DockStyle.Fill;
            frmHang.TopMost = true;
            frmHang.FormBorderStyle = FormBorderStyle.None;
            plChuaTatCaForm.Controls.Add(frmHang);
            frmHang.Show();
        }

        private void plChuaTatCaForm_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
