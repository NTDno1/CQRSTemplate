using ERP.Domain.Entities.Sales.KhachHang.PhanHoiKhachHang;
using ERP.Share.Extensions;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ERP.Persistence.Configurations.SALE.KhachHang;

internal sealed class PhanHoiKhachHangConfiguration : IEntityTypeConfiguration<PhanHoiKhachHang>
{
    public void Configure(EntityTypeBuilder<PhanHoiKhachHang> builder)
    {
        builder.ToTable("SALE_KH_PhanHoiKhachHang");

        builder.HasKey(cn => cn.Id);

        builder
            .Property(e => e.Id)
            .HasConversion(EfCoreConverters.UlidToGuidConverter).HasColumnType("char(26)");


        builder.Property(cn => cn.IdUserPhanHoi)
            .HasMaxLength(30)
            .HasColumnType("varchar");

        builder.HasOne(x => x.KhachHang)
           .WithMany(k => k.PhanHoiKhachHangs)
           .HasForeignKey(x => x.IdKhachHang);

        builder.Property(cn => cn.NoiDungPhanHoi)
           .HasMaxLength(255)
           .HasColumnType("nvarchar");

        builder.Property(x => x.LoaiPhanHoi)
             .HasConversion(
                 v => v.Value,
                 v => LoaiPhanHoi.FromValue(v))
             .IsRequired()
             .HasMaxLength(50)
             .HasColumnType("nvarchar");
    }
}
