using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace ERP.Persistence;

public sealed class ApplicationDbContext : DbContext
{

    public ApplicationDbContext() { }

    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
        ChangeTracker.CascadeDeleteTiming = CascadeTiming.OnSaveChanges;
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        builder.ApplyConfigurationsFromAssembly(AssemblyReference.Assembly);
        base.OnModelCreating(builder);
    }
}
