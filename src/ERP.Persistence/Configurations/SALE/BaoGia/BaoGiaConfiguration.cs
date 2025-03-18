using ERP.Domain.Entities.Sales.BaoGias.BaoGia;
using ERP.Share.Extensions;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ERP.Persistence.Configurations.SALE.BaoGia;

internal sealed class BaoGiaConfiguration : IEntityTypeConfiguration<ERP.Domain.Entities.Sales.BaoGias.BaoGia.BaoGia>
{
    public void Configure(EntityTypeBuilder<ERP.Domain.Entities.Sales.BaoGias.BaoGia.BaoGia> builder)
    {
        builder.ToTable("SALE_BaoGia");

        builder.HasKey(bg => bg.Id);
        builder
            .Property(e => e.Id)
            .HasConversion(EfCoreConverters.UlidToGuidConverter).HasColumnType("char(26)");


        builder
            .Property(e => e.IdKhachHang)
            .HasConversion(EfCoreConverters.UlidToGuidConverter).HasColumnType("char(26)");


        builder
            .Property(e => e.IdCTKM)
            .HasConversion(EfCoreConverters.UlidToGuidConverter).HasColumnType("char(26)");


        builder
            .Property(e => e.IdDieuKhoanThanhToan)
            .HasConversion(EfCoreConverters.UlidToGuidConverter).HasColumnType("char(26)");


        builder
           .Property(e => e.IdDieuKhoanThanhToanKhachHang)
           .HasConversion(EfCoreConverters.UlidToGuidConverter).HasColumnType("char(26)");


        builder
           .Property(e => e.IdLienHe)
           .HasConversion(EfCoreConverters.UlidToGuidConverter).HasColumnType("char(26)");

        builder.Property(cn => cn.SoBaoGia)
            .HasMaxLength(30)
            .HasColumnType("varchar");

        builder.OwnsOne(bg => bg.ThanhTien0, tt0 =>
        {
            tt0.Property(tt0 => tt0.ThanhTienHang).HasColumnName("ThanhTienHang0");
            tt0.Property(tt0 => tt0.TienThueGTGT).HasColumnName("TienThueGTGT0");
        });

        builder.OwnsOne(bg => bg.ThanhTien8, tt8 =>
        {
            tt8.Property(tt8 => tt8.ThanhTienHang).HasColumnName("ThanhTienHang8");
            tt8.Property(tt8 => tt8.TienThueGTGT).HasColumnName("TienThueGTGT8");
        });

        builder.OwnsOne(bg => bg.ThanhTien10, tt10 =>
        {
            tt10.Property(tt10 => tt10.ThanhTienHang).HasColumnName("ThanhTienHang10");
            tt10.Property(tt10 => tt10.TienThueGTGT).HasColumnName("TienThueGTGT10");
        });

        builder.Property(bg => bg.LoaiDon)
         .HasConversion(
             v => v.Value,
             v => LoaiDon.FromValue(v))
         .IsRequired()
         .HasMaxLength(50)
         .HasColumnType("nvarchar");

        builder.Property(bg => bg.TrangThaiDon)
         .HasConversion(
             v => v.Value,
             v => TrangThaiDon.FromValue(v))
         .IsRequired()
         .HasMaxLength(50)
         .HasColumnType("nvarchar");

        builder.Property(bg => bg.LyDoTruot)
            .HasMaxLength(128)
            .HasColumnType("nvarchar");

        builder.Property(bg => bg.TrangThaiDuyet)
         .HasConversion(
             v => v.Value,
             v => TrangThaiDuyet.FromValue(v))
         .IsRequired()
         .HasMaxLength(50)
         .HasColumnType("nvarchar");

        builder.Property(bg => bg.LyDoHuyDuyet)
            .HasMaxLength(128)
            .HasColumnType("nvarchar");

        builder.Property(bg => bg.KhaNangTrung)
         .HasConversion(
             v => v.Value,
             v => KhaNangTrung.FromValue(v))
         .IsRequired()
         .HasMaxLength(50)
         .HasColumnType("nvarchar");

        builder.Property(bg => bg.SR)
            .HasMaxLength(30)
            .HasColumnType("varchar");

        builder.Property(bg => bg.SR2)
           .HasMaxLength(30)
           .HasColumnType("varchar");

        builder.Property(bg => bg.SA)
           .HasMaxLength(30)
           .HasColumnType("varchar");

        builder.Property(bg => bg.ChiNhanh)
           .HasMaxLength(30)
           .HasColumnType("varchar");

        builder.Property(bg => bg.KhoXuLy)
           .HasMaxLength(30)
           .HasColumnType("varchar");

        builder.Property(bg => bg.DiaChiGiaoHang)
           .HasMaxLength(128)
           .HasColumnType("nvarchar");

        builder.Property(bg => bg.NguoiNhanHang)
           .HasMaxLength(128)
           .HasColumnType("nvarchar");

        builder.OwnsOne(bg => bg.DuyetCMDuoi20, cm =>
        {
            cm.Property(cm => cm.CanDuyetCMDuoi20).HasColumnName("CanDuyetCMDuoi20");
            cm.Property(cm => cm.NguoiDuyetCMDuoi20).HasMaxLength(30).HasColumnType("varchar").HasColumnName("NguoiDuyetCMDuoi20");
            cm.Property(cm => cm.NgayDuyetCMDuoi20).HasColumnName("NgayDuyetCMDuoi20");
            cm.Property(cm => cm.GhiChuDuyetCMDuoi20).HasMaxLength(128).HasColumnType("nvarchar").HasColumnName("GhiChuDuyetCMDuoi20");
        });

        builder.Property(bg => bg.IASHoTro1)
           .HasMaxLength(30)
           .HasColumnType("varchar");

        builder.Property(bg => bg.IASHoTro2)
           .HasMaxLength(30)
           .HasColumnType("varchar");
    }
}
