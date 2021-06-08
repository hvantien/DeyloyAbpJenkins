using Volo.Abp.Http.Client.IdentityModel;
using Volo.Abp.Modularity;

namespace AbpProject
{
    [DependsOn(
        typeof(AbpProjectHttpApiClientModule),
        typeof(AbpHttpClientIdentityModelModule)
        )]
    public class AbpProjectConsoleApiClientModule : AbpModule
    {
        
    }
}
