using ERP.Domain.Entities.Sales.DeNghi.DeNghiTraLai;
using ERP.Share.Extensions;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ERP.Persistence.Configurations.SALE.DeNghi;

internal sealed class DeNghiTraLaiChiTietConfiguration : IEntityTypeConfiguration<DeNghiTraLaiChiTiet>
{
    public void Configure(EntityTypeBuilder<DeNghiTraLaiChiTiet> builder)
    {
        builder.ToTable("SALE_DeNghiTraLaiChiTiet");

        builder.HasKey(ct => ct.Id);

        builder
            .Property(e => e.Id)
            .HasConversion(EfCoreConverters.UlidToGuidConverter).HasColumnType("char(26)");


        builder
            .Property(e => e.IdDeNghiTraLai)
            .HasConversion(EfCoreConverters.UlidToGuidConverter).HasColumnType("char(26)");


        builder
            .Property(e => e.IdHangHoa)
            .HasConversion(EfCoreConverters.UlidToGuidConverter).HasColumnType("char(26)");


        builder
            .Property(e => e.IdChiTietXuatKho)
            .HasConversion(EfCoreConverters.UlidToGuidConverter).HasColumnType("char(26)");


        builder.Property(ct => ct.MaDieuChinh)
           .HasMaxLength(128)
           .HasColumnType("nvarchar");

        builder.Property(ct => ct.GhiChu)
           .HasMaxLength(128)
           .HasColumnType("nvarchar");

        builder.HasOne(ct => ct.DeNghiTraLai)
            .WithMany(dn => dn.DeNghiTraLaiChiTiets)
            .HasForeignKey(ct => ct.IdDeNghiTraLai);

    }
}
