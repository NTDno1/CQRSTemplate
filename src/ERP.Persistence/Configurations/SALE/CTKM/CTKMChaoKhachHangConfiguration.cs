using ERP.Domain.Entities.Sales.CTKM;
using ERP.Share.Extensions;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ERP.Persistence.Configurations.SALE.CTKM;

internal sealed class CTKMChaoKhachHangConfiguration : IEntityTypeConfiguration<CTKMChaoKhachHang>
{
    public void Configure(EntityTypeBuilder<CTKMChaoKhachHang> builder)
    {
        builder.ToTable("SALE_CTKMChaoKhachHang");

        builder.HasKey(ctkm => ctkm.Id);

        builder
            .Property(e => e.Id)
            .HasConversion(EfCoreConverters.UlidToGuidConverter).HasColumnType("char(26)");


        builder
            .Property(e => e.IdCTKM)
            .HasConversion(EfCoreConverters.UlidToGuidConverter).HasColumnType("char(26)");


        builder
            .Property(e => e.IdKhachHang)
            .HasConversion(EfCoreConverters.UlidToGuidConverter).HasColumnType("char(26)");



        builder.Property(ctkm => ctkm.SaleThemKhach)
            .HasMaxLength(30)
            .HasColumnType("varchar");

        builder.HasOne(ctkm => ctkm.CTKM)
             .WithMany(x => x.CTKMChaoKhachHangs)
             .HasForeignKey(ctkm => ctkm.IdCTKM);

    }
}
