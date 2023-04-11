using _1_DAL.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_DAL.Configurations
{
    public class SupplierConfigurations : IEntityTypeConfiguration<Supplier>
    {
        public void Configure(EntityTypeBuilder<Supplier> builder)
        {
            builder.ToTable("Supplier");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Name).HasColumnType("nvarchar(200)").IsRequired();
            builder.Property(x => x.HinhAnh)
          .HasColumnType("varbinary(MAX)")
          .IsRequired();
            builder.Property(x => x.DiaChi).HasColumnType("nchar(50)").IsRequired(); // Thêm thuộc tính cho cột DiaChi
            builder.Property(x => x.DienThoai).HasColumnType("nchar(12)").IsRequired(); // Thêm thuộc tính cho cột DienThoai
            builder.Property(x => x.Email).HasColumnType("nchar(50)").IsRequired(); // Thêm thuộc tính cho cột Email
            builder.Property(x => x.Website).HasColumnType("nchar(30)"); // Thêm thuộc tính cho cột Website
            builder.Property(x => x.GhiChu).HasColumnType("nchar(250)"); // Thêm thuộc tính cho cột GhiChu
        }
    }
}
