using ERP.Domain.Entities.System.ChiNhanh;
using ERP.Share.Extensions;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ERP.Persistence.Configurations.System;

internal sealed class ChiNhanhConfiguration : IEntityTypeConfiguration<ChiNhanh>
{
    public void Configure(EntityTypeBuilder<ChiNhanh> builder)
    {
        builder.ToTable("Sys_ChiNhanh");

        builder.HasKey(cn => cn.Id);

        builder
            .Property(e => e.Id)
            .HasConversion(EfCoreConverters.UlidToGuidConverter).HasColumnType("char(26)");

        builder.Property(cn => cn.MaChiNhanh)
            .HasMaxLength(30)
            .HasColumnType("varchar");


        builder.Property(cn => cn.TenChiNhanh)
            .IsRequired()
            .HasMaxLength(128)
            .HasColumnType("nvarchar");
    }
}
