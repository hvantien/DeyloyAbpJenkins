using Localization.Resources.AbpUi;
using AbpProject.Localization;
using Volo.Abp.AspNetCore.Mvc;
using Volo.Abp.Localization;
using Volo.Abp.Modularity;
using Microsoft.Extensions.DependencyInjection;

namespace AbpProject
{
    [DependsOn(
        typeof(AbpProjectApplicationContractsModule),
        typeof(AbpAspNetCoreMvcModule))]
    public class AbpProjectHttpApiModule : AbpModule
    {
        public override void PreConfigureServices(ServiceConfigurationContext context)
        {
            PreConfigure<IMvcBuilder>(mvcBuilder =>
            {
                mvcBuilder.AddApplicationPartIfNotExists(typeof(AbpProjectHttpApiModule).Assembly);
            });
        }

        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<AbpLocalizationOptions>(options =>
            {
                options.Resources
                    .Get<AbpProjectResource>()
                    .AddBaseTypes(typeof(AbpUiResource));
            });
        }
    }
}
