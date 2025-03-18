using ERP.Domain.Entities.Users;
using ERP.Share.Extensions;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ERP.Persistence.Configurations.System;
internal sealed class PhongBanConfiguration : IEntityTypeConfiguration<PhongBan>
{
    public void Configure(EntityTypeBuilder<PhongBan> builder)
    {
        builder.ToTable("Sys_PhongBan");

        builder.HasKey(pb => pb.Id);

        builder
            .Property(e => e.Id)
            .HasConversion(EfCoreConverters.UlidToGuidConverter).HasColumnType("char(26)");

        builder.Property(cn => cn.MaPhongBan)
            .HasMaxLength(30)
            .HasColumnType("varchar");

        builder.Property(pb => pb.TenPhongBan)
            .IsRequired()
            .HasMaxLength(64)
            .HasColumnType("nvarchar");

        builder.Property(pb => pb.TrucThuocPhongBan)
            .IsRequired()
            .HasMaxLength(30)
            .HasColumnType("varchar");

        builder.Property(pb => pb.TruongPhong)
            .IsRequired()
            .HasMaxLength(20)
            .HasColumnType("varchar");

        builder.Property(pb => pb.PhoPhong)
            .IsRequired()
            .HasMaxLength(20)
            .HasColumnType("varchar");


        builder
            .HasMany(p => p.Users)
            .WithOne(u => u.PhongBan)
            .HasForeignKey(u => u.IdPhongBan);
    }
}
