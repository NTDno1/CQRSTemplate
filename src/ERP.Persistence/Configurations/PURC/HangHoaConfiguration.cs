using ERP.Domain.Entities.PURC.HangHoa;
using ERP.Share.Extensions;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ERP.Persistence.Configurations.PURC;

internal sealed class HangHoaConfiguration : IEntityTypeConfiguration<HangHoa>
{
    public void Configure(EntityTypeBuilder<HangHoa> builder)
    {
        builder.ToTable("PURC_HangHoa");

        builder.HasKey(hh => hh.Id);

        builder
            .Property(e => e.Id)
            .HasConversion(EfCoreConverters.UlidToGuidConverter).HasColumnType("char(26)");

        builder.Property(cn => cn.MaHang)
            .HasMaxLength(30)
            .HasColumnType("varchar");

        builder
            .Property(e => e.IdNhomHang)
            .HasConversion(EfCoreConverters.UlidToGuidConverter).HasColumnType("char(26)");

        builder.Property(hh => hh.MaChuan)
            .HasMaxLength(128)
            .HasColumnType("nvarchar");

        builder.Property(hh => hh.HsCode)
            .HasMaxLength(128)
            .HasColumnType("varchar");

        builder.Property(hh => hh.ThongSoKyThuat)
            .HasMaxLength(128)
            .HasColumnType("nvarchar");

        builder.Property(hh => hh.TenHang)
            .HasMaxLength(128)
            .HasColumnType("nvarchar");


        builder.Property(hh => hh.DonViTinh)
            .HasMaxLength(50)
            .HasColumnType("nvarchar");

        builder.Property(hh => hh.XuatXu)
                .HasMaxLength(128)
                .HasColumnType("nvarchar");

        builder.Property(hh => hh.MaChuyenDoi)
           .HasMaxLength(128)
           .HasColumnType("varchar");

        builder.Property(hh => hh.GhiChu)
           .HasMaxLength(128)
           .HasColumnType("nvarchar");

        builder.Property(hh => hh.LinkSanPham)
           .HasMaxLength(128)
           .HasColumnType("varchar");

        builder.Property(hh => hh.PhuKienDiKem)
           .HasMaxLength(128)
           .HasColumnType("nvarchar");

        builder.Property(hh => hh.TinhTrangHangHoa)
           .HasMaxLength(128)
           .HasColumnType("nvarchar");

        builder.Property(hh => hh.DongSanPham)
           .HasMaxLength(128)
           .HasColumnType("nvarchar");

        builder.Property(hh => hh.MangKinhDoanh)
             .HasConversion(
                 v => v.Value,
                 v => MangKinhDoanh.FromValue(v))
             .IsRequired()
             .HasMaxLength(50)
             .HasColumnType("varchar");

        builder.Property(hh => hh.PhanLoaiHangHoa)
           .HasMaxLength(128)
           .HasColumnType("nvarchar");

        builder.Property(hh => hh.TenHangBaoCao)
           .HasMaxLength(128)
           .HasColumnType("nvarchar");
    }
}
