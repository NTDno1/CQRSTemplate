using ERP.Domain.Entities.Sales.BaoGias.LyDoTruot;
using ERP.Share.Extensions;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ERP.Persistence.Configurations.SALE.BaoGia;

internal sealed class LyDoTruotConfiguration : IEntityTypeConfiguration<LyDoTruot>
{
    public void Configure(EntityTypeBuilder<LyDoTruot> builder)
    {
        builder.ToTable("SALE_BaoGiaLyDoTruot");

        builder.HasKey(ld => ld.Id);

        builder
            .Property(e => e.Id)
            .HasConversion(EfCoreConverters.UlidToGuidConverter).HasColumnType("char(26)");


        builder
            .Property(e => e.IdBaoGia)
            .HasConversion(EfCoreConverters.UlidToGuidConverter).HasColumnType("char(26)");


        builder
            .Property(e => e.IdHangHoa)
            .HasConversion(EfCoreConverters.UlidToGuidConverter).HasColumnType("char(26)");


        builder.Property(ld => ld.LyDo)
             .HasConversion(
                 v => v.Value,
                 v => LyDoTruotDon.FromValue(v))
             .IsRequired()
             .HasMaxLength(50)
             .HasColumnType("nvarchar");

        builder.Property(ld => ld.LyDoChiTiet)
            .IsRequired()
            .HasMaxLength(128)
            .HasColumnType("nvarchar");

        builder.Property(ld => ld.TenDoiThu)
            .IsRequired()
            .HasMaxLength(128)
            .HasColumnType("nvarchar");

        builder.HasOne(ld => ld.BaoGia)
            .WithMany(bg => bg.LyDoTruots)
            .HasForeignKey(ld => ld.IdBaoGia);

    }
}
