
namespace Bytestrone.AppraisalSystem.UseCases.Employees;
public record EmployeeDTO(int Id, string Name, string? PhoneNumber, string EmployeeRole, string EmployeeLevel, string? Email, DateTime DateOfJoining, string Address)
{
}
