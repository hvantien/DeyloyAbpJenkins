using Volo.Abp.AspNetCore.Components.Server.Theming;
using Volo.Abp.Modularity;

namespace AbpProject.Blazor.Server
{
    [DependsOn(
        typeof(AbpAspNetCoreComponentsServerThemingModule),
        typeof(AbpProjectBlazorModule)
        )]
    public class AbpProjectBlazorServerModule : AbpModule
    {
        
    }
}