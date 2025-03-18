using ERP.Domain.Entities.WareHouses.XuatKho;
using ERP.Share.Extensions;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ERP.Persistence.Configurations.WareHouses;
internal class XuatKhoSerialConfiguration : IEntityTypeConfiguration<XuatKhoSerial>
{
    public void Configure(EntityTypeBuilder<XuatKhoSerial> builder)
    {
        builder.ToTable("WH_XuatKhoSerial");

        builder.HasKey(cn => cn.Id);

        builder
            .Property(e => e.Id)
            .HasConversion(EfCoreConverters.UlidToGuidConverter).HasColumnType("char(26)");


        builder.Property(cn => cn.Serial).HasMaxLength(50).HasColumnType("varchar");

        builder
            .HasOne(o => o.XuatKhoChiTiet)
            .WithMany(c => c.XuatKhoSerials)
            .HasForeignKey(o => o.IdXuatKhoChiTiet);
    }
}
