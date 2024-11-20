using Ardalis.GuardClauses;
using Ardalis.SharedKernel;
using Bytestrone.AppraisalSystem.Core.CycleAggregate;
using Bytestrone.AppraisalSystem.Core.EmployeeLevelAggregate;
using Bytestrone.AppraisalSystem.Core.EmployeeRoleAggregate;

namespace Bytestrone.AppraisalSystem.Core.PerformanceFactorAggregate;

public class Question(string description): EntityBase,IAggregateRoot
{
    public int FactorId { get; set; }
    public PerformanceFactor? performanceFactor{ get; set; }
    public int IndicatorId { get; set; }
    public PerformanceIndicator? performanceIndicator{ get; set; }
    public int RoleId{ get; set; }
    public EmployeeRole? employeeRole{ get; set; }
    public int EmployeeLevelId{ get; set; }
    public EmployeeLevel? employeeLevel{ get; set; }
    public int CycleId{ get; set; }
    public Cycle? cycle{ get; set; }
    public string Description{ get; set; }= Guard.Against.NullOrEmpty(description, nameof(description));

}