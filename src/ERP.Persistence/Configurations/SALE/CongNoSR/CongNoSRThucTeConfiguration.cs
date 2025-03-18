using ERP.Domain.Entities.Sales.CongNoSR;
using ERP.Share.Extensions;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ERP.Persistence.Configurations.SALE.CongNoSR;

internal sealed class CongNoSRThucTeConfiguration : IEntityTypeConfiguration<CongNoSRThucTe>
{
    public void Configure(EntityTypeBuilder<CongNoSRThucTe> builder)
    {
        builder.ToTable("SALE_CongNoSRThucTe");

        builder.HasKey(cn => cn.Id);

        builder
            .Property(e => e.Id)
            .HasConversion(EfCoreConverters.UlidToGuidConverter).HasColumnType("char(26)");


        builder
           .Property(e => e.IdKhachHang)
           .HasConversion(EfCoreConverters.UlidToGuidConverter).HasColumnType("char(26)");


        //builder.Property(cn => cn.IdKhachHang)
        //    .HasMaxLength(30)
        //    .HasColumnType("varchar");

        builder.Property(cn => cn.KetQuaThuHoi)
            .HasMaxLength(128)
            .HasColumnType("nvarchar");
        builder.Property(cn => cn.KetQuaThuHoiQuaHan)
           .HasMaxLength(128)
           .HasColumnType("nvarchar");

        builder.Property(cn => cn.KetQuaThuHoiDenHan)
           .HasMaxLength(128)
           .HasColumnType("nvarchar");

        builder.Property(cn => cn.KetQuaThuHoiNgoaiDuKien)
           .HasMaxLength(128)
           .HasColumnType("nvarchar");

        builder.OwnsOne(cn => cn.KhoangThoiGian, tg =>
        {
            tg.Property(tg => tg.TuNgay).HasColumnName("TuNgay");
            tg.Property(tg => tg.DenNgay).HasColumnName("DenNgay");
        });

    }
}
