using ERP.Domain.Entities.Sales.KhachHang;
using ERP.Share.Extensions;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ERP.Persistence.Configurations.SALE.KhachHang;


internal sealed class KhachHangLienHeConfiguration : IEntityTypeConfiguration<KhachHangLienHe>
{
    public void Configure(EntityTypeBuilder<KhachHangLienHe> builder)
    {
        builder.ToTable("SALE_KH_LienHe");

        builder.HasKey(x => x.Id);

        builder
            .Property(e => e.Id)
            .HasConversion(EfCoreConverters.UlidToGuidConverter).HasColumnType("char(26)");


        builder.Property(x => x.TenLienHe)
            .IsRequired()
            .HasMaxLength(50)
            .HasColumnType("nvarchar");

        builder.Property(x => x.VaiTro)
            .IsRequired()
            .HasMaxLength(30)
            .HasColumnType("nvarchar");

        builder.Property(x => x.Email)
            .HasMaxLength(30)
            .HasColumnType("varchar");

        builder.Property(cn => cn.SoDienThoai)
            .HasMaxLength(20)
            .HasColumnType("varchar");

        builder.Property(ctp => ctp.TinhTrang)
             .HasConversion(
                 v => v.Value,
                 v => TinhTrangKhachHangLienHe.FromValue(v))
             .IsRequired()
             .HasMaxLength(50)
             .HasColumnType("nvarchar");

        builder.Property(x => x.GhiChu)
           .IsRequired()
           .HasMaxLength(128)
           .HasColumnType("nvarchar");
        builder.HasOne(x => x.KhachHang)
           .WithMany(k => k.KhachHangLienHes)
           .HasForeignKey(x => x.IdKhachHang);
    }
}
