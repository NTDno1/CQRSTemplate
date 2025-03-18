using ERP.Domain.Entities.Sales.DeNghi.DeNghiThanhToanCM;
using ERP.Share.Extensions;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ERP.Persistence.Configurations.SALE.DeNghi;

internal sealed class DeNghiThanhToanCMChiTietConfiguration : IEntityTypeConfiguration<DeNghiThanhToanCMChiTiet>
{
    public void Configure(EntityTypeBuilder<DeNghiThanhToanCMChiTiet> builder)
    {
        builder.ToTable("SALE_DeNghiThanhToanCMChiTiet");

        builder.HasKey(ct => ct.Id);

        builder
            .Property(e => e.Id)
            .HasConversion(EfCoreConverters.UlidToGuidConverter).HasColumnType("char(26)");


        builder
            .Property(e => e.IdDeNghi)
            .HasConversion(EfCoreConverters.UlidToGuidConverter).HasColumnType("char(26)");


        builder
           .Property(e => e.IdXuatKho)
           .HasConversion(EfCoreConverters.UlidToGuidConverter).HasColumnType("char(26)");



        builder.Property(ct => ct.GhiChu)
            .IsRequired()
            .HasMaxLength(128)
            .HasColumnType("nvarchar");

        builder.HasOne(ct => ct.DeNghiThanhToanCM)
           .WithMany(bg => bg.DeNghiThanhToanCMChiTiets)
           .HasForeignKey(ct => ct.IdDeNghi);

    }
}
