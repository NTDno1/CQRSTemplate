using ERP.Domain.Entities.HR.CongTacPhi;
using ERP.Domain.Entities.Shared;
using ERP.Share.Extensions;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ERP.Persistence.Configurations.HR;

internal sealed class CongTacPhiConfiguration : IEntityTypeConfiguration<CongTacPhi>
{
    public void Configure(EntityTypeBuilder<CongTacPhi> builder)
    {
        builder.ToTable("HR_NV_CongTacPhi");

        builder.HasKey(ctp => ctp.Id);

        builder
            .Property(e => e.Id)
            .HasConversion(EfCoreConverters.UlidToGuidConverter).HasColumnType("char(26)");


        builder.OwnsOne(ctp => ctp.KhoangThoiGian, tg =>
        {
            tg.Property(tg => tg.TuNgay).HasColumnName("ThoiGianBatDau");
            tg.Property(tg => tg.DenNgay).HasColumnName("ThoiGianKetThuc");
        });

        builder.Property(ctp => ctp.DiaDiem)
            .HasMaxLength(30)
            .HasColumnType("varchar");

        builder.Property(ctp => ctp.MaSoDeNghi)
            .HasMaxLength(30)
            .HasColumnType("varchar");



        builder.Property(ctp => ctp.LoaiCongViec)
            .HasConversion(
                v => v.Value,
                v => LoaiCongViec.FromValue(v))
            .IsRequired()
            .HasMaxLength(50)
            .HasColumnType("nvarchar");

        builder.Property(ctp => ctp.NoiDungCongViec)
           .HasMaxLength(128)
           .HasColumnType("nvarchar");

        builder.Property(ctp => ctp.IdUserDeNghi)
            .HasMaxLength(30)
            .HasColumnType("varchar");

        builder.OwnsOne(ctp => ctp.TruongPhongDuyet, tpd =>
        {
            tpd.Property(tpd => tpd.IdUser).HasColumnName("TruongPhongDuyet").HasMaxLength(30).HasColumnType("varchar");
            tpd.Property(tpd => tpd.Ngay).HasColumnName("NgayTruongPhongDuyet");
            tpd.Property(tpd => tpd.GhiChuDuyet).HasColumnName("GhiChuTruongPhongDuyet").HasMaxLength(128).HasColumnType("nvarchar");
            tpd.Property(tpd => tpd.TrangThai)
              .HasConversion(
                  v => v.Value,
                  v => TrangThaiDonDuyet.FromValue(v))
              .HasColumnName("TrangThaiTruongPhongDuyet")
              .IsRequired()
              .HasMaxLength(50)
              .HasColumnType("nvarchar");

        });

        builder.OwnsOne(ctp => ctp.KeToanDuyet, ktd =>
        {
            ktd.Property(ktd => ktd.IdUser).HasColumnName("KeToanDuyet").HasMaxLength(30).HasColumnType("varchar");
            ktd.Property(ktd => ktd.Ngay).HasColumnName("NgayKeToanDuyet");
            ktd.Property(ktd => ktd.GhiChuDuyet).HasColumnName("GhiChuKeToanDuyet").HasMaxLength(128).HasColumnType("nvarchar");

            ktd.Property(ktd => ktd.TrangThai)
              .HasConversion(
                  v => v.Value,
                  v => TrangThaiDonDuyet.FromValue(v))
              .HasColumnName("TrangThaiKeToanDuyet")
              .IsRequired()
              .HasMaxLength(50)
              .HasColumnType("nvarchar");

        });

        builder.Property(ctp => ctp.TrangThaiThanhToan)
           .HasConversion(
               v => v.Value,
               v => TrangThaiThanhToan.FromValue(v))
           .IsRequired()
           .HasMaxLength(50)
           .HasColumnType("nvarchar");

        builder.Property(ktd => ktd.IdUserThanhToan).HasMaxLength(30).HasColumnType("varchar");
        builder.Property(ktd => ktd.IdUserHuy).HasMaxLength(30).HasColumnType("varchar");
        builder.Property(ktd => ktd.LyDoHuy).HasMaxLength(255).HasColumnType("nvarchar");

        builder.Property(ctp => ctp.TrucThuoc)
          .HasConversion(
              v => v.Value,
              v => TrucThuoc.FromValue(v))
          .IsRequired()
          .HasMaxLength(20)
          .HasColumnType("varchar");

        builder.Property(ktd => ktd.GhiChu).HasMaxLength(255).HasColumnType("nvarchar");
        builder.Property(ktd => ktd.KeToanGhiChu).HasMaxLength(255).HasColumnType("nvarchar");
        builder.Property(ktd => ktd.DiemDi).HasMaxLength(255).HasColumnType("nvarchar");
        builder.Property(ktd => ktd.DiemDen).HasMaxLength(255).HasColumnType("nvarchar");

    }
}
