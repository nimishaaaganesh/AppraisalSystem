using Ardalis.GuardClauses;
using Ardalis.SharedKernel;

namespace Bytestrone.AppraisalSystem.Core.CycleAggregate;
public class Cycle(string quarter): EntityBase
{
    public string Quarter{get; set;} = Guard.Against.NullOrEmpty(quarter, nameof(quarter));
    public int Year{get; set;} 

}