using _1_DAL.Entities;
using _1_DAL.Repository;
using _2_BUS.IServices;
using _2_BUS.Services;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NPOI.SS.UserModel;
using NPOI.XSSF.UserModel;
using System.IO;

namespace _3_PL
{
    public partial class frmQUANLYKM : Form
    {
        IQuanLyKMServices _quanlykm;
        Promotion _promotion;

        public frmQUANLYKM()
        {
            InitializeComponent();        
            _quanlykm = new QlkhuyenmaiServices();
        }
     public void load()
        {
            _quanlykm.GetAll();
            dataGridView1.DataSource = _quanlykm.GetAll();
        }

        private void frmQUANLYKM_Load(object sender, EventArgs e)
        {
            load();
          
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Promotion km = new Promotion();
            km.Name= textBox2.Text;
            km.CreateDate = dateTimePicker1.Value;
            km.EndDate = dateTimePicker2.Value;
            km.Index = int.Parse( textBox5.Text);
            _quanlykm.Add(km);
            MessageBox.Show("THEM THANH CONG");
            load();
            textBox2.Text = "";
            textBox5.Text = ""; 
        }

            private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
            {
            if (dataGridView1.CurrentCell != null)
            {
                var kmList = _quanlykm.GetAll();
                var row = dataGridView1.CurrentCell.RowIndex;
                if (row >= 0 && row < kmList.Count)
                {
                    var km = kmList[row];
                    textBox1.Text = km.Id.ToString();
                    textBox2.Text = km.Name.ToString();
                    textBox5.Text = km.Index.ToString();
                    dateTimePicker1.Value = km.CreateDate;
                    dateTimePicker2.Value = km.EndDate;
                }
                else
                {
                    // Hiển thị thông báo lỗi
                    MessageBox.Show("Không tìm thấy thông tin khuyến mãi!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            var kmList = _quanlykm.GetAll();
            if (dataGridView1.CurrentCell != null)
            {
                var row = dataGridView1.CurrentCell.RowIndex;
                if (row >= 0 && row < kmList.Count)
                {
                    var km = kmList[row];
                    km.Name = textBox2.Text;
                    km.CreateDate = dateTimePicker1.Value;
                    km.EndDate = dateTimePicker2.Value;
                    km.Index = int.Parse(textBox5.Text);
                    _quanlykm.Update(km);
                    MessageBox.Show("Cập nhật thông tin khuyến mãi thành công!");
                    load();
                }
                else
                {
                    // Hiển thị thông báo lỗi
                    MessageBox.Show("Không tìm thấy thông tin khuyến mãi!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentCell != null)
            {
                var kmList = _quanlykm.GetAll();
                var row = dataGridView1.CurrentCell.RowIndex;
                if (row >= 0 && row < kmList.Count)
                {
                    var km = kmList[row];
                    _quanlykm.Delete(km);
                    MessageBox.Show("Xóa khuyến mãi thành công!");
                    load();
                }
                else
                {
                    // Hiển thị thông báo lỗi
                    MessageBox.Show("Không tìm thấy thông tin khuyến mãi!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox5.Text = "";
            dateTimePicker1.Value = DateTime.Now;
            dateTimePicker2.Value = DateTime.Now;

        }

        private void button4_Click(object sender, EventArgs e)
        {

            //string tuKhoa = textBox6.Text;
            //string query = "SELECT * FROM KhuyenMai WHERE TenKM LIKE '%" + tuKhoa + "%'";
            //DataTable dt = GetData(query);
            //if (dt.Rows.Count == 0)
            //{
            //    MessageBox.Show("Không tìm thấy kết quả tương ứng", "Thông báo");
            //}
            //else
            //{
            //    dataGridView1.DataSource = dt;
            //}
        }
                

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime fromDate = dateTimePicker1.Value;
            DateTime toDate = dateTimePicker2.Value;
            List<Promotion> result = _quanlykm.GetAll().Where(km => km.CreateDate >= fromDate && km.EndDate <= toDate).ToList();
            dataGridView1.DataSource = result;
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            DateTime dateTime = dateTimePicker1.Value;
            string formattedDate = dateTime.ToString("dd/MM/yyyy");
            Console.WriteLine(formattedDate); // Kết quả: "09/04/2023"

        }

        private void button8_MouseDown(object sender, MouseEventArgs e)
        {
            load();
        }
        //
        private void ExportToExcel()
        {
            // Tạo workbook mới
            XSSFWorkbook workbook = new XSSFWorkbook();
            // Tạo sheet mới
            ISheet sheet = workbook.CreateSheet("Sheet1");

            // Tạo header cho sheet
            IRow headerRow = sheet.CreateRow(0);
            for (int j = 0; j < dataGridView1.Columns.Count; j++)
            {
                headerRow.CreateCell(j).SetCellValue(dataGridView1.Columns[j].HeaderText);
            }

            // Lấy dữ liệu từ DataGridView và đưa vào DataTable
            DataTable dt = new DataTable();
            for (int i = 0; i < dataGridView1.Columns.Count; i++)
            {
                dt.Columns.Add(dataGridView1.Columns[i].Name);
            }
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                DataRow dRow = dt.NewRow();
                for (int i = 0; i < dataGridView1.Columns.Count; i++)
                {
                    dRow[i] = row.Cells[i].Value;
                }
                dt.Rows.Add(dRow);
            }

            // Lấy số cột và số dòng của DataTable
            int rowCount = dt.Rows.Count;
            int colCount = dt.Columns.Count;

            // Lấy dữ liệu từ DataTable và đưa vào sheet
            for (int i = 0; i < rowCount; i++)
            {
                IRow dataRow = sheet.CreateRow(i + 1);
                for (int j = 0; j < colCount; j++)
                {
                    dataRow.CreateCell(j).SetCellValue(dt.Rows[i][j].ToString());
                }
            }

            // Lưu file Excel
            string fileName = "TTkhuyenmai_" + DateTime.Now.ToString("dd-MM-yyyy_hhmmss") + ".xlsx";
            string filePath = "D:\\" + fileName;
            using (FileStream stream = new FileStream(filePath, FileMode.Create, FileAccess.Write))
            {
                workbook.Write(stream);
            }

            // Hiển thị thông báo xuất file thành công
            MessageBox.Show("Xuất file thành công!", "Thông báo");
        }
        private void ExportToExcel2()
        {
            // Tạo workbook mới
            XSSFWorkbook workbook = new XSSFWorkbook();
            // Tạo sheet mới
            ISheet sheet = workbook.CreateSheet("Sheet1");

            // Tạo header cho sheet
            IRow headerRow = sheet.CreateRow(0);
            for (int j = 0; j < dataGridView1.Columns.Count; j++)
            {
                headerRow.CreateCell(j).SetCellValue(dataGridView1.Columns[j].HeaderText);
            }

            // Lấy dữ liệu từ DataGridView và đưa vào DataTable
            DataTable dt = new DataTable();
            for (int i = 0; i < dataGridView1.Columns.Count; i++)
            {
                dt.Columns.Add(dataGridView1.Columns[i].Name);
            }
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                DataRow dRow = dt.NewRow();
                for (int i = 0; i < dataGridView1.Columns.Count; i++)
                {
                    dRow[i] = row.Cells[i].Value;
                }
                dt.Rows.Add(dRow);
            }

            // Lấy số cột và số dòng của DataTable
            int rowCount = dt.Rows.Count;
            int colCount = dt.Columns.Count;

            // Lấy dữ liệu từ DataTable và đưa vào sheet
            for (int i = 0; i < rowCount; i++)
            {
                IRow dataRow = sheet.CreateRow(i + 1);
                for (int j = 0; j < colCount; j++)
                {
                    dataRow.CreateCell(j).SetCellValue(dt.Rows[i][j].ToString());
                }
            }

            // Hiển thị dialog để chọn thư mục lưu file
            FolderBrowserDialog folderDialog = new FolderBrowserDialog();
            if (folderDialog.ShowDialog() == DialogResult.OK)
            {
                // Lưu file Excel
                string fileName = "TTkhuyenmai_" + DateTime.Now.ToString("dd-MM-yyyy-ss") + ".xlsx";
                string filePath = Path.Combine(folderDialog.SelectedPath, fileName);
                using (FileStream stream = new FileStream(filePath, FileMode.Create, FileAccess.Write))
                {
                    workbook.Write(stream);
                }

                // Hiển thị thông báo xuất file thành công
                MessageBox.Show("Xuất file thành công!", "Thông báo");
            }
        }



        private void button5_Click(object sender, EventArgs e)
        {
            ExportToExcel2();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            load();
        }
    }
}
