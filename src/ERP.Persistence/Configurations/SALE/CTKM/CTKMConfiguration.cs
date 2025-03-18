using ERP.Share.Extensions;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ERP.Persistence.Configurations.SALE.CTKM;


internal sealed class CTKMConfiguration : IEntityTypeConfiguration<Domain.Entities.Sales.CTKM.CTKM>
{
    public void Configure(EntityTypeBuilder<Domain.Entities.Sales.CTKM.CTKM> builder)
    {
        builder.ToTable("SALE_CTKM");

        builder.HasKey(ctkm => ctkm.Id);

        builder
            .Property(e => e.Id)
            .HasConversion(EfCoreConverters.UlidToGuidConverter).HasColumnType("char(26)");



        builder.Property(ctkm => ctkm.TenCTKM)
            .HasMaxLength(128)
            .HasColumnType("nvarchar");

        builder.OwnsOne(ctkm => ctkm.KhoangThoiGian, tg =>
        {
            tg.Property(tg => tg.TuNgay).HasColumnName("TuNgay");
            tg.Property(tg => tg.DenNgay).HasColumnName("DenNgay");
        });

        builder.Property(ctkm => ctkm.CodeCTKM)
           .HasMaxLength(30)
           .HasColumnType("varchar");

        builder.Property(ctkm => ctkm.Detail)
            .HasMaxLength(128)
            .HasColumnType("nvarchar");

        builder.Property(ctkm => ctkm.PhanLoai)
            .HasMaxLength(128)
            .HasColumnType("nvarchar");

        builder.Property(ctkm => ctkm.NoiDungTruyenThong)
            .HasMaxLength(255)
            .HasColumnType("nvarchar");

    }
}
