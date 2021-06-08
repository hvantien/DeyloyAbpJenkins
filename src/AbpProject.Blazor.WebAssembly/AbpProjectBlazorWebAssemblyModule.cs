using Volo.Abp.AspNetCore.Components.WebAssembly.Theming;
using Volo.Abp.Modularity;

namespace AbpProject.Blazor.WebAssembly
{
    [DependsOn(
        typeof(AbpProjectBlazorModule),
        typeof(AbpProjectHttpApiClientModule),
        typeof(AbpAspNetCoreComponentsWebAssemblyThemingModule)
        )]
    public class AbpProjectBlazorWebAssemblyModule : AbpModule
    {
        
    }
}