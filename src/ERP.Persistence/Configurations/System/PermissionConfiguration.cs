using ERP.Domain.Entities.System.Users;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ERP.Persistence.Configurations.System;

internal sealed class PermissionConfiguration : IEntityTypeConfiguration<Permission>
{
    public void Configure(EntityTypeBuilder<Permission> builder)
    {
        builder.ToTable("Permission");

        builder.HasKey(permission => permission.Id);

        builder.Property(cn => cn.Name)
            .HasMaxLength(30)
            .HasColumnType("varchar");

        builder.HasData(Permission.UsersRead);
    }
}
