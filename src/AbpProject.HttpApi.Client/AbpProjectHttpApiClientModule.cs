using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Http.Client;
using Volo.Abp.Modularity;

namespace AbpProject
{
    [DependsOn(
        typeof(AbpProjectApplicationContractsModule),
        typeof(AbpHttpClientModule))]
    public class AbpProjectHttpApiClientModule : AbpModule
    {
        public const string RemoteServiceName = "AbpProject";

        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddHttpClientProxies(
                typeof(AbpProjectApplicationContractsModule).Assembly,
                RemoteServiceName
            );
        }
    }
}
