using ERP.Domain.Entities.Sales.BaoGias.BaoGia;
using ERP.Domain.Entities.Sales.BaoGias.BaoGiaChiTiet;
using ERP.Share.Extensions;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ERP.Persistence.Configurations.SALE.BaoGia;


internal sealed class BaoGiaChiTietConfiguration : IEntityTypeConfiguration<BaoGiaChiTiet>
{
    public void Configure(EntityTypeBuilder<BaoGiaChiTiet> builder)
    {
        builder.ToTable("SALE_BaoGiaChiTiet");

        builder.HasKey(ct => ct.Id);


        builder
            .Property(e => e.Id)
            .HasConversion(EfCoreConverters.UlidToGuidConverter).HasColumnType("char(26)");


        builder
            .Property(e => e.IdHangHoa)
            .HasConversion(EfCoreConverters.UlidToGuidConverter).HasColumnType("char(26)");


        builder
            .Property(e => e.IdKhoXuLy)
            .HasConversion(EfCoreConverters.UlidToGuidConverter).HasColumnType("char(26)");


        builder
            .Property(e => e.IdNhomHang)
            .HasConversion(EfCoreConverters.UlidToGuidConverter).HasColumnType("char(26)");


        builder.Property(ct => ct.MaDieuChinh)
            .HasMaxLength(128)
            .HasColumnType("nvarchar");

        builder.Property(ct => ct.TenHang)
            .HasMaxLength(128)
            .HasColumnType("nvarchar");


        builder.Property(ct => ct.ItemCode)
            .HasMaxLength(128)
            .HasColumnType("nvarchar");

        builder.OwnsOne(ct => ct.DonGia, dg =>
        {
            dg.Property(dg => dg.DonGiaNet).HasColumnName("DonGiaNet");
            dg.Property(dg => dg.DonGiaBan).HasColumnName("DonGiaBan");
            dg.Property(dg => dg.DonGiaMoi).HasColumnName("DonGiaMoi");
            dg.Property(dg => dg.DonGiaDichVuVat).HasColumnName("DonGiaDichVuVat");

        });

        builder.Property(cn => cn.DonViTinh)
            .HasMaxLength(30)
            .HasColumnType("nvarchar");

        builder.Property(ct => ct.GhiChu)
            .HasMaxLength(128)
            .HasColumnType("nvarchar");

        builder.Property(ct => ct.HinhAnhMinhHoa)
            .HasMaxLength(128)
            .HasColumnType("varchar");

        builder.Property(ct => ct.NoiDungYeuCauHoiHang)
            .HasMaxLength(128)
            .HasColumnType("nvarchar");

        builder.Property(ct => ct.MaXinGia)
            .HasMaxLength(128)
            .HasColumnType("varchar");

        builder.Property(ct => ct.TrangThaiDuyetGia)
             .HasConversion(
                 v => v.Value,
                 v => TrangThaiDuyetGia.FromValue(v))
             .IsRequired()
             .HasMaxLength(50)
             .HasColumnType("nvarchar");

        builder.OwnsOne(ct => ct.GiaBanThucTe, gb =>
        {
            gb.Property(gb => gb.GiaBanThucTe1).HasColumnName("GiaBanThucTe1");
            gb.Property(gb => gb.GiaBanThucTe2).HasColumnName("GiaBanThucTe2");
            gb.Property(gb => gb.GiaBanThucTe3).HasColumnName("GiaBanThucTe3");
            gb.Property(gb => gb.GiaBanThucTe4).HasColumnName("GiaBanThucTe4");

        });

        builder.HasOne(ct => ct.BaoGia)
            .WithMany(bg => bg.BaoGiaChiTiets)
            .HasForeignKey(ct => ct.IdBaoGia);
    }
}
