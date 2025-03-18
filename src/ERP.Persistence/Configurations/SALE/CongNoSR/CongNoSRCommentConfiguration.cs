using ERP.Share.Extensions;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ERP.Persistence.Configurations.SALE.CongNoSR;


internal sealed class CongNoSRCommentConfiguration : IEntityTypeConfiguration<Domain.Entities.Sales.CongNoSR.CongNoSRComment>
{
    public void Configure(EntityTypeBuilder<Domain.Entities.Sales.CongNoSR.CongNoSRComment> builder)
    {
        builder.ToTable("SALE_CongNoSRComment");

        builder.HasKey(cn => cn.Id);

        builder
            .Property(e => e.Id)
            .HasConversion(EfCoreConverters.UlidToGuidConverter).HasColumnType("char(26)");


        builder
            .Property(e => e.IdCongNo)
            .HasConversion(EfCoreConverters.UlidToGuidConverter).HasColumnType("char(26)");




        builder.Property(cn => cn.SaleComment)
           .HasMaxLength(30)
           .HasColumnType("varchar");

        builder.Property(cn => cn.AcctComment)
           .HasMaxLength(30)
           .HasColumnType("varchar");

        builder.Property(cn => cn.NoiDungComment)
            .HasMaxLength(255)
            .HasColumnType("nvarchar");

        builder.HasOne(x => x.CongNoSR)
            .WithMany(cn => cn.CongNoSRComments)
            .HasForeignKey(x => x.IdCongNo);
    }
}
