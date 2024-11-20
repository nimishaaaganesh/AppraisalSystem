using Ardalis.Result;
using Ardalis.SharedKernel;
using Bytestrone.AppraisalSystem.Core.EmployeeAggregate;
using Bytestrone.AppraisalSystem.Core.EmployeeAggregate.Specifications;

namespace Bytestrone.AppraisalSystem.UseCases.Employees;

public class ListEmployeeHandler(IRepository<Employee> _repository) : IQueryHandler<ListEmployeesQuery, Result<IEnumerable<EmployeeDTO>>>
{
    public async Task<Result<IEnumerable<EmployeeDTO>>> Handle(ListEmployeesQuery request, CancellationToken cancellationToken)
    {
        var spec = new EmployeesWithDetailsSpec();
        var employees = await _repository.ListAsync(spec);
        
        var employeeDTO=employees
        .Select(e=> new EmployeeDTO(
            e.Id,
            e.Name,
            e.PhoneNumber,
            e.Role?.Name??string.Empty,
            e.Level?.Name?? string.Empty, 
            e.Email,
            e.JoinDate,
            e.Address
        ));
        return Result.Success(employeeDTO);
    }
    
}