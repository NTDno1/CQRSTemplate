using ERP.Domain.Entities.Sales.DuyetXuatTruocHan;
using ERP.Domain.Entities.Shared;
using ERP.Share.Extensions;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ERP.Persistence.Configurations.SALE;


internal sealed class DuyetXuatTruocHanCongifuration : IEntityTypeConfiguration<DuyetXuatTruocHan>
{
    public void Configure(EntityTypeBuilder<DuyetXuatTruocHan> builder)
    {
        builder.ToTable("SALE_DuyetXuatTruocHan");

        builder.HasKey(cn => cn.Id);
        builder
            .Property(e => e.Id)
            .HasConversion(EfCoreConverters.UlidToGuidConverter).HasColumnType("char(26)");

        builder.Property(cn => cn.NguoiDeNghi)
            .HasMaxLength(30)
            .HasColumnType("varchar");

        builder
            .Property(e => e.IdXuatKho)
            .HasConversion(EfCoreConverters.UlidToGuidConverter).HasColumnType("char(26)");

        builder.Property(cn => cn.LyDo)
            .IsRequired()
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
             .HasMaxLength(50)
             .HasColumnName("TrangThaiDuyet")
             .HasColumnType("nvarchar");
        });

    }
}
