using Ardalis.Result;
using Bytestrone.AppraisalSystem.UseCases.Employees;
using FastEndpoints;
using MediatR;

namespace Bytestrone.AppraisalSystem.Web.Employees;
public class GetById(IMediator _mediator): Endpoint<EmployeeByIdRequest, EmployeeDTO> 
{
    public override void Configure()
  {
    Get(EmployeeByIdRequest.Route);
    AllowAnonymous();
  }
  public override async Task HandleAsync(EmployeeByIdRequest request, CancellationToken cancellationToken)
  {
    var query = new GetEmployeeQuery(request.EmployeeId);
    var result = await _mediator.Send(query,cancellationToken);
    if (result.Status==ResultStatus.NotFound)
    {
        await SendNotFoundAsync(cancellationToken);
      return;
    }
    if(result.IsSuccess)
    {
             var employeeDTO=new EmployeeDTO(
            result.Value.Id,
            result.Value.Name,
            result.Value.PhoneNumber,
            result.Value.EmployeeRole,
            result.Value.EmployeeLevel, 
           result.Value.Email,
            result.Value.DateOfJoining,
            result.Value.Address

            
        );
        Response=employeeDTO;
  };
     } }
    
