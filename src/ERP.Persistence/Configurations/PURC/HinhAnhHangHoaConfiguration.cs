using ERP.Domain.Entities.PURC;
using ERP.Share.Extensions;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ERP.Persistence.Configurations.PURC;


internal sealed class HinhAnhHangHoaConfiguration : IEntityTypeConfiguration<HinhAnhHangHoa>
{
    public void Configure(EntityTypeBuilder<HinhAnhHangHoa> builder)
    {
        builder.ToTable("PURC_HinhAnhHangHoa");

        builder.HasKey(ha => ha.Id);

        builder
            .Property(e => e.Id)
            .HasConversion(EfCoreConverters.UlidToGuidConverter).HasColumnType("char(26)");


        builder.Property(ha => ha.LinkAnh)
            .HasMaxLength(128)
            .HasColumnType("varchar");

        builder.HasOne(ha => ha.HangHoa)
            .WithMany(x => x.HinhAnhHangHoas)
            .HasForeignKey(ha => ha.IdHangHoa);

    }
}
