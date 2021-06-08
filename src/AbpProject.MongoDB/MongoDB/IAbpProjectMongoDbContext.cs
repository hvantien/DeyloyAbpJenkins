using Volo.Abp.Data;
using Volo.Abp.MongoDB;

namespace AbpProject.MongoDB
{
    [ConnectionStringName(AbpProjectDbProperties.ConnectionStringName)]
    public interface IAbpProjectMongoDbContext : IAbpMongoDbContext
    {
        /* Define mongo collections here. Example:
         * IMongoCollection<Question> Questions { get; }
         */
    }
}
