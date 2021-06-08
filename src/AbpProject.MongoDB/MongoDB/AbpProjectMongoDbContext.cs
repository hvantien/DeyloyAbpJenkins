using Volo.Abp.Data;
using Volo.Abp.MongoDB;

namespace AbpProject.MongoDB
{
    [ConnectionStringName(AbpProjectDbProperties.ConnectionStringName)]
    public class AbpProjectMongoDbContext : AbpMongoDbContext, IAbpProjectMongoDbContext
    {
        /* Add mongo collections here. Example:
         * public IMongoCollection<Question> Questions => Collection<Question>();
         */

        protected override void CreateModel(IMongoModelBuilder modelBuilder)
        {
            base.CreateModel(modelBuilder);

            modelBuilder.ConfigureAbpProject();
        }
    }
}