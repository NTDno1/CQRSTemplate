using ERP.Share.Extensions;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ERP.Persistence.Configurations.SALE.BaoGia;

internal sealed class BaoGiaCommentConfiguration : IEntityTypeConfiguration<Domain.Entities.Sales.BaoGias.BaoGiaComment>
{
    public void Configure(EntityTypeBuilder<Domain.Entities.Sales.BaoGias.BaoGiaComment> builder)
    {
        builder.ToTable("SALE_BaoGiaComment");

        builder.HasKey(cm => cm.Id);

        builder
            .Property(e => e.Id)
            .HasConversion(EfCoreConverters.UlidToGuidConverter).HasColumnType("char(26)");



        builder
            .Property(e => e.IdBaoGia)
            .HasConversion(EfCoreConverters.UlidToGuidConverter).HasColumnType("char(26)");




        builder.Property(cm => cm.NoiDungComment)
            .IsRequired()
            .HasMaxLength(255)
            .HasColumnType("nvarchar");

        builder.HasOne(cm => cm.BaoGia)
            .WithMany(bg => bg.BaoGiaComments)
            .HasForeignKey(cm => cm.IdBaoGia);

    }
}
