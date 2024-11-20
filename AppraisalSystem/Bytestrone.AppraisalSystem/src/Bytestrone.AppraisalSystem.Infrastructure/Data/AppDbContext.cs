using System.Reflection;
using Ardalis.SharedKernel;
using Bytestrone.AppraisalSystem.Core.ContributorAggregate;
using Bytestrone.AppraisalSystem.Core.CycleAggregate;
using Bytestrone.AppraisalSystem.Core.EmployeeAggregate;
using Bytestrone.AppraisalSystem.Core.EmployeeLevelAggregate;
using Bytestrone.AppraisalSystem.Core.EmployeeRoleAggregate;
using Bytestrone.AppraisalSystem.Core.PerformanceFactorAggregate;
using Bytestrone.AppraisalSystem.Core.SystemRoleAggregate;
using Microsoft.EntityFrameworkCore;

namespace Bytestrone.AppraisalSystem.Infrastructure.Data;
public class AppDbContext(DbContextOptions<AppDbContext> options,
  IDomainEventDispatcher? dispatcher) : DbContext(options)
{
  private readonly IDomainEventDispatcher? _dispatcher = dispatcher;

  public DbSet<Contributor> Contributors => Set<Contributor>();
  public DbSet<Cycle> Cycles => Set<Cycle>();
  public DbSet<Employee> Employees => Set<Employee>();
  public DbSet<EmployeeRole> EmployeeRoles => Set<EmployeeRole>();
  public DbSet<EmployeeLevel> EmployeeLevels => Set<EmployeeLevel>();
    public DbSet<SystemRole> SystemRoles => Set<SystemRole>();
  public DbSet<PerformanceFactor> PerformanceFactors => Set<PerformanceFactor> ();
  public DbSet<PerformanceIndicator> PerformanceIndicators => Set<PerformanceIndicator> ();
  public DbSet<Question> Questions=>Set<Question>();
  public DbSet<Weightage> weightages=> Set<Weightage>();


  protected override void OnModelCreating(ModelBuilder modelBuilder)
  {
    base.OnModelCreating(modelBuilder);
    modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
  }

  public override async Task<int> SaveChangesAsync(CancellationToken cancellationToken = new CancellationToken())
  {
    int result = await base.SaveChangesAsync(cancellationToken).ConfigureAwait(false);

    // ignore events if no dispatcher provided
    if (_dispatcher == null) return result;

    // dispatch events only if save was successful
    var entitiesWithEvents = ChangeTracker.Entries<EntityBase>()
        .Select(e => e.Entity)
        .Where(e => e.DomainEvents.Any())
        .ToArray();

    await _dispatcher.DispatchAndClearEvents(entitiesWithEvents);

    return result;
  }

  public override int SaveChanges() =>
        SaveChangesAsync().GetAwaiter().GetResult();
}
