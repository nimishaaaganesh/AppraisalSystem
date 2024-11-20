namespace Bytestrone.AppraisalSystem.Web.Employees;
public class EmployeeByIdRequest
{
    public const string Route="/Employees/{EmployeeId:int}";
    public static string BuildRoute(int employeeId) => Route.Replace("{EmploeeId:int}",employeeId.ToString());
    public int EmployeeId { get; set; }
}