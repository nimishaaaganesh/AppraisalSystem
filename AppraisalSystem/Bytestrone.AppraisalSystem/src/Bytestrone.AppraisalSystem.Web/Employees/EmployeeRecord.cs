namespace Bytestrone.AppraisalSystem.Web.Employees;

public record EmployeeRecord(int Id, string Name, string? PhoneNumber, string EmployeeRole, string EmployeeLevel, string? Email, DateTime DateOfJoining, string Address)
{
}
