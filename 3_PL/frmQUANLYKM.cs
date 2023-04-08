using _1_DAL.Entities;
using _1_DAL.Repository;
using _2_BUS.IServices;
using _2_BUS.Services;
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
    public partial class frmQUANLYKM : Form
    {
        IQuanLyKMServices _quanlykm;
        Promotion _promotion;

        public frmQUANLYKM()
        {
            InitializeComponent();
            /// tại sao tôi lại éo gọi được sang ??
            _quanlykm = new IQuanLyKMServices();
        }

        private void frmQUANLYKM_Load(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
