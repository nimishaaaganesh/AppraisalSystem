using Ardalis.Specification;
using Bytestrone.AppraisalSystem.Core.EmployeeAggregate;

namespace Bytestrone.AppraisalSystem.Core.EmployeeAggregate.Specifications;

public class EmployeesWithDetailsSpec : Specification<Employee>
{
    public EmployeesWithDetailsSpec()
    {
        Query.Include(e => e.Role)
             .Include(e => e.Level);
    }
}
