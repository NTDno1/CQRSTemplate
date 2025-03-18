using ERP.Domain.Entities.HR.WFH;
using ERP.Share.Extensions;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ERP.Persistence.Configurations.HR;

internal sealed class WFHConfiguration : IEntityTypeConfiguration<WFH>
{
    public void Configure(EntityTypeBuilder<WFH> builder)
    {
        builder.ToTable("HR_WFH");

        builder.HasKey(wfh => wfh.Id);
        builder
            .Property(e => e.Id)
            .HasConversion(EfCoreConverters.UlidToGuidConverter).HasColumnType("char(26)");


        builder.Property(cn => cn.MaDeNghi)
           .HasMaxLength(30)
           .HasColumnType("varchar");

        builder.Property(wfh => wfh.IdUser)
            .HasMaxLength(30)
            .HasColumnType("varchar");

        builder.Property(wfh => wfh.LyDo)
            .HasMaxLength(255)
            .HasColumnType("nvarchar");

        builder.Property(wfh => wfh.NoiDungHuyDuyet)
            .HasMaxLength(255)
            .HasColumnType("nvarchar");



        builder.OwnsOne(wfh => wfh.KhoangThoiGian, tg =>
        {
            tg.Property(tg => tg.TuNgay).HasColumnName("TuNgay");
            tg.Property(tg => tg.DenNgay).HasColumnName("DenNgay");
        });

        builder.Property(wfh => wfh.IdUserDuyetDon)
           .HasMaxLength(30)
           .HasColumnType("varchar");

        builder.Property(wfh => wfh.TrangThaiDuyet)
         .HasConversion(
             v => v.Value,
             v => TrangThaiDuyet.FromValue(v))
         .HasMaxLength(50)
         .HasColumnType("nvarchar");

        builder.Property(wfh => wfh.TrangThaiXuLy)
         .HasConversion(
             v => v.Value,
             v => TrangThaiXuLy.FromValue(v))
         .HasMaxLength(50)
         .HasColumnType("nvarchar");

        builder.Property(wfh => wfh.TrangThaiTheoDoi)
         .HasConversion(
             v => v.Value,
             v => TrangThaiTheoDoi.FromValue(v))
         .HasMaxLength(50)
         .HasColumnType("nvarchar");


    }
}
