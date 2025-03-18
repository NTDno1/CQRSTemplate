using ERP.Domain.Entities.Sales.KhachHang.TaiKhoanNganHang;
using ERP.Share.Extensions;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ERP.Persistence.Configurations.SALE.KhachHang;


internal sealed class TaiKhoanNganHangKhachHangConfiguration : IEntityTypeConfiguration<TaiKhoanNganHangKhachHang>
{
    public void Configure(EntityTypeBuilder<TaiKhoanNganHangKhachHang> builder)
    {
        builder.ToTable("SALE_KH_TaiKhoanNganHang");

        builder.HasKey(x => x.Id);

        builder
            .Property(e => e.Id)
            .HasConversion(EfCoreConverters.UlidToGuidConverter).HasColumnType("char(26)");


        builder
            .Property(e => e.IdKhachHang)
            .HasConversion(EfCoreConverters.UlidToGuidConverter).HasColumnType("char(26)");


        builder.Property(x => x.SoTaiKhoan)
            .IsRequired()
            .HasMaxLength(30)
            .HasColumnType("varchar");

        builder.Property(x => x.LoaiTaiKhoan)
             .HasConversion(
                 v => v.Value,
                 v => LoaiTaiKhoan.FromValue(v))
             .IsRequired()
             .HasMaxLength(50)
             .HasColumnType("nvarchar");

        builder.Property(x => x.HinhThucThanhToan)
             .HasConversion(
                 v => v.Value,
                 v => HinhThucThanhToan.FromValue(v))
             .IsRequired()
             .HasMaxLength(50)
             .HasColumnType("nvarchar");

        builder.Property(x => x.TenTaiKhoan)
            .HasMaxLength(30)
            .HasColumnType("nvarchar");

        builder.Property(x => x.NganHang)
            .HasMaxLength(30)
            .HasColumnType("nvarchar");

        builder.Property(x => x.ChiNhanh)
            .HasMaxLength(30)
            .HasColumnType("nvarchar");

        builder.Property(x => x.TinhThanhPho)
            .HasMaxLength(30)
            .HasColumnType("nvarchar");

        builder.HasOne(x => x.KhachHang)
           .WithMany(k => k.TaiKhoanNganHangKhachHangs)
           .HasForeignKey(x => x.IdKhachHang);

    }
}
