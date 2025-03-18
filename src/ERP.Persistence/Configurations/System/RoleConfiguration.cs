using ERP.Domain.Entities.System.Users;
using ERP.Share.Extensions;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ERP.Persistence.Configurations.System;

internal sealed class RoleConfiguration : IEntityTypeConfiguration<Role>
{
    public void Configure(EntityTypeBuilder<Role> builder)
    {
        builder.ToTable("Roles");


        builder.HasKey(role => role.Id);

        builder
            .Property(e => e.Id)
            .HasConversion(EfCoreConverters.UlidToGuidConverter).HasColumnType("char(26)");

        builder.Property(cn => cn.Name)
            .HasMaxLength(30)
            .HasColumnType("varchar");


        builder.HasData(Role.User);
    }
}
