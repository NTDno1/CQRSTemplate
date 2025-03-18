using ERP.Share.Extensions;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ERP.Persistence.Configurations.SALE.KhachHang;


internal sealed class KhachHangEmailNhanHoaDonConfiguration : IEntityTypeConfiguration<KhachHangEmailNhanHoaDon>
{
    public void Configure(EntityTypeBuilder<KhachHangEmailNhanHoaDon> builder)
    {
        builder.ToTable("SALE_KH_EmailNhanHoaDon");

        builder.HasKey(x => x.Id);

        builder
            .Property(e => e.Id)
            .HasConversion(EfCoreConverters.UlidToGuidConverter).HasColumnType("char(26)");


        builder
            .Property(e => e.IdHangHoa)
            .HasConversion(EfCoreConverters.UlidToGuidConverter).HasColumnType("char(26)");


        builder.Property(x => x.EmailNhanHoaDon)
            .HasMaxLength(30)
            .HasColumnType("varchar");

    }
}
