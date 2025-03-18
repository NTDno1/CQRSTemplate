using ERP.Domain.Entities.HR.CongTacPhiPhuongTien;
using ERP.Share.Extensions;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ERP.Persistence.Configurations.HR;

internal sealed class CongTacPhiPhuongTienConfiguration : IEntityTypeConfiguration<CongTacPhiPhuongTien>
{
    public void Configure(EntityTypeBuilder<CongTacPhiPhuongTien> builder)
    {
        builder.ToTable("HR_CongTacPhiPhuongTien");

        builder.HasKey(cn => cn.Id);
        builder
            .Property(e => e.Id)
            .HasConversion(EfCoreConverters.UlidToGuidConverter).HasColumnType("char(26)");


        builder
            .Property(e => e.IdDeNghiCongTacPhi)
            .HasConversion(EfCoreConverters.UlidToGuidConverter).HasColumnType("char(26)");


        builder.Property(ctp => ctp.PhuongTien)
         .HasConversion(
             v => v.Value,
             v => PhuongTien.FromValue(v))
         .IsRequired()
         .HasMaxLength(50)
         .HasColumnType("nvarchar");

        builder.Property(cn => cn.GhiChuPhuongTien)
            .HasMaxLength(128)
            .HasColumnType("nvarchar");

    }
}
