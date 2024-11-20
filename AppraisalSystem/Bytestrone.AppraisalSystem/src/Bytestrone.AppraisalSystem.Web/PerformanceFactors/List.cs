
using Bytestrone.AppraisalSystem.UseCases.PerformanceFactors;
using FastEndpoints;
using MediatR;

namespace Bytestrone.AppraisalSystem.Web.PerformanceFactors;
public class List(IMediator _mediator) : EndpointWithoutRequest<PerformanceFactorListResponse>
{
  public override void Configure()
  {
    Get("/PerformanceFactors");
    AllowAnonymous();
  }
   public override async Task HandleAsync(CancellationToken cancellationToken)
  {
    var listPerformanceFactorQuery= new ListPerformanceFactorQuery();
    var performanceFactors= await _mediator.Send(listPerformanceFactorQuery, cancellationToken);
    Response= new PerformanceFactorListResponse{
        PerformanceFactors =performanceFactors.Value.ToList()
  };
}
}