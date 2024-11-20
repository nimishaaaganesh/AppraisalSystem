using Ardalis.GuardClauses;
using Ardalis.SharedKernel;

namespace Bytestrone.AppraisalSystem.Core.PerformanceFactorAggregate;
public class PerformanceFactor(string name) : EntityBase, IAggregateRoot
{
    public string Name { get; set; } = Guard.Against.NullOrEmpty(name, nameof(name));
}