using ERP.Domain.Entities.WareHouses.ChuyenKho;
using ERP.Share.Extensions;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ERP.Persistence.Configurations.WareHouses;

internal sealed class ChuyenKhoConfiguration : IEntityTypeConfiguration<ChuyenKho>
{
    public void Configure(EntityTypeBuilder<ChuyenKho> builder)
    {
        builder.ToTable("Wh_ChuyenKho");
        builder.HasKey(x => x.Id);

        builder
            .Property(e => e.Id)
            .HasConversion(EfCoreConverters.UlidToGuidConverter).HasColumnType("char(26)");

        builder.Property(cn => cn.MaChuyenKho)
            .HasMaxLength(30)
            .HasColumnType("varchar");


        builder.Property(whChuyenKho => whChuyenKho.DienGiai)
            .HasMaxLength(512)
            .HasColumnType("nvarchar");

        builder.Property(whChuyenKho => whChuyenKho.TrucThuoc)
            .IsRequired()
            .HasMaxLength(15)
            .HasColumnType("varchar");

        builder.Property(whChuyenKho => whChuyenKho.HinhThucChuyen)
            .HasMaxLength(30)
            .HasColumnType("nvarchar");

        builder.Property(whChuyenKho => whChuyenKho.SoBill)
            .HasMaxLength(50)
            .HasColumnType("nvarchar");

        builder.Property(whChuyenKho => whChuyenKho.TrangThai)
            .HasMaxLength(64)
            .HasColumnType("nvarchar");

        builder.Property(whChuyenKho => whChuyenKho.NguoiXacNhanXuat)
            .HasMaxLength(30)
            .HasColumnType("varchar");

        builder.Property(whChuyenKho => whChuyenKho.NguoiNhanHang)
            .HasMaxLength(30)
            .HasColumnType("varchar");

        builder.Property(whChuyenKho => whChuyenKho.SoHoaDon)
            .HasMaxLength(50)
        .HasColumnType("varchar");

        builder
            .Property(e => e.IdKhoNhanHang)
            .HasConversion(EfCoreConverters.UlidToGuidConverter).HasColumnType("char(26)");


        builder
            .Property(e => e.IdKhoXuatHang)
            .HasConversion(EfCoreConverters.UlidToGuidConverter).HasColumnType("char(26)");

    }
}
