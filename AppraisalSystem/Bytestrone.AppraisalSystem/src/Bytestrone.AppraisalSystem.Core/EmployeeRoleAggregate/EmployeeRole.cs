using Ardalis.GuardClauses;
using Ardalis.SharedKernel;
using Bytestrone.AppraisalSystem.Core.EmployeeAggregate;

namespace Bytestrone.AppraisalSystem.Core.EmployeeRoleAggregate;
public class EmployeeRole(string name):EntityBase,IAggregateRoot
{
    public string Name{get; set;}=Guard.Against.NullOrEmpty(name, nameof(name));
    public virtual IEnumerable<Employee>? Employees{get; set;}
}