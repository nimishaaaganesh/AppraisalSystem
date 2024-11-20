using Ardalis.Result;
using Ardalis.SharedKernel;
using Bytestrone.AppraisalSystem.UseCases.PerformanceFactor;

namespace Bytestrone.AppraisalSystem.UseCases.PerformanceFactors;
public record ListPerformanceFactorQuery():IQuery<Result<IEnumerable<PerformanceFactorDTO>>>;