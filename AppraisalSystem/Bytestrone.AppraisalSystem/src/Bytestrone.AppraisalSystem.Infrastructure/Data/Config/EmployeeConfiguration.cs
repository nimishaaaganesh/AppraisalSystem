using Bytestrone.AppraisalSystem.Core.EmployeeAggregate;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Bytestrone.AppraisalSystem.Infrastructure.Data.Config;
public class EmployeeConfiguration : IEntityTypeConfiguration<Employee>
{
    public void Configure(EntityTypeBuilder<Employee> builder)
    {
        // builder.HasOne(e => e.Role) 
        // .WithMany(r => r.Employees) 
        // .HasForeignKey(e => e.EmployeeRoleId);
    }
}
