using ERP.Domain.Entities.Sales.KhachHang.HopDong;
using ERP.Share.Extensions;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ERP.Persistence.Configurations.SALE.KhachHang;

internal sealed class HopDongConfiguration : IEntityTypeConfiguration<HopDong>
{
    public void Configure(EntityTypeBuilder<HopDong> builder)
    {
        builder.ToTable("SALE_KH_HopDong");

        builder.HasKey(x => x.Id);

        builder
            .Property(e => e.Id)
            .HasConversion(EfCoreConverters.UlidToGuidConverter).HasColumnType("char(26)");


        builder
            .Property(e => e.IdKhachHang)
            .HasConversion(EfCoreConverters.UlidToGuidConverter).HasColumnType("char(26)");



        builder.Property(ctp => ctp.LoaiHopDong)
             .HasConversion(
                 v => v.Value,
                 v => LoaiHopDong.FromValue(v))
             .IsRequired()
             .HasMaxLength(50)
             .HasColumnType("nvarchar");

        builder.Property(x => x.GhiChu)
           .HasMaxLength(128)
           .HasColumnType("nvarchar");

        builder.Property(x => x.SoHopDong)
           .HasMaxLength(128)
           .HasColumnType("nvarchar");

        builder.Property(x => x.SoQuyen)
           .HasMaxLength(128)
           .HasColumnType("nvarchar");

        builder.Property(x => x.DieuKhoanThanhToan)
           .HasMaxLength(128)
           .HasColumnType("nvarchar");

        builder.Property(ctp => ctp.TrangThai)
             .HasConversion(
                 v => v.Value,
                 v => TrangThai.FromValue(v))
             .IsRequired()
             .HasMaxLength(50)
             .HasColumnType("nvarchar");

    }
}
