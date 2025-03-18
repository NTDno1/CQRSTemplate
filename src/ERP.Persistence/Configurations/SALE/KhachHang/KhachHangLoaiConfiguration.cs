using ERP.Domain.Entities.Sales.KhachHang;
using ERP.Share.Extensions;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ERP.Persistence.Configurations.SALE.KhachHang;

internal sealed class KhachHangLoaiConfiguration : IEntityTypeConfiguration<KhachHangLoai>
{
    public void Configure(EntityTypeBuilder<KhachHangLoai> builder)
    {
        builder.ToTable("SALE_KH_Loai");

        builder.HasKey(x => x.Id);

        builder
            .Property(e => e.Id)
            .HasConversion(EfCoreConverters.UlidToGuidConverter).HasColumnType("char(26)");


        builder
            .Property(e => e.IdLoaiKhachCha)
            .HasConversion(EfCoreConverters.UlidToGuidConverter).HasColumnType("char(26)");


        builder.Property(x => x.TenLoaiKhach)
            .IsRequired()
            .HasMaxLength(128)
            .HasColumnType("nvarchar");

        builder.Property(x => x.NganhHangApDung)
           .IsRequired()
           .HasMaxLength(30)
           .HasColumnType("varchar");

    }
}
