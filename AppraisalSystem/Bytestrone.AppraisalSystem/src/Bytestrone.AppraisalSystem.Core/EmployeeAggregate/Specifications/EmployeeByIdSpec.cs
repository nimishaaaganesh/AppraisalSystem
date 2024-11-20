using Ardalis.Specification;

namespace Bytestrone.AppraisalSystem.Core.EmployeeAggregate.Specifications;
public class EmployeeByIdSpec : Specification<Employee>
{
    public EmployeeByIdSpec(int EmployeeId) => 
    Query
    .Where(employee=>employee.Id == EmployeeId)
    .Include(e => e.Role)
    .Include(e => e.Level);
}