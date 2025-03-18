using ERP.Domain.Entities.Sales.KhachHang;
using ERP.Share.Extensions;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ERP.Persistence.Configurations.SALE.KhachHang;

internal sealed class KhachHangNganhNgheConfiguration : IEntityTypeConfiguration<KhachHangNganhNghe>
{
    public void Configure(EntityTypeBuilder<KhachHangNganhNghe> builder)
    {
        builder.ToTable("SALE_KH_NganhNghe");

        builder.HasKey(x => x.Id);

        builder
            .Property(e => e.Id)
            .HasConversion(EfCoreConverters.UlidToGuidConverter).HasColumnType("char(26)");



        builder.Property(x => x.NganhNghe)
            .IsRequired()
            .HasMaxLength(128)
            .HasColumnType("nvarchar");

        builder
           .Property(e => e.IdLoaiKhach)
           .HasConversion(EfCoreConverters.UlidToGuidConverter).HasColumnType("char(26)");

    }
}
