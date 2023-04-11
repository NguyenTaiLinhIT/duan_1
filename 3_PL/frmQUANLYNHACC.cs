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

            Supplier ncc = new Supplier()
            {
                Id = Guid.NewGuid(),
                Name = textBox2.Text,
                HinhAnh = GetImageBytes(pictureBox1.Image) // lấy dữ liệu ảnh từ PictureBox
                                                         // hoặc Image = GetImageBytesFromFile("path_to_image_file") nếu lấy dữ liệu từ file ảnh
            };

            bool result = _qlNhacc.Add(ncc);
            if (result)
            {
                MessageBox.Show("Thêm nhà cung cấp thành công!");
                load();
            }
            else
            {
                MessageBox.Show("Thêm nhà cung cấp không thành công!");
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
                textBox1.Text = row.Cells[0].Value.ToString();

                // lấy giá trị Name từ cột thứ hai của dòng được chọn và hiển thị lên TextBox2
                textBox2.Text = row.Cells[1].Value.ToString();

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

        private void button6_Click(object sender, EventArgs e)
        {
            
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {  // Lấy giá trị id của nhà cung cấp từ cell đang được chọn

            Guid supplierId = (Guid)dataGridView1.CurrentRow.Cells["Id"].Value;

            // Truy vấn sản phẩm từ database bằng id của nhà cung cấp
            var products = db.Products.Where(p => p.SupplierDetailId == supplierId).ToList();

            // Đổ dữ liệu lên dataGridView2
            dataGridView2.DataSource = products;
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
    


