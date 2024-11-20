using Ardalis.GuardClauses;
using Ardalis.SharedKernel;

namespace Bytestrone.AppraisalSystem.Core.EmployeeLevelAggregate;
public class EmployeeLevel(string name) : EntityBase, IAggregateRoot
{
    public string Name { get; set; }= Guard.Against.NullOrEmpty(name, nameof(name));
}