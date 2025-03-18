using ERP.Domain.Entities.System.DieuKhoanThanhToan;
using ERP.Share.Extensions;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ERP.Persistence.Configurations.System;

internal sealed class DieuKhoanThanhToanConfiguration : IEntityTypeConfiguration<DieuKhoanThanhToan>
{
    public void Configure(EntityTypeBuilder<DieuKhoanThanhToan> builder)
    {
        builder.ToTable("Sys_DieuKhoanThanhToan");

        builder.HasKey(dktt => dktt.Id);

        builder
            .Property(e => e.Id)
            .HasConversion(EfCoreConverters.UlidToGuidConverter).HasColumnType("char(26)");


        builder.Property(dktt => dktt.ThoiHanThanhToan)
            .HasMaxLength(256)
            .HasColumnType("nvarchar");

        builder.Property(dktt => dktt.LoaiDieuKhoanThanhToan)
            .HasMaxLength(128)
            .HasColumnType("nvarchar");

        builder.Property(dktt => dktt.LoaiDieuKhoanThanhToan)
            .HasMaxLength(128)
            .HasColumnType("nvarchar");

        builder.OwnsOne(dktt => dktt.DieuKhoanThanhToanNo1, dkttn1 =>
        {
            dkttn1.Property(dkttn1 => dkttn1.SoNgayDuocNo).HasColumnName("SoNgayDuocNo1");
            dkttn1.Property(dkttn1 => dkttn1.SoThangDuocNo).HasColumnName("SoThangDuocNo1");
            dkttn1.Property(dkttn1 => dkttn1.NgayThanhToan).HasColumnName("NgayThanhToan1");
            dkttn1.Property(dkttn1 => dkttn1.TuNgay).HasColumnName("TuNgay1");
            dkttn1.Property(dkttn1 => dkttn1.DenNgay).HasColumnName("DenNgay1");
        });

        builder.OwnsOne(dktt => dktt.DieuKhoanThanhToanNo2, dkttn2 =>
        {
            dkttn2.Property(dkttn1 => dkttn1.SoNgayDuocNo).HasColumnName("SoNgayDuocNo2");
            dkttn2.Property(dkttn1 => dkttn1.SoThangDuocNo).HasColumnName("SoThangDuocNo2");
            dkttn2.Property(dkttn1 => dkttn1.NgayThanhToan).HasColumnName("NgayThanhToan2");
            dkttn2.Property(dkttn1 => dkttn1.TuNgay).HasColumnName("TuNgay2");
            dkttn2.Property(dkttn1 => dkttn1.DenNgay).HasColumnName("DenNgay2");
        });

        builder.OwnsOne(dktt => dktt.DieuKhoanThanhToanNo3, dkttn3 =>
        {
            dkttn3.Property(dkttn1 => dkttn1.SoNgayDuocNo).HasColumnName("SoNgayDuocNo3");
            dkttn3.Property(dkttn1 => dkttn1.SoThangDuocNo).HasColumnName("SoThangDuocNo3");
            dkttn3.Property(dkttn1 => dkttn1.NgayThanhToan).HasColumnName("NgayThanhToan3");
            dkttn3.Property(dkttn1 => dkttn1.TuNgay).HasColumnName("TuNgay3");
            dkttn3.Property(dkttn1 => dkttn1.DenNgay).HasColumnName("DenNgay3");
        });

    }
}
