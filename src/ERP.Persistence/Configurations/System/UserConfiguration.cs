using ERP.Domain.Entities.System.Users;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ERP.Persistence.Configurations.System;

internal sealed class UserConfiguration : IEntityTypeConfiguration<User>
{
    public void Configure(EntityTypeBuilder<User> builder)
    {
        builder.ToTable("Sys_User");
        builder.HasKey(x => x.Id);


        builder.Property(x => x.Id)
            .HasMaxLength(20)
            .HasColumnType("varchar");

        builder.Property(user => user.HoTen)
            .IsRequired()
            .HasMaxLength(100)
            .HasColumnType("nvarchar");

        builder.Property(user => user.PasswordHashed)
            .IsRequired()
            .HasMaxLength(100)
            .HasColumnType("varchar");

        builder.Property(user => user.PasswordConfirmationHashed)
            .IsRequired()
            .HasMaxLength(100)
            .HasColumnType("varchar");

        builder.Property(user => user.Avatar)
            .IsRequired(false)
            .HasMaxLength(100)
            .HasColumnType("varchar");

        builder.Property(user => user.NoiLamViec)
            .IsRequired()
            .HasMaxLength(50)
            .HasColumnType("varchar");

        builder.Property(user => user.IsLocked)
            .IsRequired()
            .HasColumnType("bit");

    }
}
