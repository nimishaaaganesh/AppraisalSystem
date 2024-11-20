using Ardalis.Result;
using Ardalis.SharedKernel;
using Bytestrone.AppraisalSystem.Core.PerformanceFactorAggregate;
using Bytestrone.AppraisalSystem.UseCases.PerformanceFactor;

namespace Bytestrone.AppraisalSystem.UseCases.PerformanceIndicators;

public class ListPerformanceIndicatorHandler(IRepository<PerformanceIndicator> _repository) : IQueryHandler<ListPerformanceIndicatorQuery, Result<IEnumerable<PerformanceIndicatorDTO>>>

{
    public async Task<Result<IEnumerable<PerformanceIndicatorDTO>>> Handle(ListPerformanceIndicatorQuery request, CancellationToken cancellationToken)
    {
        var performanceIndicators = await _repository.ListAsync();
        var performanceIndicatorDTO= performanceIndicators. Select(p=>new PerformanceIndicatorDTO(p.name));
        return Result.Success(performanceIndicatorDTO);
    }
}