using ERP.Domain.Entities.System.IPWan;
using ERP.Share.Extensions;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ERP.Persistence.Configurations.System;

internal sealed class IPWanConfiguration : IEntityTypeConfiguration<IPWan>
{
    public void Configure(EntityTypeBuilder<IPWan> builder)
    {
        builder.ToTable("Sys_IPWan");

        builder.HasKey(ip => ip.Id);

        builder
            .Property(e => e.Id)
            .HasConversion(EfCoreConverters.UlidToGuidConverter).HasColumnType("char(26)");


        builder.Property(ip => ip.Ip)
            .HasMaxLength(20)
            .HasColumnType("varchar");

        builder.Property(ip => ip.MaVanPhong)
            .HasMaxLength(30)
            .HasColumnType("varchar");

        builder.Property(ip => ip.GhiChu)
            .HasMaxLength(128)
            .HasColumnType("nvarchar");

    }
}
