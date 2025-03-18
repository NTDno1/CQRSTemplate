using ERP.Domain.Entities.Sales.KhachHang;
using ERP.Share.Extensions;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ERP.Persistence.Configurations.SALE.KhachHang;
internal sealed class KhachHangConfiguration : IEntityTypeConfiguration<Domain.Entities.Sales.KhachHang.KhachHang>
{
    public void Configure(EntityTypeBuilder<Domain.Entities.Sales.KhachHang.KhachHang> builder)
    {
        builder.ToTable("Sale_KH");
        builder.HasKey(x => x.Id);

        builder
            .Property(e => e.Id)
            .HasConversion(EfCoreConverters.UlidToGuidConverter).HasColumnType("char(26)");


        builder.Property(x => x.MaKhachHang)
           .HasMaxLength(30)
           .HasColumnType("varchar");

        builder
            .Property(e => e.IdKhachHangCha)
            .HasConversion(EfCoreConverters.UlidToGuidConverter).HasColumnType("char(26)");


        builder.OwnsOne(kh => kh.ThongTinLienHe, tt =>
        {
            tt.Property(tt => tt.TenCongTy)
                .HasColumnName("TenCongTy")
                .IsRequired()
                .HasMaxLength(128)
                .HasColumnType("nvarchar");

            tt.Property(tt => tt.DiaChiVanPhong)
                .HasColumnName("DiaChiVanPhong")
                .HasMaxLength(500)
                .HasColumnType("nvarchar");

            tt.Property(tt => tt.DiaChiXuatHoaDon)
                .HasColumnName("DiaChiXuatHoaDon")
                .IsRequired()
                .HasMaxLength(500)
                .HasColumnType("nvarchar");

            tt.Property(tt => tt.EmailNhanHoaDon)
                .HasColumnName("EmailNhanHoaDon")
                .HasMaxLength(128)
                .HasColumnType("varchar");

            tt.Property(tt => tt.SoDienThoai)
                .HasColumnName("SoDienThoai")
                .HasMaxLength(30)
                .HasColumnType("varchar");

            tt.Property(tt => tt.MaSoThue)
                .HasColumnName("MaSoThue")
                .HasMaxLength(30)
                .HasColumnType("varchar");

            tt.Property(tt => tt.Website)
                .HasColumnName("Website")
                .HasMaxLength(50)
                .HasColumnType("varchar");
        });

        builder.Property(kh => kh.SoNhaDuongPhoGiaoHang)
            .IsRequired()
            .HasMaxLength(128)
            .HasColumnType("nvarchar");

        builder.Property(kh => kh.QuanHuyenGiaoHang)
            .IsRequired()
            .HasMaxLength(128)
            .HasColumnType("nvarchar");

        builder.Property(kh => kh.TinhThanhPhoGiaoHang)
            .IsRequired()
            .HasMaxLength(128)
            .HasColumnType("nvarchar");

        builder.Property(e => e.HoaDonMacDinh)
            .HasConversion(
                v => v.Value,
                v => HoaDon.FromValue(v))
            .IsRequired()
            .HasMaxLength(50)
            .HasColumnType("nvarchar");

        builder.Property(kh => kh.GhiChuHoaDonMacDinh)
            .IsRequired(false)
            .HasMaxLength(255)
            .HasColumnType("nvarchar");

        builder
            .Property(e => e.IdLoaiKhach)
            .HasConversion(EfCoreConverters.UlidToGuidConverter).HasColumnType("char(26)");


        builder
            .Property(e => e.IdDieuKhoanThanhToan)
            .HasConversion(EfCoreConverters.UlidToGuidConverter).HasColumnType("char(26)");


        builder
            .Property(e => e.IdDieuKhoanThanhToanNoiBo)
            .HasConversion(EfCoreConverters.UlidToGuidConverter).HasColumnType("char(26)");


        builder.Property(kh => kh.NganhNghe)
            .IsRequired()
            .HasMaxLength(128)
            .HasColumnType("nvarchar");

        builder.Property(kh => kh.HeThongKhachHang)
            .IsRequired()
            .HasMaxLength(128)
            .HasColumnType("nvarchar");

        builder.Property(kh => kh.MangKinhDoanh)
            .IsRequired()
            .HasMaxLength(128)
            .HasColumnType("nvarchar");


        builder.Property(kh => kh.GiayChungNhanDauTu)
            .HasMaxLength(128)
            .HasColumnType("nvarchar");


        builder.Property(kh => kh.KhuCongNghiep)
           .IsRequired()
           .HasMaxLength(128)
           .HasColumnType("nvarchar");

        builder.Property(kh => kh.NguonGocKhachHang)
           .IsRequired()
           .HasMaxLength(128)
           .HasColumnType("nvarchar");

        builder.Property(kh => kh.SR)
           .IsRequired(false)
           .HasMaxLength(20)
           .HasColumnType("varchar");

        builder.Property(kh => kh.SR_DangKy)
           .IsRequired(false)
           .HasMaxLength(20)
           .HasColumnType("varchar");

        builder.Property(kh => kh.SR2)
           .HasMaxLength(20)
           .HasColumnType("varchar");

        builder.Property(kh => kh.SR2_DangKy)
           .HasMaxLength(20)
           .HasColumnType("varchar");

        builder.Property(kh => kh.SA)
           .HasMaxLength(20)
           .HasColumnType("varchar");

        builder.Property(kh => kh.SA_DangKy)
           .HasMaxLength(20)
           .HasColumnType("varchar");

        builder.Property(kh => kh.QuanLy)
           .HasMaxLength(20)
           .HasColumnType("varchar");

        builder.Property(kh => kh.BU)
              .HasMaxLength(50)
              .HasColumnType("varchar");

        builder.Property(kh => kh.GhiChuKhachHang)
             .IsRequired(false)
             .HasMaxLength(128)
             .HasColumnType("nvarchar");

        builder.Property(kh => kh.HoSoThanhToan)
            .IsRequired(false)
            .HasMaxLength(128)
            .HasColumnType("nvarchar");

        builder.Property(e => e.TinhTrangHoatDong)
           .HasConversion(
               v => v.Value,
               v => TinhTrangHoatDong.FromValue(v))
           .IsRequired()
           .HasMaxLength(50)
           .HasColumnType("nvarchar");

        builder.Property(kh => kh.NguoiDaiDien)
            .IsRequired(false)
            .HasMaxLength(128)
            .HasColumnType("nvarchar");

        builder.Property(kh => kh.ChucVuNguoiDaiDien)
            .IsRequired(false)
            .HasMaxLength(128)
            .HasColumnType("nvarchar");

        builder.Property(kh => kh.CMNDNguoiDaiDien)
            .IsRequired(false)
            .HasMaxLength(128)
            .HasColumnType("varchar");

        builder.Property(kh => kh.GhiChuCongNo)
            .IsRequired(false)
            .HasMaxLength(128)
            .HasColumnType("nvarchar");

        builder.Property(e => e.InTheoMauMacDinh)
          .HasConversion(
              v => v.Value,
              v => InTheoMauMacDinh.FromValue(v))
          .IsRequired()
          .HasMaxLength(50)
          .HasColumnType("varchar");

        builder.Property(kh => kh.KhoMacDinh)
            .IsRequired(false)
            .HasMaxLength(128)
            .HasColumnType("varchar");

        builder.Property(e => e.TemMacDinh)
             .HasConversion(
                 v => v.Value,
                 v => TemMacDinh.FromValue(v))
             .IsRequired()
             .HasMaxLength(50)
             .HasColumnType("nvarchar");

        builder.Property(e => e.VendorStatus)
             .HasConversion(
                 v => v.Value,
                 v => VendorStatus.FromValue(v))
             .IsRequired()
             .HasMaxLength(50)
             .HasColumnType("nvarchar");

    }
}
