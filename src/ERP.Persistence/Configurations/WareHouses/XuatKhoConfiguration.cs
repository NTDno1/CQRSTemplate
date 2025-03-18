using ERP.Domain.Entities.Sales.KhachHang;
using ERP.Domain.Entities.WareHouses.XuatKho;
using ERP.Share.Extensions;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ERP.Persistence.Configurations.WareHouses;
public class XuatKhoConfiguration : IEntityTypeConfiguration<XuatKho>
{
    public void Configure(EntityTypeBuilder<XuatKho> builder)
    {
        builder.ToTable("WH_XuatKho");

        builder.HasKey(cn => cn.Id);

        builder
            .Property(e => e.Id)
            .HasConversion(EfCoreConverters.UlidToGuidConverter).HasColumnType("char(26)");


        builder.Property(cn => cn.SoChungTu)
            .HasMaxLength(30)
            .HasColumnType("varchar");

        builder.Property(cn => cn.TenNguoiNhan)
            .HasMaxLength(64)
            .HasColumnType("nvarchar");

        builder.Property(cn => cn.SdtNguoiNhan)
           .HasMaxLength(20)
           .HasColumnType("varchar");

        builder.Property(cn => cn.DiaChiGiaoHang)
           .HasMaxLength(128)
           .HasColumnType("nvarchar");


        builder.Property(cn => cn.LyDoXuat)
          .HasMaxLength(255)
          .HasColumnType("nvarchar");

        builder.Property(cn => cn.SR)
         .HasMaxLength(30)
         .HasColumnType("varchar");

        builder.Property(cn => cn.SA)
       .HasMaxLength(30)
       .HasColumnType("varchar");

        builder.Property(cn => cn.TrucThuoc)
       .HasMaxLength(30)
       .HasColumnType("varchar");

        builder.Property(cn => cn.MaDoiTuong)
        .HasMaxLength(30)
        .HasColumnType("varchar");

        builder
           .Property(e => e.IdDieuKhoanThanhToan)
           .HasConversion(EfCoreConverters.UlidToGuidConverter).HasColumnType("char(26)");


        builder
            .Property(e => e.IdDieuKhoanThanhToanNoiBo)
            .HasConversion(EfCoreConverters.UlidToGuidConverter).HasColumnType("char(26)");



        builder.Property(cn => cn.HoaDonChungTu)
      .HasMaxLength(30)
      .HasColumnType("varchar");

        builder.Property(cn => cn.TenCongTyXuatHoaDon)
      .HasMaxLength(128)
      .HasColumnType("nvarchar");

        builder
            .Property(e => e.IdBaoGia)
            .HasConversion(EfCoreConverters.UlidToGuidConverter).HasColumnType("char(26)");


        builder.Property(cn => cn.DiaChiXuatHoaDon)
      .HasMaxLength(128)
      .HasColumnType("nvarchar");

        builder.Property(cn => cn.Mst)
     .HasMaxLength(64)
     .HasColumnType("varchar");

        builder
            .Property(e => e.IdCtkm)
            .HasConversion(EfCoreConverters.UlidToGuidConverter).HasColumnType("char(26)");


        builder.Property(cn => cn.EmailNhanHoaDon)
         .HasMaxLength(64)
         .HasColumnType("varchar");

        builder.Property(cn => cn.XuatHoaDonTuCongTy)
         .HasMaxLength(128)
         .HasColumnType("nvarchar");


        builder.Property(cn => cn.EmailHoaDon)
        .HasMaxLength(64)
        .HasColumnType("varchar");

        builder.Property(cn => cn.SoHoaDonThucTe)
         .HasMaxLength(30)
         .HasColumnType("varchar");


        builder.Property(cn => cn.GhiChuHoaDon)
           .HasMaxLength(128)
           .HasColumnType("nvarchar");


        builder.Property(cn => cn.NguoiGhiSo)
          .HasMaxLength(30)
          .HasColumnType("varchar");



        builder.Property(cn => cn.SoPoKhach)
         .HasMaxLength(30)
         .HasColumnType("varchar");



        builder.Property(cn => cn.FileDinhKem)
        .HasMaxLength(64)
        .HasColumnType("varchar");


        builder.Property(cn => cn.GhiChuChoGiaoNhan)
           .HasMaxLength(512)
           .HasColumnType("nvarchar");

        builder.Property(cn => cn.HinhThucGiaoHang)
         .HasMaxLength(30)
         .HasColumnType("nvarchar");


        builder.Property(cn => cn.ThongTinNhaXe)
         .HasMaxLength(64)
         .HasColumnType("nvarchar");


        builder.Property(cn => cn.SoBill)
         .HasMaxLength(50)
         .HasColumnType("nvarchar");


        builder.Property(cn => cn.TemXuatTheo)
           .HasMaxLength(50)
           .HasColumnType("varchar");


        builder.Property(cn => cn.SoKien)
           .HasMaxLength(50)
           .HasColumnType("varchar");


        builder.Property(cn => cn.ViTriDeHang)
          .HasMaxLength(50)
          .HasColumnType("nvarchar");


        builder.Property(cn => cn.MaVach)
            .HasMaxLength(50)
            .HasColumnType("varchar");


        builder.Property(cn => cn.BenChiuPhi)
          .HasMaxLength(50)
          .HasColumnType("varchar");


        builder.Property(cn => cn.KhoXuLy)
         .HasMaxLength(50)
         .HasColumnType("varchar");

        builder.Property(cn => cn.SR2)
         .HasMaxLength(30)
         .HasColumnType("varchar");


        builder.Property(cn => cn.NguoiXacNhan)
         .HasMaxLength(30)
         .HasColumnType("varchar");

        builder.Property(cn => cn.GhiChuPxkHaiQuan)
       .HasMaxLength(512)
       .HasColumnType("nvarchar");


        builder.Property(cn => cn.MaSoPxkHaiQuan)
       .HasMaxLength(30)
       .HasColumnType("varchar");

        builder.Property(cn => cn.MaVoucher)
       .HasMaxLength(30)
       .HasColumnType("varchar");

        builder.Property(cn => cn.TenSanTmdt)
         .HasMaxLength(30)
         .HasColumnType("varchar");


        builder.Property(cn => cn.TenShopTmdt)
         .HasMaxLength(128)
         .HasColumnType("nvarchar");


        builder.Property(cn => cn.MaVanDonViettelPost)
         .HasMaxLength(30)
         .HasColumnType("varchar");

        builder.Property(cn => cn.NguonGocDonHang)
           .HasMaxLength(50)
           .HasColumnType("nvarchar");



        builder.Property(e => e.LoaiXuatKho)
         .HasConversion(
             v => v.Value,
             v => LoaiXuatKho.FromValue(v))
         .IsRequired()
         .HasMaxLength(64)
         .HasColumnType("nvarchar");

        builder.Property(e => e.InTheoMau)
          .HasConversion(
              v => v.Value,
              v => InTheoMauMacDinh.FromValue(v))
          .IsRequired()
          .HasMaxLength(30)
          .HasColumnType("varchar");

    }
}
