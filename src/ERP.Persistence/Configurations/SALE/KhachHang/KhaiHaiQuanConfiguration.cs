using ERP.Domain.Entities.Sales.KhachHang;
using ERP.Share.Extensions;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ERP.Persistence.Configurations.SALE.KhachHang;

internal sealed class KhaiHaiQuanConfiguration : IEntityTypeConfiguration<KhaiHaiQuan>
{
    public void Configure(EntityTypeBuilder<KhaiHaiQuan> builder)
    {
        builder.ToTable("SALE_KH_KhaiHaiQuan");

        builder.HasKey(cn => cn.Id);

        builder
         .Property(e => e.Id)
         .HasConversion(EfCoreConverters.UlidToGuidConverter).HasColumnType("char(26)");



        builder.Property(cn => cn.ChiCucHaiQuan)
            .HasMaxLength(128)
            .HasColumnType("nvarchar");

        builder.Property(cn => cn.MaDiaDiemLuuKhoHangChoThongQuanDuKien)
            .HasMaxLength(128)
            .HasColumnType("nvarchar");

        builder.Property(cn => cn.DiaDiemDoHang)
            .HasMaxLength(128)
            .HasColumnType("nvarchar");

        builder.Property(cn => cn.DiaDiemDichChoVanChuyenBaoThue)
            .HasMaxLength(128)
            .HasColumnType("nvarchar");

        builder.Property(cn => cn.GhiChuLamHaiQuanMayDau)
            .HasMaxLength(128)
            .HasColumnType("nvarchar");

        builder.Property(cn => cn.GhiChuChungTuNhapKhachHangCanCheck)
            .HasMaxLength(128)
            .HasColumnType("nvarchar");

        builder.Property(cn => cn.ThongTinLienHeKhachHang)
            .HasMaxLength(128)
            .HasColumnType("nvarchar");

        builder.Property(cn => cn.BoChungTuBanCung)
            .HasMaxLength(128)
            .HasColumnType("nvarchar");

        builder.Property(cn => cn.TermOfSale)
            .HasMaxLength(128)
            .HasColumnType("nvarchar");

        builder.Property(cn => cn.TenTiengAnh)
            .HasMaxLength(128)
            .HasColumnType("nvarchar");

        builder
          .Property(e => e.IdKhachHang)
          .HasConversion(EfCoreConverters.UlidToGuidConverter).HasColumnType("char(26)");


        builder.HasOne(x => x.KhachHang)
         .WithMany(k => k.KhaiHaiQuans)
         .HasForeignKey(x => x.IdKhachHang);

    }
}
