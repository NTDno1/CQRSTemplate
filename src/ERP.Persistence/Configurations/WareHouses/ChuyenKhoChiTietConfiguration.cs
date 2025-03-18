using ERP.Domain.Entities.WareHouses.ChuyenKho;
using ERP.Share.Extensions;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ERP.Persistence.Configurations.WareHouses;

internal sealed class ChuyenKhoChiTietConfiguration : IEntityTypeConfiguration<ChuyenKhoChiTiet>
{
    public void Configure(EntityTypeBuilder<ChuyenKhoChiTiet> builder)
    {
        builder.ToTable("WH_ChuyenKhoChiTiet");
        builder.HasKey(x => x.Id);

        builder
            .Property(e => e.Id)
            .HasConversion(EfCoreConverters.UlidToGuidConverter).HasColumnType("char(26)");

        builder
            .Property(e => e.IdChuyenKho)
            .HasConversion(EfCoreConverters.UlidToGuidConverter).HasColumnType("char(26)");


        builder
            .Property(e => e.IdHangHoa)
            .HasConversion(EfCoreConverters.UlidToGuidConverter).HasColumnType("char(26)");


        builder
            .Property(e => e.IdXuatTaiKho)
            .HasConversion(EfCoreConverters.UlidToGuidConverter).HasColumnType("char(26)");


        builder
            .Property(e => e.IdNhapTaiKho)
            .HasConversion(EfCoreConverters.UlidToGuidConverter).HasColumnType("char(26)");


        builder.Property(whChuyenKho => whChuyenKho.MaDieuChinh)
            .HasMaxLength(64)
            .HasColumnType("varchar");


        builder.Property(whChuyenKho => whChuyenKho.SoLuong)
            .IsRequired()
            .HasColumnType("decimal(8, 3)");

        builder.Property(whChuyenKho => whChuyenKho.Tk_No)
            .IsRequired()
            .HasMaxLength(10)
            .HasColumnType("varchar");

        builder.Property(whChuyenKho => whChuyenKho.Tk_Co)
            .IsRequired()
            .HasMaxLength(10)
            .HasColumnType("varchar");

        builder.OwnsOne(whChuyenKho => whChuyenKho.NhatHang, nh =>
        {
            nh.Property(nh => nh.SoLuongDaNhat)
            .HasColumnName("SoLuongDaNhat");

            nh.Property(nh => nh.NguoiNhatHang)
            .HasColumnName("NguoiNhatHang")
            .HasMaxLength(30)
             .HasColumnType("varchar");

            nh.Property(nh => nh.NgayNhatHang)
            .HasColumnName("NgayNhatHang");
        });


        builder
            .HasOne(o => o.WhChuyenKho)
            .WithMany(c => c.ChuyenKhoChiTiets)
            .HasForeignKey(o => o.IdChuyenKho);
    }
}
