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
using System.Xml.Linq;
using System.Drawing.Imaging;
using Microsoft.EntityFrameworkCore;
using _1_DAL.QuanLyDBContext;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using NPOI.XWPF.UserModel;
using static System.ComponentModel.Design.ObjectSelectorEditor;
using ClosedXML;
using ClosedXML.Excel;
using Excel = Microsoft.Office.Interop.Excel;
using OfficeOpenXml;
using LicenseContext = OfficeOpenXml.LicenseContext;

namespace _3_PL
{
    public partial class frmQUANLYNHACC : Form
    {

        private QuanLyDatabaseContext db = new QuanLyDatabaseContext();
        IQuanLyNhaCCServices _qlNhacc;
        Supplier _supplier;
        public frmQUANLYNHACC()
        {
            InitializeComponent();
            _qlNhacc = new QuanLyNhaCCServices();
        }
        public void load()
        {
            _qlNhacc.GetAll();
            dataGridView1.DataSource = _qlNhacc.GetAll();

        }




        private void button1_Click(object sender, EventArgs e)
        {
            // Kiểm tra các trường bắt buộc không được để trống
            if (string.IsNullOrWhiteSpace(txtten.Text))
            {
                MessageBox.Show("Vui lòng nhập tên nhà cung cấp!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtdiachi.Text))
            {
                MessageBox.Show("Vui lòng nhập địa chỉ nhà cung cấp!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Kiểm tra định dạng email hợp lệ
            if (!string.IsNullOrWhiteSpace(txtemail.Text) && !IsValidEmail(txtemail.Text))
            {
                MessageBox.Show("Định dạng email không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Tạo đối tượng Supplier mới và gán các giá trị cho các thuộc tính của nó
            Supplier ncc = new Supplier()
            {
                Id = Guid.NewGuid(),
                Name = txtten.Text,
                HinhAnh = GetImageBytes(pictureBox1.Image), // lấy dữ liệu ảnh từ PictureBox
                DiaChi = txtdiachi.Text,
                DienThoai = txtdienthoai.Text,
                Email = txtemail.Text,
                Website = txtws.Text,
                GhiChu = txtghichu.Text
            };

            // Gọi phương thức Add của đối tượng QLNhacc để thêm đối tượng Supplier mới vào danh sách
            bool result = _qlNhacc.Add(ncc);

            // Hiển thị thông báo kết quả thêm
            if (result)
            {
                MessageBox.Show("Thêm nhà cung cấp thành công!");
                load();
            }
            else
            {
                MessageBox.Show("Thêm nhà cung cấp không thành công!");
            }


            /// bắt lỗi hình ảh 
            try
            {
                // Kiểm tra xem người dùng đã chọn tập tin hình ảnh hay chưa
                if (pictureBox1.Image == null)
                {
                    MessageBox.Show("Vui lòng chọn một hình ảnh!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Tạo đối tượng Image mới từ PictureBox
                Image img = pictureBox1.Image;

                // Kiểm tra xem định dạng của tập tin hình ảnh có hợp lệ hay không
                if (img.RawFormat.Guid == System.Drawing.Imaging.ImageFormat.Jpeg.Guid
                    || img.RawFormat.Guid == System.Drawing.Imaging.ImageFormat.Png.Guid
                    || img.RawFormat.Guid == System.Drawing.Imaging.ImageFormat.Gif.Guid)
                {
                    // your code to add new record here
                }
                else
                {
                    MessageBox.Show("Định dạng hình ảnh không hợp lệ! Vui lòng chọn một hình ảnh JPG, PNG hoặc GIF.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (System.Runtime.InteropServices.ExternalException ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }

        private byte[] GetImageBytes(Image image)
        {
            if (image == null)
            {
                return null;
            }

            using (MemoryStream ms = new MemoryStream())
            {
                image.Save(ms, ImageFormat.Jpeg); // hoặc bạn có thể chọn định dạng ảnh khác
                return ms.ToArray();
            }
        }

        private byte[] GetImageBytesFromFile(string filePath)
        {
            if (string.IsNullOrEmpty(filePath) || !File.Exists(filePath))
            {
                return null;
            }

            using (FileStream fs = new FileStream(filePath, FileMode.Open, FileAccess.Read))
            using (MemoryStream ms = new MemoryStream())
            {
                fs.CopyTo(ms);
                return ms.ToArray();
            }
        }

        private void frmQUANLYNHACC_Load(object sender, EventArgs e)
        {
            // Tạo các cột cho DataGridView
            DataGridViewTextBoxColumn idColumn = new DataGridViewTextBoxColumn();
            idColumn.Name = "Id";
            idColumn.HeaderText = "ID";
            idColumn.DataPropertyName = "Id";
            idColumn.ValueType = typeof(Guid);
            idColumn.Width = 25;

            DataGridViewTextBoxColumn nameColumn = new DataGridViewTextBoxColumn();
            nameColumn.Name = "Name";
            nameColumn.HeaderText = "Name";
            nameColumn.DataPropertyName = "Name";



            DataGridViewTextBoxColumn addressColumn = new DataGridViewTextBoxColumn();
            addressColumn.Name = "DiaChi";
            addressColumn.HeaderText = "Address";
            addressColumn.DataPropertyName = "DiaChi";

            DataGridViewTextBoxColumn phoneColumn = new DataGridViewTextBoxColumn();
            phoneColumn.Name = "DienThoai";
            phoneColumn.HeaderText = "Phone";
            phoneColumn.DataPropertyName = "DienThoai";

            DataGridViewTextBoxColumn emailColumn = new DataGridViewTextBoxColumn();
            emailColumn.Name = "Email";
            emailColumn.HeaderText = "Email";
            emailColumn.DataPropertyName = "Email";

            DataGridViewTextBoxColumn websiteColumn = new DataGridViewTextBoxColumn();
            websiteColumn.Name = "Website";
            websiteColumn.HeaderText = "Website";
            websiteColumn.DataPropertyName = "Website";

            DataGridViewTextBoxColumn noteColumn = new DataGridViewTextBoxColumn();
            noteColumn.Name = "GhiChu";
            noteColumn.HeaderText = "Note";
            noteColumn.DataPropertyName = "GhiChu";

            DataGridViewImageColumn imageColumn = new DataGridViewImageColumn();
            imageColumn.Name = "HinhAnh";
            imageColumn.HeaderText = "Image";
            imageColumn.DataPropertyName = "HinhAnh";
            imageColumn.ImageLayout = DataGridViewImageCellLayout.Zoom;
            imageColumn.Width = 50; // chiều rộng của cột hình ảnh
            //imageColumn.Height = 50; // chiều cao của cột hình ảnh
            // Thêm các cột vào DataGridView
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { idColumn, nameColumn, imageColumn, addressColumn, phoneColumn, emailColumn, websiteColumn, noteColumn });

            // Load dữ liệu từ cơ sở dữ liệu và hiển thị lên DataGridView
            ////List<Supplier> suppliers = _nhacc.GetAll();
            ////dataGridView1.DataSource = suppliers;
            ///

            load();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "picture file (.png,.jpg)|*.png;*jpg";
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(openFile.FileName);
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                // lấy giá trị Id từ cột đầu tiên của dòng được chọn và hiển thị lên TextBox1
                txtbid.Text = row.Cells[0].Value.ToString();

                // lấy giá trị Name từ cột thứ hai của dòng được chọn và hiển thị lên TextBox2
                txtten.Text = row.Cells[1].Value.ToString();

                // lấy giá trị ảnh từ cột thứ ba của dòng được chọn và hiển thị lên PictureBox1
                byte[] imageBytes = (byte[])row.Cells[2].Value;
                if (imageBytes != null)
                {
                    using (MemoryStream ms = new MemoryStream(imageBytes))
                    {
                        pictureBox1.Image = Image.FromStream(ms);
                    }
                }
                else
                {
                    pictureBox1.Image = null;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Kiểm tra các trường bắt buộc không được để trống
            if (string.IsNullOrWhiteSpace(txtten.Text))
            {
                MessageBox.Show("Vui lòng nhập tên nhà cung cấp!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtdiachi.Text))
            {
                MessageBox.Show("Vui lòng nhập địa chỉ nhà cung cấp!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Kiểm tra định dạng email hợp lệ
            if (!string.IsNullOrWhiteSpace(txtemail.Text) && !IsValidEmail(txtemail.Text))
            {
                MessageBox.Show("Định dạng email không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Lấy thông tin nhà cung cấp cần cập nhật từ các TextBox và PictureBox
            Supplier ncc = new Supplier()
            {
                Id = Guid.NewGuid(),
                Name = txtten.Text,
                HinhAnh = GetImageBytes(pictureBox1.Image),
                DiaChi = txtdiachi.Text,
                DienThoai = txtdienthoai.Text,
                Email = txtemail.Text,
                Website = txtws.Text,
                GhiChu = txtghichu.Text
            };

            // Gọi phương thức Update của đối tượng QLNhacc để cập nhật thông tin nhà cung cấp
            bool result = _qlNhacc.Update(ncc);

            // Hiển thị thông báo kết quả cập nhật
            if (result)
            {
                MessageBox.Show("Cập nhật nhà cung cấp thành công!");
                load();
            }
            else
            {
                MessageBox.Show("Cập nhật nhà cung cấp không thành công!");
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn muốn xóa nhà cung cấp này?", "Xác nhận", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Supplier supplier = dataGridView1.CurrentRow.DataBoundItem as Supplier;
                bool isDeleted = _qlNhacc.Delete(supplier);
                if (isDeleted)
                {
                    MessageBox.Show("Xóa nhà cung cấp thành công");
                    load();
                }
                else
                {
                    MessageBox.Show("Xóa nhà cung cấp thất bại");
                }
            }
        }

        private void button6_Click(object sender, EventArgs e, char searchName)
        {
            string searchNamea = txtSearch.Text;
            var suppliers = db.Suppliers.Where(s => s.Name.Contains(searchName)).ToList();
            dataGridView1.DataSource = suppliers;
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {  // Lấy giá trị id của nhà cung cấp từ cell đang được chọn

            Guid supplierId = (Guid)dataGridView1.CurrentRow.Cells["Id"].Value;

            // Truy vấn sản phẩm từ database bằng id của nhà cung cấp
            var products = db.Products.Where(p => p.SupplierDetailId == supplierId).ToList();

            // Đổ dữ liệu lên dataGridView2
            dataGridView2.DataSource = products;
        }

        private void dataGridView1_CellContentClick_2(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1.Columns["Id"].Visible = false;
        }

        private void dataGridView1_CellMouseClick_1(object sender, DataGridViewCellMouseEventArgs e)
        {
            // Lấy giá trị id của nhà cung cấp từ cell đang được chọn

            Guid supplierId = (Guid)dataGridView1.CurrentRow.Cells["Id"].Value;

            // Truy vấn sản phẩm từ database bằng id của nhà cung cấp
            var products = db.Products.Where(p => p.SupplierDetailId == supplierId).ToList();

            // Đổ dữ liệu lên dataGridView2
            dataGridView2.DataSource = products;
        }

        private void dataGridView1_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                // Lấy thông tin của dòng được chọn
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                // Hiển thị thông tin lên các TextBox tương ứng
                txtbid.Text = row.Cells["Id"].Value.ToString();
                txtten.Text = row.Cells["Name"].Value.ToString();
                txtdiachi.Text = row.Cells["DiaChi"].Value.ToString();
                txtdienthoai.Text = row.Cells["DienThoai"].Value.ToString();
                txtemail.Text = row.Cells["Email"].Value.ToString();
                txtws.Text = row.Cells["Website"].Value.ToString();
                txtghichu.Text = row.Cells["GhiChu"].Value.ToString();

                // Lấy dữ liệu ảnh từ row
                byte[] imageData = (byte[])row.Cells["HinhAnh"].Value;

                // Kiểm tra dữ liệu ảnh không rỗng
                if (imageData != null)
                {
                    using (MemoryStream ms = new MemoryStream(imageData))
                    {
                        pictureBox1.Image = Image.FromStream(ms);
                    }
                }
                else
                {
                    pictureBox1.Image = null;
                }
            }
            catch (Exception ex)
            {

            }
            // Lấy giá trị id của nhà cung cấp từ cell đang được chọn

            Guid supplierId = (Guid)dataGridView1.CurrentRow.Cells["Id"].Value;

            // Truy vấn sản phẩm từ database bằng id của nhà cung cấp
            var products = db.Products.Where(p => p.SupplierDetailId == supplierId).ToList();

            // Đổ dữ liệu lên dataGridView2
            dataGridView2.DataSource = products;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            txtbid.Text = "";
            txtten.Text = "";
            txtdiachi.Text = "";
            txtdienthoai.Text = "";
            txtemail.Text = "";
            txtws.Text = "";
            txtghichu.Text = "";
            pictureBox1.ImageLocation = "path/to/default/image.png";
            load();

        }

        private void button6_Click(object sender, EventArgs e)
        {
            string searchText = txtSearch.Text;
            var suppliers = db.Suppliers
                .Where(s => s.Name.Contains(searchText) || s.DienThoai.Contains(searchText))
                .ToList();
            dataGridView1.DataSource = suppliers;
        }

        public void ac()
        {
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;

            // Tạo file Excel mới
            ExcelPackage excelPackage = new ExcelPackage();

            // Tạo một worksheet mới
            ExcelWorksheet worksheet = excelPackage.Workbook.Worksheets.Add("Sheet1");

            // Đặt header cho các cột trong worksheet
            for (int i = 0; i < dataGridView1.Columns.Count; i++)
            {
                worksheet.Cells[1, i + 1].Value = dataGridView1.Columns[i].HeaderText;
            }

            // Lưu dữ liệu từ DataGridView vào worksheet
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                for (int j = 0; j < dataGridView1.Columns.Count; j++)
                {
                    worksheet.Cells[i + 2, j + 1].Value = dataGridView1.Rows[i].Cells[j].Value.ToString();
                }
            }

            // Hiển thị dialog để chọn thư mục lưu file
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "Excel files (*.xlsx)|*.xlsx";
            saveFileDialog1.Title = "Save an Excel File";
            saveFileDialog1.ShowDialog();

            // Nếu người dùng chọn OK và tên file hợp lệ
            if (saveFileDialog1.ShowDialog() == DialogResult.OK && saveFileDialog1.FileName != "")
            {
                // Lưu file Excel
                using (FileStream stream = new FileStream(saveFileDialog1.FileName, FileMode.Create, FileAccess.Write))
                {
                    excelPackage.SaveAs(stream);
                }

                // Thông báo thành công
                MessageBox.Show("Đã xuất dữ liệu ra file Excel!");
            }
        }


        private void button5_Click(object sender, EventArgs e)
        {
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;

            // Tạo file Excel mới
            ExcelPackage excelPackage = new ExcelPackage();

            // Tạo một worksheet mới
            ExcelWorksheet worksheet = excelPackage.Workbook.Worksheets.Add("Sheet1");

            // Đặt header cho các cột trong worksheet
            for (int i = 0; i < dataGridView1.Columns.Count; i++)
            {
                worksheet.Cells[1, i + 1].Value = dataGridView1.Columns[i].HeaderText;
            }

            // Lưu dữ liệu từ DataGridView vào worksheet
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                for (int j = 0; j < dataGridView1.Columns.Count; j++)
                {
                    worksheet.Cells[i + 2, j + 1].Value = dataGridView1.Rows[i].Cells[j].Value.ToString();
                }
            }

            // Hiển thị dialog để chọn thư mục lưu file
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "Excel files (*.xlsx)|*.xlsx";
            saveFileDialog1.Title = "Save an Excel File";
            saveFileDialog1.ShowDialog();

            // Nếu người dùng chọn OK và tên file hợp lệ
            if (saveFileDialog1.ShowDialog() == DialogResult.OK && saveFileDialog1.FileName != "")
            {
                // Lưu file Excel
                using (FileStream stream = new FileStream(saveFileDialog1.FileName, FileMode.Create, FileAccess.Write))
                {
                    excelPackage.SaveAs(stream);
                }

                // Thông báo thành công
                MessageBox.Show("Đã xuất dữ liệu ra file Excel!");
            }


        }




        //public byte[] imgby64(Image image , System.Drawing.Imaging.ImageFormat format)
        //{
        //    using (MemoryStream ms = new MemoryStream())
        //    {
        //        image.Save(ms, format);
        //        byte[] imageBytes= ms.ToArray();
        //        return imageBytes;
        //    }         
        //}
        //public byte[] imgby46(byte[] imageBytes)
        //{
        //    using (MemoryStream ms = new MemoryStream(imageBytes))
        //    {
        //        Image image = Image.FromStream(ms, true);
        //        return imgby64(image, System.Drawing.Imaging.ImageFormat.Jpeg);
        //    }
        //}
    }
}




