using ERP.Domain.Entities.WareHouses.init;
using ERP.Share.Extensions;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ERP.Persistence.Configurations.WareHouses;
public sealed class DanhSachKhoConfiguration : IEntityTypeConfiguration<DanhSachKho>
{
    public void Configure(EntityTypeBuilder<DanhSachKho> builder)
    {
        builder.ToTable("WH_DanhSachKho");

        builder.HasKey(cn => cn.Id);

        builder
            .Property(e => e.Id)
            .HasConversion(EfCoreConverters.UlidToGuidConverter).HasColumnType("char(26)");




        builder.Property(cn => cn.TenKho)
           .HasMaxLength(128)
           .HasColumnType("nvarchar");

        builder.Property(cn => cn.GhiChu)
         .HasMaxLength(255)
         .HasColumnType("nvarchar");


        builder.Property(cn => cn.TrucThuocKho)
         .HasMaxLength(30)
            .HasColumnType("varchar");


        builder.Property(cn => cn.QrId)
        .HasMaxLength(64)
        .HasColumnType("varchar");

        builder.Property(cn => cn.DiaChi)
        .HasMaxLength(128)
        .HasColumnType("nvarchar");

    }
}
