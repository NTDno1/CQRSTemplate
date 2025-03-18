using ERP.Share.Extensions;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ERP.Persistence.Configurations.SALE.CongNoSR;

internal sealed class CongNoSRConfiguration : IEntityTypeConfiguration<Domain.Entities.Sales.CongNoSR.CongNoSR>
{
    public void Configure(EntityTypeBuilder<Domain.Entities.Sales.CongNoSR.CongNoSR> builder)
    {
        builder.ToTable("SALE_CongNoSR");

        builder.HasKey(cn => cn.Id);

        builder
            .Property(e => e.Id)
            .HasConversion(EfCoreConverters.UlidToGuidConverter).HasColumnType("char(26)");


        builder
            .Property(e => e.IdKhachHang)
            .HasConversion(EfCoreConverters.UlidToGuidConverter).HasColumnType("char(26)");




        builder.Property(cn => cn.LoaiNV)
            .HasMaxLength(30)
            .HasColumnType("varchar");

        builder.Property(cn => cn.KetQuaThuHoi)
            .HasMaxLength(255)
            .HasColumnType("nvarchar");

        builder.OwnsOne(cn => cn.KhoangThoiGian, tg =>
        {
            tg.Property(tg => tg.TuNgay).HasColumnName("TuNgay");
            tg.Property(tg => tg.DenNgay).HasColumnName("DenNgay");
        });
    }
}

