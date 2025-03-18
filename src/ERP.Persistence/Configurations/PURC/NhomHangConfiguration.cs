using ERP.Domain.Entities.PURC;
using ERP.Share.Extensions;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ERP.Persistence.Configurations.PURC;

internal sealed class NhomHangConfiguration : IEntityTypeConfiguration<NhomHang>
{
    public void Configure(EntityTypeBuilder<NhomHang> builder)
    {
        builder.ToTable("PURC_NhomHang");

        builder.HasKey(nh => nh.Id);

        builder
            .Property(e => e.Id)
            .HasConversion(EfCoreConverters.UlidToGuidConverter).HasColumnType("char(26)");


        builder
            .Property(e => e.IdNhomHangCha)
            .HasConversion(EfCoreConverters.UlidToGuidConverter).HasColumnType("char(26)");

        builder.Property(cn => cn.MaNhomHang)
            .HasMaxLength(30)
            .HasColumnType("varchar");

        builder.Property(nh => nh.PhanLoaiNhom)
         .HasConversion(
             v => v.Value,
             v => PhanLoaiNhom.FromValue(v))
         .IsRequired()
         .HasMaxLength(50)
         .HasColumnType("nvarchar");


        builder.Property(nh => nh.GhiChu)
            .HasMaxLength(128)
            .HasColumnType("nvarchar");

        builder.Property(nh => nh.Leader)
           .HasMaxLength(30)
           .HasColumnType("varchar");
        builder.Property(nh => nh.MuaHangPhuTrach)
           .HasMaxLength(30)
           .HasColumnType("varchar");
        builder.Property(nh => nh.MuaHangPhuTrachNuocNgoai)
           .HasMaxLength(30)
           .HasColumnType("varchar");
        builder.Property(nh => nh.Sub)
           .HasMaxLength(30)
        .HasColumnType("varchar");

        builder
            .HasOne(nh => nh.NhomHangCha)
            .WithMany()
            .HasForeignKey(nh => nh.IdNhomHangCha);

        builder
            .HasMany(nh => nh.HangHoas)
            .WithOne(x => x.NhomHang)
            .HasForeignKey(nh => nh.IdNhomHang);

    }
}
