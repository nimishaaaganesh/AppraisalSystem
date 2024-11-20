using Ardalis.Result;
using Ardalis.SharedKernel;
using Bytestrone.AppraisalSystem.Core.SystemRoleAggregate;

namespace Bytestrone.AppraisalSystem.UseCases.SystemRoles;
public class ListSystemRoleHandler(IRepository<SystemRole> _repository) : IQueryHandler<ListSystemRoleQuery, Result<IEnumerable<SystemRoleDTO>>>
{
    public async Task<Result<IEnumerable<SystemRoleDTO>>> Handle(ListSystemRoleQuery request, CancellationToken cancellationToken)
    {
        var systemRoles = await _repository.ListAsync();
        var systemRoleDTO= systemRoles. Select(s=>new SystemRoleDTO(s.Name));
        return Result.Success(systemRoleDTO);
    }
}