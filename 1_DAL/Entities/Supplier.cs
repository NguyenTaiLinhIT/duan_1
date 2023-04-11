using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_DAL.Entities
{
    public class Supplier
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public byte[] HinhAnh { get; set; }
        public string DiaChi { get; set; } // Thêm thuộc tính cho cột DiaChi
        public string DienThoai { get; set; } // Thêm thuộc tính cho cột DienThoai
        public string Email { get; set; } // Thêm thuộc tính cho cột Email
        public string Website { get; set; } // Thêm thuộc tính cho cột Website
        public string GhiChu { get; set; } // Thêm thuộc tính cho cột GhiChu
        public virtual List<SupplierDetail> SupplierDetails { get; set; }
    }
}
