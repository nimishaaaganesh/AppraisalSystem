using Bytestrone.AppraisalSystem.UseCases.Employees;
using FastEndpoints;
using MediatR;

namespace Bytestrone.AppraisalSystem.Web.Employees;
public class List(IMediator _mediator) : EndpointWithoutRequest<EmployeeListResponse>
{
  public override void Configure()
  {
    Get("/Employees");
    AllowAnonymous();
  }
  public override async Task HandleAsync(CancellationToken cancellationToken)
  {
    var listEmployeesQuery = new ListEmployeesQuery();
    var employees = await _mediator.Send(listEmployeesQuery, cancellationToken);
    Response = new EmployeeListResponse{
        Employees = employees.Value.ToList()
  };
}
}