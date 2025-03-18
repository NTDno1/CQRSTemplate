using ERP.Domain.Entities.WareHouses.NhapKho;
using ERP.Share.Extensions;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ERP.Persistence.Configurations.WareHouses;
public sealed class NhapKhoConfiguration : IEntityTypeConfiguration<NhapKho>
{
    public void Configure(EntityTypeBuilder<NhapKho> builder)
    {
        builder.ToTable("WH_NhapKho");

        builder.HasKey(cn => cn.Id);

        builder
            .Property(e => e.Id)
            .HasConversion(EfCoreConverters.UlidToGuidConverter).HasColumnType("char(26)");

        builder.Property(cn => cn.SoChungTu)
            .HasMaxLength(30)
            .HasColumnType("varchar");

        builder.Property(cn => cn.TrangThaiPhieu)
           .HasMaxLength(30)
           .HasColumnType("nvarchar");

        builder.Property(e => e.LoaiNhapKho)
         .HasConversion(
             v => v.Value,
             v => LoaiNhapKho.FromValue(v))
         .IsRequired()
         .HasMaxLength(64)
         .HasColumnType("nvarchar");


        builder.Property(cn => cn.MaDoiTuong)
          .HasMaxLength(30)
          .HasColumnType("varchar");



        builder.Property(cn => cn.MaDoiTuong)
          .HasMaxLength(30)
          .HasColumnType("varchar");


        builder.Property(cn => cn.NguoiGiaoHang)
          .HasMaxLength(30)
          .HasColumnType("varchar");

        builder.Property(cn => cn.DienGiai)
        .HasMaxLength(1024)
        .HasColumnType("nvarchar");

        builder.Property(cn => cn.NhanVienMuaHang)
          .HasMaxLength(30)
          .HasColumnType("varchar");

        builder.Property(cn => cn.TrucThuoc)
         .HasMaxLength(30)
         .HasColumnType("varchar");


        builder.Property(cn => cn.SoHoaDonNhaCungCap)
            .HasMaxLength(64)
            .HasColumnType("varchar");


        builder.Property(cn => cn.MaSoPo)
            .HasMaxLength(30)
            .HasColumnType("varchar");

        builder.Property(cn => cn.KhoNhanHang)
           .HasMaxLength(30)
           .HasColumnType("varchar");

        builder
            .Property(e => e.IdDieuKhoanThanhToan)
            .HasConversion(EfCoreConverters.UlidToGuidConverter).HasColumnType("char(26)");


        builder
            .Property(e => e.IdDieuKhoanThanhToanNoiBo)
            .HasConversion(EfCoreConverters.UlidToGuidConverter).HasColumnType("char(26)");


        builder.Property(e => e.TrangThaiHoaDon)
        .HasConversion(
            v => v.Value,
            v => TrangThaiHoaDon.FromValue(v))
        .IsRequired()
        .HasMaxLength(64)
        .HasColumnType("nvarchar");


        builder.Property(e => e.MaNhaCungCapNuocNgoai)
        .HasMaxLength(30)
        .HasColumnType("varchar");

        builder.Property(e => e.MaVanDonLayHang)
                .HasMaxLength(30)
        .HasColumnType("varchar");

        builder.Property(e => e.SoBill)
                .HasMaxLength(30).HasColumnType("varchar");

        builder.Property(e => e.SaCare)
                .HasMaxLength(30).HasColumnType("varchar");

        builder.Property(e => e.SrCare)
                .HasMaxLength(30).HasColumnType("varchar");

        builder.Property(e => e.LoaiHoaDon)
                .HasMaxLength(64).HasColumnType("nvarchar");

        builder.Property(e => e.KtPhuTrach)
                .HasMaxLength(30).HasColumnType("varchar");

        builder.Property(e => e.GhiChuHoaDon)
                .HasMaxLength(1024).HasColumnType("nvarchar");

        builder.Property(e => e.Khoa)
                .IsRequired()
                .HasDefaultValue(false);

        builder.Property(e => e.DaTraLaiNcc)
            .IsRequired().HasDefaultValue(false);

        builder.Property(e => e.DaChiTien)
            .IsRequired().HasDefaultValue(false);

        builder.Property(e => e.DaDuHoaDon)
            .IsRequired().HasDefaultValue(false);

        builder.Property(e => e.IsTachPhieu)
            .IsRequired().HasDefaultValue(false);

        builder.Property(e => e.CanDiLayHang)
            .IsRequired().HasDefaultValue(false);


    }
}
