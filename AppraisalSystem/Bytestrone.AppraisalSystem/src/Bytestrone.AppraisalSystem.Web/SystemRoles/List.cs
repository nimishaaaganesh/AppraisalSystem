using Bytestrone.AppraisalSystem.UseCases.SystemRoles;
using Bytestrone.AppraisalSystem.Web.Employees;
using FastEndpoints;
using MediatR;

namespace Bytestrone.AppraisalSystem.Web.SystemRoles;
public class List(IMediator _mediator) : EndpointWithoutRequest<SystemRoleListResponse>
{
  public override void Configure()
  {
    Get("/SystemRoles");
    AllowAnonymous();
  }

  public override async Task HandleAsync(CancellationToken cancellationToken)
  {
    var listSystemRolesQuery= new ListSystemRoleQuery();
    var systemRoles= await _mediator.Send(listSystemRolesQuery, cancellationToken);
    Response= new SystemRoleListResponse{
        SystemRoles =systemRoles.Value.ToList()
  };
}
}