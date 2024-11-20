using Ardalis.Result;
using Ardalis.SharedKernel;

namespace Bytestrone.AppraisalSystem.UseCases.SystemRoles;
public record ListSystemRoleQuery(): IQuery<Result<IEnumerable<SystemRoleDTO>>>;