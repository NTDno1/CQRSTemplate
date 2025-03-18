using ERP.Domain.Entities.System.VanPhong;
using ERP.Share.Extensions;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ERP.Persistence.Configurations.System;


internal sealed class VanPhongConfiguration : IEntityTypeConfiguration<VanPhong>
{
    public void Configure(EntityTypeBuilder<VanPhong> builder)
    {
        builder.ToTable("Sys_VanPhong");

        builder.HasKey(vp => vp.Id);

        builder
            .Property(e => e.Id)
            .HasConversion(EfCoreConverters.UlidToGuidConverter).HasColumnType("char(26)");

        builder.Property(cn => cn.MaVanPhong)
            .HasMaxLength(30)
            .HasColumnType("varchar");

        builder.Property(vp => vp.TenVanPhong)
            .IsRequired()
            .HasMaxLength(128)
            .HasColumnType("nvarchar");
    }
}
