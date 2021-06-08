using AbpProject.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace AbpProject
{
    /* Domain tests are configured to use the EF Core provider.
     * You can switch to MongoDB, however your domain tests should be
     * database independent anyway.
     */
    [DependsOn(
        typeof(AbpProjectEntityFrameworkCoreTestModule)
        )]
    public class AbpProjectDomainTestModule : AbpModule
    {
        
    }
}
