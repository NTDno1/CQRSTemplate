using ERP.Domain.Entities.WareHouses.NhapKho;
using ERP.Share.Extensions;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ERP.Persistence.Configurations.WareHouses;
public sealed class NhapKhoChiTietConfiguration : IEntityTypeConfiguration<NhapKhoChiTiet>
{
    public void Configure(EntityTypeBuilder<NhapKhoChiTiet> builder)
    {
        builder.ToTable("WH_NhapKhoChiTiet");

        builder.HasKey(cn => cn.Id);

        builder
            .Property(e => e.Id)
            .HasConversion(EfCoreConverters.UlidToGuidConverter).HasColumnType("char(26)");


        builder.Property(cn => cn.MaDieuChinh)
          .HasMaxLength(55)
          .HasColumnType("varchar");

        builder.Property(cn => cn.TenHang)
            .HasMaxLength(256)
            .HasColumnType("nvarchar");

        builder.Property(cn => cn.MaKhoCon)
          .HasMaxLength(30)
          .HasColumnType("varchar");

        builder.Property(cn => cn.TkNo)
            .HasMaxLength(20)
            .HasColumnType("varchar");

        builder.Property(cn => cn.TkCo)
           .HasMaxLength(20)
           .HasColumnType("varchar");

        builder
           .Property(e => e.IdCtTraLai)
           .HasConversion(EfCoreConverters.UlidToGuidConverter).HasColumnType("char(26)");


        builder
           .Property(e => e.IdHangHoa)
           .HasConversion(EfCoreConverters.UlidToGuidConverter).HasColumnType("char(26)");



        builder.Property(cn => cn.TkGiaVon)
            .HasMaxLength(20)
            .HasColumnType("varchar");

        builder.Property(cn => cn.TkKho)
          .HasMaxLength(20)
          .HasColumnType("varchar");


        builder.Property(cn => cn.TkThue)
             .HasMaxLength(20)
             .HasColumnType("varchar");

        builder.Property(cn => cn.DonViTinh)
        .HasMaxLength(20)
        .HasColumnType("nvarchar");

        builder.Property(cn => cn.DienGiaiThue)
          .HasMaxLength(1024)
          .HasColumnType("nvarchar");

        builder.Property(cn => cn.SoHoaDon)
        .HasMaxLength(50)
        .HasColumnType("varchar");

        builder.Property(cn => cn.GhiChu)
         .HasMaxLength(1024)
         .HasColumnType("nvarchar");

        builder.Property(cn => cn.MaVach)
        .HasMaxLength(50)
        .HasColumnType("varchar");


        builder.Property(cn => cn.LoaiTien)
         .HasMaxLength(20)
         .HasColumnType("varchar");

        builder
           .Property(e => e.IdNhapKho)
           .HasConversion(EfCoreConverters.UlidToGuidConverter).HasColumnType("char(26)");


        builder.Property(cn => cn.GhiChuCongNoCt)
         .HasMaxLength(1024)
         .HasColumnType("nvarchar");

        builder.Property(cn => cn.PrTichXuLyDauVao)
        .HasMaxLength(30)
        .HasColumnType("varchar");

        builder.Property(cn => cn.IdTechMuaHang)
            .HasMaxLength(30)
            .HasColumnType("varchar");

        builder.Property(cn => cn.KtTichCham)
         .HasMaxLength(30)
         .HasColumnType("varchar");

        builder
            .HasOne(o => o.WhNhapKho)
            .WithMany(c => c.NhapKhoChiTiets)
            .HasForeignKey(o => o.IdNhapKho);
    }
}
