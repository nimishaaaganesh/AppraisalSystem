using Ardalis.Result;
using Ardalis.SharedKernel;

namespace Bytestrone.AppraisalSystem.UseCases.Employees;
public record GetEmployeeQuery(int EmployeeId) : IQuery<Result<EmployeeDTO>>;