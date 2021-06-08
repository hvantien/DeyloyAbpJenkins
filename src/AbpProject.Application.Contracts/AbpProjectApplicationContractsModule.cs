using Volo.Abp.Application;
using Volo.Abp.Modularity;
using Volo.Abp.Authorization;

namespace AbpProject
{
    [DependsOn(
        typeof(AbpProjectDomainSharedModule),
        typeof(AbpDddApplicationContractsModule),
        typeof(AbpAuthorizationModule)
        )]
    public class AbpProjectApplicationContractsModule : AbpModule
    {

    }
}
