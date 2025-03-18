using ERP.Domain.Entities.WareHouses.XuatKho;
using ERP.Share.Extensions;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ERP.Persistence.Configurations.WareHouses;
public class XuatKhoChiTietConfiguration : IEntityTypeConfiguration<XuatKhoChiTiet>
{
    public void Configure(EntityTypeBuilder<XuatKhoChiTiet> builder)
    {
        builder.ToTable("WH_XuatKhoChiTiet");

        builder.HasKey(cn => cn.Id);

        builder
            .Property(e => e.Id)
            .HasConversion(EfCoreConverters.UlidToGuidConverter).HasColumnType("char(26)");


        builder
            .Property(e => e.IdHangHoa)
            .HasConversion(EfCoreConverters.UlidToGuidConverter).HasColumnType("char(26)");



        builder.Property(cn => cn.TenHang)
          .HasMaxLength(255)
          .HasColumnType("nvarchar");

        builder.Property(cn => cn.Dvt)
        .HasMaxLength(30)
        .HasColumnType("nvarchar");

        builder.Property(cn => cn.MaDieuChinh)
            .HasMaxLength(128)
            .HasColumnType("varchar");


        builder.Property(cn => cn.TkCo)
        .HasMaxLength(30)
        .HasColumnType("varchar");


        builder.Property(cn => cn.TkNo)
        .HasMaxLength(30)
        .HasColumnType("varchar");

        builder.Property(cn => cn.TkGiaVon)
      .HasMaxLength(30)
      .HasColumnType("varchar");

        builder.Property(cn => cn.TkKho)
      .HasMaxLength(30)
      .HasColumnType("varchar");

        builder.Property(cn => cn.MaKhoCon)
      .HasMaxLength(30)
      .HasColumnType("varchar");


        builder.Property(cn => cn.TaiKhoanThue)
        .HasMaxLength(30)
        .HasColumnType("varchar");


        builder.Property(cn => cn.GhiChu)
        .HasMaxLength(512)
        .HasColumnType("nvarchar");



        builder.Property(cn => cn.MaNhomHang)
     .HasMaxLength(55)
     .HasColumnType("nvarchar");


        builder.Property(cn => cn.MaKhoBanDau)
     .HasMaxLength(30)
     .HasColumnType("varchar");

        builder.Property(cn => cn.LoSanXuat)
     .HasMaxLength(64)
     .HasColumnType("nvarchar");

        builder.Property(cn => cn.SoPoMaHang)
     .HasMaxLength(30)
     .HasColumnType("nvarchar");

        builder.Property(cn => cn.LyDo)
          .HasMaxLength(512)
          .HasColumnType("nvarchar");

        builder.Property(cn => cn.CachXuLy)
      .HasMaxLength(512)
      .HasColumnType("nvarchar");



        builder.Property(cn => cn.NguoiXuLy)
          .HasMaxLength(30)
          .HasColumnType("varchar");

        builder.Property(cn => cn.GhiChuCongNoCt)
          .HasMaxLength(512)
          .HasColumnType("nvarchar");

        builder.Property(cn => cn.LyDoDuyetXuatHoaDon)
          .HasMaxLength(512)
          .HasColumnType("nvarchar");

        builder.Property(cn => cn.KtDuyetXuatHoaDon)
          .HasMaxLength(30)
          .HasColumnType("varchar");

        builder.Property(cn => cn.PrNoteHoaDonNcc)
        .HasMaxLength(128)
        .HasColumnType("nvarchar");


        builder.Property(cn => cn.ErpNoteHoaDonNcc)
        .HasMaxLength(128)
        .HasColumnType("nvarchar");


        builder.Property(cn => cn.LoaiTinhTrangHH)
        .HasMaxLength(64)
        .HasColumnType("nvarchar");


        builder.Property(cn => cn.KtDuyetXuatHoaDon)
        .HasMaxLength(30)
        .HasColumnType("varchar");




        builder.Property(cn => cn.ItemCode)
      .HasMaxLength(30)
      .HasColumnType("varchar");


        builder.Property(cn => cn.SoPoSamSung)
      .HasMaxLength(30)
      .HasColumnType("varchar");



        builder.Property(cn => cn.LoaiTien)
      .HasMaxLength(30)
      .HasColumnType("nvarchar");



        builder.Property(cn => cn.SoChungTuBaoHanh)
      .HasMaxLength(30)
      .HasColumnType("varchar");


        builder
          .HasOne(o => o.XuatKho)
          .WithMany(c => c.XuatKhoChiTiets)
          .HasForeignKey(o => o.IdXuatKho);

    }

}
