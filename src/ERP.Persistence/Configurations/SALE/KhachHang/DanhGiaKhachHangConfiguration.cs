using ERP.Domain.Entities.Sales.KhachHang.DanhGiaKhachHang;
using ERP.Share.Extensions;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ERP.Persistence.Configurations.SALE.KhachHang;


internal sealed class DanhGiaKhachHangConfiguration : IEntityTypeConfiguration<DanhGiaKhachHang>
{
    public void Configure(EntityTypeBuilder<DanhGiaKhachHang> builder)
    {
        builder.ToTable("SALE_KH_DanhGiaKhachHang");

        builder.HasKey(x => x.Id);

        builder
            .Property(e => e.Id)
            .HasConversion(EfCoreConverters.UlidToGuidConverter).HasColumnType("char(26)");


        builder
            .Property(e => e.IdCTKMThamGia)
            .HasConversion(EfCoreConverters.UlidToGuidConverter).HasColumnType("char(26)");


        builder
            .Property(e => e.IdKhachHang)
            .HasConversion(EfCoreConverters.UlidToGuidConverter).HasColumnType("char(26)");


        builder.Property(x => x.NganhNghe)
            .HasMaxLength(128)
            .HasColumnType("nvarchar");

        builder.Property(x => x.NguoiQuyetDinhMuaHang)
           .HasMaxLength(128)
           .HasColumnType("nvarchar");

        builder.Property(x => x.SanPhamQuanTam)
          .HasMaxLength(128)
          .HasColumnType("nvarchar");

        builder.Property(x => x.HangQuanTam)
          .HasMaxLength(128)
          .HasColumnType("nvarchar");

        builder.Property(x => x.DoiThuCanhTranh)
          .HasMaxLength(128)
          .HasColumnType("nvarchar");

        builder.Property(x => x.CoHoiPhatTrien)
          .HasMaxLength(128)
          .HasColumnType("nvarchar");

        builder.Property(x => x.HopDongDaKy)
          .HasMaxLength(128)
          .HasColumnType("nvarchar");

        builder.Property(x => x.DuAnTiemNangSapToi)
          .HasMaxLength(128)
          .HasColumnType("nvarchar");

        builder.Property(x => x.TinhHinhTaiChinh)
          .HasMaxLength(128)
          .HasColumnType("nvarchar");

        builder.Property(x => x.LuuY)
          .HasMaxLength(128)
          .HasColumnType("nvarchar");

        builder.HasOne(x => x.KhachHang)
          .WithMany(k => k.DanhGiaKhachHangs)
          .HasForeignKey(x => x.IdKhachHang);
    }
}
