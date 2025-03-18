using ERP.Domain.Entities.Sales.DeNghi.DeNghiSuaGia;
using ERP.Domain.Entities.Shared;
using ERP.Share.Extensions;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ERP.Persistence.Configurations.SALE.DeNghi;

internal sealed class DeNghiSuaGiaConfiguration : IEntityTypeConfiguration<DeNghiSuaGia>
{
    public void Configure(EntityTypeBuilder<DeNghiSuaGia> builder)
    {
        builder.ToTable("SALE_DeNghiSuaGia");

        builder.HasKey(dn => dn.Id);

        builder
            .Property(e => e.Id)
            .HasConversion(EfCoreConverters.UlidToGuidConverter).HasColumnType("char(26)");


        builder
            .Property(e => e.IdChiTietXuatKho)
            .HasConversion(EfCoreConverters.UlidToGuidConverter).HasColumnType("char(26)");


        builder.Property(dn => dn.MaChuan)
            .HasMaxLength(128)
            .HasColumnType("nvarchar");

        builder.Property(dn => dn.LyDoSua)
            .HasMaxLength(128)
            .HasColumnType("nvarchar");

        builder.OwnsOne(dn => dn.DuyetDon, dd =>
        {
            dd.Property(dd => dd.IdUser).HasMaxLength(30).HasColumnType("varchar").HasColumnName("NguoiDuyet");
            dd.Property(dd => dd.GhiChuDuyet).HasMaxLength(128).HasColumnType("nvarchar").HasColumnName("GhiChuDuyet");
            dd.Property(dd => dd.Ngay).HasColumnName("NgayDuyet");



            dd.Property(dd => dd.TrangThai)
             .HasConversion(
                 v => v.Value,
                 v => TrangThaiDonDuyet.FromValue(v))
             .IsRequired()
             .HasColumnName("TrangThaiDuyet")
             .HasMaxLength(50)
             .HasColumnType("nvarchar");
        });


    }
}
