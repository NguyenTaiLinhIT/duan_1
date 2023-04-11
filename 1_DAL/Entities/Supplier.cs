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
        public virtual List<SupplierDetail> SupplierDetails { get; set; }
    }
}
