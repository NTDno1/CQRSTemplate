using ERP.Domain.Entities.Sales.DeNghi.DeNghiTraLai;
using ERP.Domain.Entities.Shared;
using ERP.Share.Extensions;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ERP.Persistence.Configurations.SALE.DeNghi;

internal sealed class DeNghiTraLaiConfiguration : IEntityTypeConfiguration<DeNghiTraLai>
{
    public void Configure(EntityTypeBuilder<DeNghiTraLai> builder)
    {
        builder.ToTable("SALE_DeNghiTraLai");

        builder.HasKey(cn => cn.Id);

        builder
            .Property(e => e.Id)
            .HasConversion(EfCoreConverters.UlidToGuidConverter).HasColumnType("char(26)");

        builder
            .Property(e => e.IdKhoNhapHang)
            .HasConversion(EfCoreConverters.UlidToGuidConverter).HasColumnType("char(26)");

        builder.Property(cn => cn.MaDeNghi)
            .HasMaxLength(30)
            .HasColumnType("varchar");

        builder.Property(cn => cn.NguoiDeNghi)
            .HasMaxLength(30)
            .HasColumnType("varchar");

        builder.Property(cn => cn.MaNhatHang)
            .HasMaxLength(30)
            .HasColumnType("varchar");

        builder.Property(cn => cn.SoPhieuXuatKho)
            .HasMaxLength(30)
            .HasColumnType("varchar");

        builder.Property(cn => cn.NguoiTraLai)
            .HasMaxLength(30)
            .HasColumnType("varchar");

        builder.Property(cn => cn.LyDoDeNghi)
            .HasMaxLength(128)
            .HasColumnType("nvarchar");

        builder.OwnsOne(dn => dn.LeaderDuyet, dn =>
        {
            dn.Property(dn => dn.IdUser).HasColumnName("LeaderDuyet").HasMaxLength(30).HasColumnType("varchar");
            dn.Property(dn => dn.Ngay).HasColumnName("NgayLeaderDuyet");
            dn.Property(dn => dn.GhiChuDuyet).HasColumnName("GhiChuLeaderDuyet").HasMaxLength(128).HasColumnType("nvarchar");

            dn.Property(dn => dn.TrangThai)
              .HasConversion(
                  v => v.Value,
                  v => TrangThaiDonDuyet.FromValue(v))
              .HasColumnName("TrangThaiLeaderDuyet")
              .IsRequired()
              .HasMaxLength(50)
              .HasColumnType("nvarchar");

        });

        builder.OwnsOne(dn => dn.KyThuatDuyet, dn =>
        {
            dn.Property(dn => dn.IdUser).HasColumnName("KyThuatDuyet").HasMaxLength(30).HasColumnType("varchar");
            dn.Property(dn => dn.Ngay).HasColumnName("NgayKyThuatDuyet");
            dn.Property(dn => dn.GhiChuDuyet).HasColumnName("GhiChuKyThuatDuyet").HasMaxLength(128).HasColumnType("nvarchar");

            dn.Property(dn => dn.TrangThai)
              .HasConversion(
                  v => v.Value,
                  v => TrangThaiDonDuyet.FromValue(v))
              .HasColumnName("TrangThaiKyThuatDuyet")
              .IsRequired()
              .HasMaxLength(50)
              .HasColumnType("nvarchar");

        });

        builder.Property(cn => cn.GhiChuDonHang)
            .IsRequired()
            .HasMaxLength(128)
            .HasColumnType("nvarchar");

        builder.Property(cn => cn.DiaChiLayHang)
            .IsRequired()
            .HasMaxLength(128)
            .HasColumnType("nvarchar");

        builder.Property(cn => cn.NguoiGiaoHangThucTe)
            .HasMaxLength(30)
            .HasColumnType("varchar");

        builder.Property(cn => cn.GhiChuGiaoNhan)
            .IsRequired()
            .HasMaxLength(128)
            .HasColumnType("nvarchar");

        builder.Property(cn => cn.SoPhieuNhapKho)
            .HasMaxLength(30)
            .HasColumnType("varchar");

        builder.Property(ctp => ctp.TrucThuoc)
             .HasConversion(
                 v => v.Value,
                 v => TrucThuoc.FromValue(v))
             .IsRequired()
             .HasMaxLength(30)
             .HasColumnType("varchar");

        builder.Property(ctp => ctp.HinhThucTraLai)
             .HasConversion(
                 v => v.Value,
                 v => HinhThucTraLai.FromValue(v))
             .IsRequired()
             .HasMaxLength(128)
             .HasColumnType("nvarchar");

        builder.Property(cn => cn.LyDoThuPhiNhapLai)
            .IsRequired()
            .HasMaxLength(128)
            .HasColumnType("nvarchar");
    }
}
