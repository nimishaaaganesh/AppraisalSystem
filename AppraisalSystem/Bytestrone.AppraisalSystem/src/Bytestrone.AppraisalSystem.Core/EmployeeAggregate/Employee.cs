using Ardalis.GuardClauses;
using Ardalis.SharedKernel;
using Bytestrone.AppraisalSystem.Core.EmployeeLevelAggregate;
using Bytestrone.AppraisalSystem.Core.EmployeeRoleAggregate;

namespace Bytestrone.AppraisalSystem.Core.EmployeeAggregate;
public class Employee(string name, string phoneNumber, string email, string address) : EntityBase, IAggregateRoot
{
    public string Name { get; set; } = Guard.Against.NullOrEmpty(name, nameof(name));
    public string PhoneNumber { get; set; } = Guard.Against.NullOrEmpty(phoneNumber, nameof(phoneNumber));
    public string Email { get; set; } = Guard.Against.NullOrEmpty(email, nameof(email));
    public DateTime JoinDate{ get; set; }
    public int EmployeeRoleId { get; set; }
    public  EmployeeRole Role{ get; set; } = default!; //TODO check the best practice
    public int EmployeeLevelId { get; set; } 
    public virtual EmployeeLevel? Level{ get; set; } 
    public string Address { get; set; } = Guard.Against.NullOrEmpty(address, nameof(address));
    public bool IsActive{ get; set; }
    public DateTime CreatedAt{ get; set; }
    public DateTime ModifiedAt{ get; set; }
}