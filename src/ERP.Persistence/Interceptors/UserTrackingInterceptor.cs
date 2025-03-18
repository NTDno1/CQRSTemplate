using System.Security.Claims;
using ERP.Domain.Abstractions.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore.Diagnostics;

namespace ERP.Persistence.Interceptors;
public class UserTrackingInterceptor : SaveChangesInterceptor
{


    private readonly IHttpContextAccessor _httpContextAccessor;

    public UserTrackingInterceptor(IHttpContextAccessor httpContextAccessor)
    {
        _httpContextAccessor = httpContextAccessor;
    }

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

        IEnumerable<EntityEntry<IUserTracking>> entries =
            dbContext
                .ChangeTracker
                .Entries<IUserTracking>();


        if (entries.Count() > 0)
        {
            string? currentUserId = _httpContextAccessor.HttpContext?.User?.FindFirst(ClaimTypes.Sid)?.Value;
            if (currentUserId != null)
            {

                foreach (EntityEntry<IUserTracking> entityEntry in entries)
                {
                    if (entityEntry.State == EntityState.Added)
                    {
                        entityEntry.Property(a => a.NguoiTao).CurrentValue = currentUserId;
                    }
                    else if (entityEntry.State == EntityState.Deleted || entityEntry.State == EntityState.Modified)
                    {
                        entityEntry.Property(a => a.NguoiSua).CurrentValue = currentUserId;
                    }
                }
            }
        }


        return base.SavingChangesAsync(
            eventData,
            result,
            cancellationToken);
    }
}
