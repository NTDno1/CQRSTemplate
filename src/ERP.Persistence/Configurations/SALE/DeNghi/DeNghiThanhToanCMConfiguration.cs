using ERP.Domain.Entities.Sales.DeNghi.DeNghiThanhToanCM;
using ERP.Domain.Entities.Sales.DeNghiThanhToan.DeNghiThanhToanCM;
using ERP.Domain.Entities.Shared;
using ERP.Share.Extensions;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ERP.Persistence.Configurations.SALE.DeNghi;


internal sealed class DeNghiThanhToanCMConfiguration : IEntityTypeConfiguration<DeNghiThanhToanCM>
{
    public void Configure(EntityTypeBuilder<DeNghiThanhToanCM> builder)
    {
        builder.ToTable("SALE_DeNghiThanhToanCM");

        builder.HasKey(dn => dn.Id);

        builder
            .Property(e => e.Id)
            .HasConversion(EfCoreConverters.UlidToGuidConverter).HasColumnType("char(26)");

        builder.Property(cn => cn.MaDeNghi)
            .HasMaxLength(30)
            .HasColumnType("varchar");

        builder
            .Property(e => e.IdKhachHang)
            .HasConversion(EfCoreConverters.UlidToGuidConverter).HasColumnType("char(26)");


        builder.Property(dn => dn.NoiDungNgheNghiThanhToan)
            .HasMaxLength(128)
            .HasColumnType("nvarchar");


        builder.Property(dn => dn.TrucThuoc)
             .HasConversion(
                 v => v.Value,
                 v => TrucThuoc.FromValue(v))
             .IsRequired()
             .HasMaxLength(50)
             .HasColumnType("varchar");

        builder.Property(dn => dn.NguoiDuyet)
            .HasMaxLength(30)
            .HasColumnType("varchar");

        builder.Property(dn => dn.TrangThai)
             .HasConversion(
                 v => v.Value,
                 v => TrangThaiDuyetDNTT.FromValue(v))
             .IsRequired()
             .HasMaxLength(50)
             .HasColumnType("nvarchar");

        builder.Property(dn => dn.LyDoHuy)
            .HasMaxLength(128)
            .HasColumnType("nvarchar");

        builder.Property(dn => dn.NguoiThanhToan)
            .HasMaxLength(30)
            .HasColumnType("varchar");

        builder.Property(dn => dn.HinhThucThanhToan)
             .HasConversion(
                 v => v.Value,
                 v => HinhThucThanhToan.FromValue(v))
             .IsRequired()
             .HasMaxLength(50)
             .HasColumnType("nvarchar");

        builder.Property(dn => dn.ThanhToanTheoTaiKhoan)
             .HasConversion(
                 v => v.Value,
                 v => ThanhToanTheoTaiKhoan.FromValue(v))
             .IsRequired()
             .HasMaxLength(50)
             .HasColumnType("varchar");

        builder.OwnsOne(dn => dn.TaiKhoanNganHangNhan, tk =>
        {
            tk.Property(tk => tk.SoTaiKhoan).HasMaxLength(50).HasColumnType("varchar").HasColumnName("SoTaiKhoan");
            tk.Property(tk => tk.NganHang).HasMaxLength(50).HasColumnType("nvarchar").HasColumnName("NganHang");
            tk.Property(tk => tk.ChiNhanhNganHang).HasMaxLength(128).HasColumnType("nvarchar").HasColumnName("ChiNhanhNganHang");
            tk.Property(tk => tk.NguoiThuHuong).HasMaxLength(128).HasColumnType("nvarchar").HasColumnName("NguoiThuHuong");
        });
    }

}
