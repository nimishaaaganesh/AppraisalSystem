using Ardalis.SharedKernel;
using Bytestrone.AppraisalSystem.Core.CycleAggregate;
using Bytestrone.AppraisalSystem.Core.EmployeeLevelAggregate;
using Bytestrone.AppraisalSystem.Core.EmployeeRoleAggregate;
namespace Bytestrone.AppraisalSystem.Core.PerformanceFactorAggregate;

public class Weightage : EntityBase,IAggregateRoot
{
    public int RoleId { get; set; }
    public virtual EmployeeRole? employeeRole{ get; set; }
    public int LevelId{ get; set; }
    public EmployeeLevel? employeeLevel{ get; set; } = default!;
    public int FactorId { get; set; }
    public PerformanceFactor? performanceFactor{ get; set; }
    public int CycleId { get; set; }
    public Cycle? cycle{ get; set; }
    public int WeightageValue{ get; set; }

}