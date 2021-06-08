using Volo.Abp.Domain;
using Volo.Abp.Modularity;

namespace AbpProject
{
    [DependsOn(
        typeof(AbpDddDomainModule),
        typeof(AbpProjectDomainSharedModule)
    )]
    public class AbpProjectDomainModule : AbpModule
    {

    }
}
