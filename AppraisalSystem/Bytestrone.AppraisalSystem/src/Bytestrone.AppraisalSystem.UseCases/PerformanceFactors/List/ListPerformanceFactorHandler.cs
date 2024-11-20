using Ardalis.Result;
using Ardalis.SharedKernel;
using Bytestrone.AppraisalSystem.Core.PerformanceFactorAggregate;
using Bytestrone.AppraisalSystem.UseCases.PerformanceFactor;
using Bytestrone.AppraisalSystem.UseCases.PerformanceFactors;

namespace Bytestrone.AppraisalSystem.Handler;

public class ListPerformanceFactorHandler(IRepository<PerformanceFactor> _repository) : IQueryHandler<ListPerformanceFactorQuery, Result<IEnumerable<PerformanceFactorDTO>>>

{
    public async Task<Result<IEnumerable<PerformanceFactorDTO>>> Handle(ListPerformanceFactorQuery request, CancellationToken cancellationToken)
    {
        var systemRoles = await _repository.ListAsync();
        var systemRoleDTO= systemRoles. Select(p=>new PerformanceFactorDTO(p.Name));
        return Result.Success(systemRoleDTO);
    }
}