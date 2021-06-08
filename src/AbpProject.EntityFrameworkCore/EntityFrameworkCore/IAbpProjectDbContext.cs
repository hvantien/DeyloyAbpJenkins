using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;

namespace AbpProject.EntityFrameworkCore
{
    [ConnectionStringName(AbpProjectDbProperties.ConnectionStringName)]
    public interface IAbpProjectDbContext : IEfCoreDbContext
    {
        /* Add DbSet for each Aggregate Root here. Example:
         * DbSet<Question> Questions { get; }
         */
    }
}