using Ardalis.GuardClauses;
using Ardalis.SharedKernel;
namespace Bytestrone.AppraisalSystem.Core.PerformanceFactorAggregate;


public class PerformanceIndicator(string name): EntityBase,IAggregateRoot
{
    public int FactorId{ get; set; }
    public PerformanceFactor? performanceFactor{ get; set; }
    public string name{ get; set; }= Guard.Against.NullOrEmpty(name, nameof(name));

}