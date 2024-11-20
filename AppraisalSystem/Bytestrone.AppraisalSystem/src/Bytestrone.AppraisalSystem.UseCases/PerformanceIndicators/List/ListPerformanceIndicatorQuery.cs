using Ardalis.Result;
using Ardalis.SharedKernel;
using Bytestrone.AppraisalSystem.UseCases.PerformanceFactor;

namespace Bytestrone.AppraisalSystem.UseCases.PerformanceIndicators;
public record ListPerformanceIndicatorQuery():IQuery<Result<IEnumerable<PerformanceIndicatorDTO>>>;