using ERP.Domain.Entities.WareHouses.NhapKho;
using ERP.Share.Extensions;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ERP.Persistence.Configurations.WareHouses;
public sealed class NhapKhoSerialConfiguration : IEntityTypeConfiguration<NhapKhoSerial>
{
    public void Configure(EntityTypeBuilder<NhapKhoSerial> builder)
    {
        builder.ToTable("WH_NhapKhoSerial");

        builder.HasKey(cn => cn.Id);

        builder
            .Property(e => e.Id)
            .HasConversion(EfCoreConverters.UlidToGuidConverter).HasColumnType("char(26)");


        builder.Property(cn => cn.Serial).HasMaxLength(50).HasColumnType("varchar");

        builder
            .HasOne(o => o.NhapKhoChiTiet)
            .WithMany(c => c.NhapKhoSerials)
            .HasForeignKey(o => o.IdNhapKhoChiTiet);
    }
}
