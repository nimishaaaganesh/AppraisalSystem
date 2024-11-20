using System.Net.Cache;
using Ardalis.Result;
using Ardalis.SharedKernel;
using Bytestrone.AppraisalSystem.Core.EmployeeAggregate;
using Bytestrone.AppraisalSystem.Core.EmployeeAggregate.Specifications;

namespace Bytestrone.AppraisalSystem.UseCases.Employees;
public class GetEmployeeHandler(IReadRepository<Employee> _repository) : IQueryHandler<GetEmployeeQuery, Result<EmployeeDTO>>
{
    public async Task<Result<EmployeeDTO>> Handle( GetEmployeeQuery request, CancellationToken cancellationToken)
    {
        var spec = new EmployeeByIdSpec(request.EmployeeId);
        var employee = await _repository.FirstOrDefaultAsync(spec, cancellationToken);
        if ( employee == null ) return Result.NotFound();
        var employeeDTO=new EmployeeDTO(
            employee.Id,
            employee.Name,
            employee.PhoneNumber,
            employee.Role?.Name??string.Empty,
            employee.Level?.Name?? string.Empty, 
            employee.Email,
            employee.JoinDate,
            employee.Address
        );
         return Result.Success(employeeDTO);
    }
}
