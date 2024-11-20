using Ardalis.Result;
using Ardalis.SharedKernel;

namespace Bytestrone.AppraisalSystem.UseCases.Employees;
public record ListEmployeesQuery():IQuery<Result<IEnumerable<EmployeeDTO>>>;