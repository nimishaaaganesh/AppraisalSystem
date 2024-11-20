using Ardalis.SharedKernel;
using Bytestrone.AppraisalSystem.Core.SystemRoleAggregate;

namespace Bytestrone.AppraisalSystem.Core.EmployeeAggregate;
public class EmployeeRoleMapping:EntityBase,IAggregateRoot
{
    public int EmployeeId { get; set; }
    public Employee? employee{ get; set; }

    public int SystemRoleId{ get; set; }
    public SystemRole? systemRole{get; set;} 

}