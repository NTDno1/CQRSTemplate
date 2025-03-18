using ERP.Domain.Abstractions;
using ERP.Domain.Abstractions.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore.Diagnostics;

namespace ERP.Persistence.Interceptors;
public class SoftDeleteInterceptor : SaveChangesInterceptor
{
    public override ValueTask<InterceptionResult<int>> SavingChangesAsync(
        DbContextEventData eventData,
        InterceptionResult<int> result,
        CancellationToken cancellationToken = default)
    {
        DbContext? dbContext = eventData.Context;

        if (dbContext is null)
        {
            return base.SavingChangesAsync(
                eventData,
                result,
                cancellationToken);
        }

        IEnumerable<EntityEntry<ISoftDelete>> entries =
            dbContext
                .ChangeTracker
                .Entries<ISoftDelete>();

        foreach (EntityEntry<ISoftDelete> entityEntry in entries)
        {
            if (entityEntry.State == EntityState.Deleted)
            {
                entityEntry.State = EntityState.Modified;

                entityEntry.Property(a => a.NgayXoa).CurrentValue = DateTime.Now;
                entityEntry.Property(a => a.IsDeleted).CurrentValue = true;

            }

        }

        return base.SavingChangesAsync(
            eventData,
            result,
            cancellationToken);
    }

    private void HandleValueObjectProperties(EntityEntry entityEntry)
    {
        var entityType = entityEntry.Entity.GetType();

        // Iterate over all properties of the entity
        foreach (var property in entityType.GetProperties())
        {
            var propertyValue = property.GetValue(entityEntry.Entity);

            if (propertyValue != null && IsValueObject(property.PropertyType))
            {
                entityEntry.Property(property.Name).IsModified = false;
            }
        }
    }

    private bool IsValueObject(Type type)
    {
        return typeof(ValueObject).IsAssignableFrom(type);
    }
}
