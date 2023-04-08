using _1_DAL.Entities;
using _2_BUS.IServices;
using _2_BUS.Services;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading.Tasks.Sources;
using System.Windows.Forms;

namespace _3_PL
{
    public partial class frmNhanVien : Form
    {
        INhanVienServices _inhanvienservice;
        Employee employee;
        string linkimage = "";
        
        public frmNhanVien()
        {
            InitializeComponent();
            _inhanvienservice = new NhanVienServices();
            employee = new Employee();
            cbb_loc_theo_chuc_vu.Items.Add("Quản Lý");
            cbb_loc_theo_chuc_vu.Items.Add("Nhân Viên");
            cbb_loc_theo_trang_thai.Items.Add("Đang Hoạt Động");
            cbb_loc_theo_trang_thai.Items.Add("Không Hoạt Động");
            dtp_ngaysinh.CustomFormat = "dd-MM-yyyy";
            rb_danghd.Checked = true;
            LoadNhanVien();
        }

        public void LoadNhanVien()
        {
            dgv_danhsach.Rows.Clear();
            int STT = 1;
            

            foreach (var nhanvien in _inhanvienservice.GetAll())
            {
                string manv = "NV" + STT;


                string formatbirthday = nhanvien.BirthDay.ToString("dd/MM/yyyy");
                dgv_danhsach.Columns[0].Visible = false;

                dgv_danhsach.Rows.Add(nhanvien.Id, manv,nhanvien.Name,nhanvien.PhoneNumber,nhanvien.BirthDay.ToString("dd/MM/yyyy"),nhanvien.Sex == true ? "Nam":"Nữ",Convert.ToBoolean(nhanvien.Role) == true ?"Quản Lý":"Nhân Viên",nhanvien.UserName,nhanvien.PassWord, nhanvien.Status == true ?"Đang Hoạt Động":"Không Hoạt Động");
               
                STT++;
            }
            



        }

        private void btn_themnv_Click(object sender, EventArgs e)
        {

            string projectDirectory = Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName;
            File.Copy(linkimage, Path.Combine(projectDirectory, "Resources", "NhanVien", Path.GetFileName(linkimage)), true);
            linkimage = Path.Combine(projectDirectory, "Resources", "NhanVien", Path.GetFileName(linkimage));

            Employee nv = new Employee()
            {
                Name = txb_hovaten.Text,
                PhoneNumber = txb_sdt.Text,
                BirthDay = dtp_ngaysinh.Value,
                Sex = rb_nam.Checked,
                Role = Convert.ToString(rb_quanly.Checked),
                UserName = txb_taikhoan.Text,
                PassWord = txb_matkhau.Text,
                Status = rb_danghd.Checked,
                LinkImage = linkimage
            };
            _inhanvienservice.Add(nv);
            MessageBox.Show("Thêm Thành công");
            LoadNhanVien();

        }

        private void ptb_nhanvien_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if(ofd.ShowDialog() == DialogResult.OK)
            {
                linkimage = ofd.FileName;
                ptb_nhanvien.Image = Image.FromFile(ofd.FileName);
                ptb_nhanvien.SizeMode = PictureBoxSizeMode.Zoom;

            }
        }

        private void dgv_danhsach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow dgr = dgv_danhsach.Rows[e.RowIndex];
            employee = _inhanvienservice.GetAll().FirstOrDefault(x => x.Id == Guid.Parse(dgr.Cells[0].Value.ToString()));
            txb_hovaten.Text = dgr.Cells[2].Value.ToString();
            txb_sdt.Text = dgr.Cells[3].Value.ToString();
            dtp_ngaysinh.Value = employee.BirthDay;
            rb_nam.Checked = dgr.Cells[5].Value.ToString() == "Nam" ? true : false;
            rb_nu.Checked = dgr.Cells[5].Value.ToString() == "Nữ" ? true : false;
            rb_danghd.Checked = dgr.Cells[9].Value.ToString() == "Đang Hoạt Động" ? true : false;
            rb_khonghd.Checked = dgr.Cells[9].Value.ToString() == "Không Hoạt Động" ? true : false;
            rb_quanly.Checked = dgr.Cells[6].Value.ToString() == "Quản Lý" ? true : false;
            rb_nhanvien.Checked = dgr.Cells[6].Value.ToString() == "Nhân Viên" ? true : false;
            txb_taikhoan.Text = dgr.Cells[7].Value.ToString();
            txb_matkhau.Text = dgr.Cells[8].Value.ToString();
            linkimage = employee.LinkImage;
            if(linkimage != null && File.Exists(linkimage))
            {
                ptb_nhanvien.Image = Image.FromFile(linkimage);
                ptb_nhanvien.SizeMode = PictureBoxSizeMode.Zoom;
            }
        }

        private void btn_suanv_Click(object sender, EventArgs e)
        {
            if(employee.LinkImage != linkimage)
            {
                string projectDirectory = Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName;
                File.Copy(linkimage, Path.Combine(projectDirectory, "Resources", "NhanVien", Path.GetFileName(linkimage)), true);
                linkimage = Path.Combine(projectDirectory, "Resources", "NhanVien", Path.GetFileName(linkimage));
            }

            DialogResult dialogResult = MessageBox.Show("Bạn có muốn cập nhật thông tin không ?", "Thông Báo", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                employee.Name = txb_hovaten.Text;
                employee.PhoneNumber = txb_sdt.Text;
                employee.BirthDay = dtp_ngaysinh.Value;
                employee.Sex = rb_nam.Checked;
                employee.UserName = txb_taikhoan.Text;
                employee.PassWord = txb_matkhau.Text;
                employee.Role = Convert.ToString(rb_quanly.Checked);
                employee.Status = rb_danghd.Checked;
                employee.LinkImage = linkimage;
                _inhanvienservice.Update(employee);
                LoadNhanVien();

            }
            MessageBox.Show("Sửa Thành Công");
        }

        private void txb_timkiem_TextChanged(object sender, EventArgs e)
        {


            if (txb_timkiem.Text != "")
            {
                if (cbb_loc_theo_chuc_vu.Text == "Nhân Viên" && cbb_loc_theo_trang_thai.Text == "Đang Hoạt Động")
                {
                    var find = _inhanvienservice.GetAll().Where(x => x.Name.Contains(txb_timkiem.Text) && x.Role == "Nhân Viên" && x.Status == true);
                    int STT = 1;
                    foreach (var nhanvien in find)
                    {
                        string manv = "NV" + STT;

                        dgv_danhsach.Rows.Clear();
                        string formatbirthday = nhanvien.BirthDay.ToString("dd/MM/yyyy");
                        dgv_danhsach.Columns[0].Visible = false;

                        dgv_danhsach.Rows.Add(nhanvien.Id, manv, nhanvien.Name, nhanvien.PhoneNumber, nhanvien.BirthDay.ToString("dd/MM/yyyy"), nhanvien.Sex == true ? "Nam" : "Nữ", Convert.ToBoolean(nhanvien.Role) == true ? "Quản Lý" : "Nhân Viên", nhanvien.UserName, nhanvien.PassWord, nhanvien.Status == true ? "Đang Hoạt Động" : "Không Hoạt Động");
                        STT++;
                    }
                }
                if (cbb_loc_theo_chuc_vu.Text == "Nhân Viên" && cbb_loc_theo_trang_thai.Text == "Không Hoạt Động")
                {
                    var find = _inhanvienservice.GetAll().Where(x => x.Name.Contains(txb_timkiem.Text) && x.Role == "Nhân Viên" && x.Status == false);
                    int STT = 1;
                    foreach (var nhanvien in find)
                    {
                        string manv = "NV" + STT;

                        dgv_danhsach.Rows.Clear();
                        string formatbirthday = nhanvien.BirthDay.ToString("dd/MM/yyyy");
                        dgv_danhsach.Columns[0].Visible = false;

                        dgv_danhsach.Rows.Add(nhanvien.Id, manv, nhanvien.Name, nhanvien.PhoneNumber, nhanvien.BirthDay.ToString("dd/MM/yyyy"), nhanvien.Sex == true ? "Nam" : "Nữ", Convert.ToBoolean(nhanvien.Role) == true ? "Quản Lý" : "Nhân Viên", nhanvien.UserName, nhanvien.PassWord, nhanvien.Status == true ? "Đang Hoạt Động" : "Không Hoạt Động");
                        STT++;
                    }
                }
                if (cbb_loc_theo_chuc_vu.Text == "Quản Lý" && cbb_loc_theo_trang_thai.Text == "Không Hoạt Động")
                {
                    var find = _inhanvienservice.GetAll().Where(x => x.Name.Contains(txb_timkiem.Text) && x.Role == "Quản Lý" && x.Status == false);
                    int STT = 1;
                    foreach (var nhanvien in find)
                    {
                        string manv = "NV" + STT;

                        dgv_danhsach.Rows.Clear();
                        string formatbirthday = nhanvien.BirthDay.ToString("dd/MM/yyyy");
                        dgv_danhsach.Columns[0].Visible = false;

                        dgv_danhsach.Rows.Add(nhanvien.Id, manv, nhanvien.Name, nhanvien.PhoneNumber, nhanvien.BirthDay.ToString("dd/MM/yyyy"), nhanvien.Sex == true ? "Nam" : "Nữ", Convert.ToBoolean(nhanvien.Role) == true ? "Quản Lý" : "Nhân Viên", nhanvien.UserName, nhanvien.PassWord, nhanvien.Status == true ? "Đang Hoạt Động" : "Không Hoạt Động");
                        STT++;
                    }
                }
                if (cbb_loc_theo_chuc_vu.Text == "Quản Lý" && cbb_loc_theo_trang_thai.Text == "Đang Hoạt Động")
                {
                    var find = _inhanvienservice.GetAll().Where(x => x.Name.Contains(txb_timkiem.Text) && x.Role == "Quản Lý" && x.Status == true);
                    int STT = 1;
                    foreach (var nhanvien in find)
                    {
                        string manv = "NV" + STT;

                        dgv_danhsach.Rows.Clear();
                        string formatbirthday = nhanvien.BirthDay.ToString("dd/MM/yyyy");
                        dgv_danhsach.Columns[0].Visible = false;

                        dgv_danhsach.Rows.Add(nhanvien.Id, manv, nhanvien.Name, nhanvien.PhoneNumber, nhanvien.BirthDay.ToString("dd/MM/yyyy"), nhanvien.Sex == true ? "Nam" : "Nữ", Convert.ToBoolean(nhanvien.Role) == true ? "Quản Lý" : "Nhân Viên", nhanvien.UserName, nhanvien.PassWord, nhanvien.Status == true ? "Đang Hoạt Động" : "Không Hoạt Động");
                        STT++;
                    }
                }
                if (cbb_loc_theo_chuc_vu.Text == "" && cbb_loc_theo_trang_thai.Text == "")
                {
                    var find = _inhanvienservice.GetAll().Where(x => x.Name.Contains(txb_timkiem.Text));
                    int STT = 1;
                    foreach (var nhanvien in find)
                    {
                        string manv = "NV" + STT;

                        dgv_danhsach.Rows.Clear();
                        string formatbirthday = nhanvien.BirthDay.ToString("dd/MM/yyyy");
                        dgv_danhsach.Columns[0].Visible = false;

                        dgv_danhsach.Rows.Add(nhanvien.Id, manv, nhanvien.Name, nhanvien.PhoneNumber, nhanvien.BirthDay.ToString("dd/MM/yyyy"), nhanvien.Sex == true ? "Nam" : "Nữ", Convert.ToBoolean(nhanvien.Role) == true ? "Quản Lý" : "Nhân Viên", nhanvien.UserName, nhanvien.PassWord, nhanvien.Status == true ? "Đang Hoạt Động" : "Không Hoạt Động");
                        STT++;
                    }
                }
                if(cbb_loc_theo_chuc_vu.Text == "" && cbb_loc_theo_trang_thai.Text == "Đang Hoạt Động")
                {
                    var find = _inhanvienservice.GetAll().Where(x => x.Name.Contains(txb_timkiem.Text) && x.Status == true);
                    int STT = 1;
                    foreach (var nhanvien in find)
                    {
                        string manv = "NV" + STT;

                        dgv_danhsach.Rows.Clear();
                        string formatbirthday = nhanvien.BirthDay.ToString("dd/MM/yyyy");
                        dgv_danhsach.Columns[0].Visible = false;

                        dgv_danhsach.Rows.Add(nhanvien.Id, manv, nhanvien.Name, nhanvien.PhoneNumber, nhanvien.BirthDay.ToString("dd/MM/yyyy"), nhanvien.Sex == true ? "Nam" : "Nữ", Convert.ToBoolean(nhanvien.Role) == true ? "Quản Lý" : "Nhân Viên", nhanvien.UserName, nhanvien.PassWord, nhanvien.Status == true ? "Đang Hoạt Động" : "Không Hoạt Động");
                        STT++;
                    }
                }
                if(cbb_loc_theo_chuc_vu.Text == "" && cbb_loc_theo_trang_thai.Text == "Không Hoạt Động")
                {
                    var find = _inhanvienservice.GetAll().Where(x => x.Name.Contains(txb_timkiem.Text) && x.Status == false);
                    int STT = 1;
                    foreach (var nhanvien in find)
                    {
                        string manv = "NV" + STT;

                        dgv_danhsach.Rows.Clear();
                        string formatbirthday = nhanvien.BirthDay.ToString("dd/MM/yyyy");
                        dgv_danhsach.Columns[0].Visible = false;

                        dgv_danhsach.Rows.Add(nhanvien.Id, manv, nhanvien.Name, nhanvien.PhoneNumber, nhanvien.BirthDay.ToString("dd/MM/yyyy"), nhanvien.Sex == true ? "Nam" : "Nữ", Convert.ToBoolean(nhanvien.Role) == true ? "Quản Lý" : "Nhân Viên", nhanvien.UserName, nhanvien.PassWord, nhanvien.Status == true ? "Đang Hoạt Động" : "Không Hoạt Động");
                        STT++;
                    }
                }
                if(cbb_loc_theo_chuc_vu.Text == "Quản Lý" && cbb_loc_theo_trang_thai.Text == "")
                {
                    var find = _inhanvienservice.GetAll().Where(x => x.Name.Contains(txb_timkiem.Text) && x.Role == "Quản Lý");
                    int STT = 1;
                    foreach (var nhanvien in find)
                    {
                        string manv = "NV" + STT;

                        dgv_danhsach.Rows.Clear();
                        string formatbirthday = nhanvien.BirthDay.ToString("dd/MM/yyyy");
                        dgv_danhsach.Columns[0].Visible = false;

                        dgv_danhsach.Rows.Add(nhanvien.Id, manv, nhanvien.Name, nhanvien.PhoneNumber, nhanvien.BirthDay.ToString("dd/MM/yyyy"), nhanvien.Sex == true ? "Nam" : "Nữ", Convert.ToBoolean(nhanvien.Role) == true ? "Quản Lý" : "Nhân Viên", nhanvien.UserName, nhanvien.PassWord, nhanvien.Status == true ? "Đang Hoạt Động" : "Không Hoạt Động");
                        STT++;
                    }
                }if(cbb_loc_theo_chuc_vu.Text == "Nhân Viên" && cbb_loc_theo_trang_thai.Text == "")
                {
                    var find = _inhanvienservice.GetAll().Where(x => x.Name.Contains(txb_timkiem.Text) && x.Role == "Nhân Viên");
                    int STT = 1;
                    foreach (var nhanvien in find)
                    {
                        string manv = "NV" + STT;

                        dgv_danhsach.Rows.Clear();
                        string formatbirthday = nhanvien.BirthDay.ToString("dd/MM/yyyy");
                        dgv_danhsach.Columns[0].Visible = false;

                        dgv_danhsach.Rows.Add(nhanvien.Id, manv, nhanvien.Name, nhanvien.PhoneNumber, nhanvien.BirthDay.ToString("dd/MM/yyyy"), nhanvien.Sex == true ? "Nam" : "Nữ", Convert.ToBoolean(nhanvien.Role) == true ? "Quản Lý" : "Nhân Viên", nhanvien.UserName, nhanvien.PassWord, nhanvien.Status == true ? "Đang Hoạt Động" : "Không Hoạt Động");
                        STT++;
                    }
                }
            }

            

        }

        private void cbb_loc_theo_chuc_vu_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            
        }

        private void cbb_loc_theo_chuc_vu_TextChanged(object sender, EventArgs e)
        {
            //if(cbb_loc_theo_chuc_vu.Text == "Quản Lý")
            //{
            //    var find = _inhanvienservice.GetAll().Where(x => x.Role == "Quản Lý");
            //    int STT = 1;
            //    foreach (var nhanvien in find)
            //    {
            //        string manv = "NV" + STT;

            //        dgv_danhsach.Rows.Clear();
            //        string formatbirthday = nhanvien.BirthDay.ToString("dd/MM/yyyy");
            //        dgv_danhsach.Columns[0].Visible = false;

            //        dgv_danhsach.Rows.Add(nhanvien.Id, manv, nhanvien.Name, nhanvien.PhoneNumber, nhanvien.BirthDay.ToString("dd/MM/yyyy"), nhanvien.Sex == true ? "Nam" : "Nữ", Convert.ToBoolean(nhanvien.Role) == true ? "Quản Lý" : "Nhân Viên", nhanvien.UserName, nhanvien.PassWord, nhanvien.Status == true ? "Đang Hoạt Động" : "Không Hoạt Động");
            //        STT++;
            //    }
            //}
            //if(cbb_loc_theo_chuc_vu.Text == "Nhân Viên")
            //{
            //    var find = _inhanvienservice.GetAll().Where(x => x.Role == "Nhân Viên");
            //    int STT = 1;
            //    foreach (var nhanvien in find)
            //    {
            //        string manv = "NV" + STT;

            //        dgv_danhsach.Rows.Clear();
            //        string formatbirthday = nhanvien.BirthDay.ToString("dd/MM/yyyy");
            //        dgv_danhsach.Columns[0].Visible = false;

            //        dgv_danhsach.Rows.Add(nhanvien.Id, manv, nhanvien.Name, nhanvien.PhoneNumber, nhanvien.BirthDay.ToString("dd/MM/yyyy"), nhanvien.Sex == true ? "Nam" : "Nữ", Convert.ToBoolean(nhanvien.Role) == true ? "Quản Lý" : "Nhân Viên", nhanvien.UserName, nhanvien.PassWord, nhanvien.Status == true ? "Đang Hoạt Động" : "Không Hoạt Động");
            //        STT++;
            //    }
            //}
            //if (txb_timkiem.Text == "")
            //{
            //   // LoadNhanVien();
            //}
        }

        private void frmNhanVien_Load(object sender, EventArgs e)
        {

        }
    }
}
