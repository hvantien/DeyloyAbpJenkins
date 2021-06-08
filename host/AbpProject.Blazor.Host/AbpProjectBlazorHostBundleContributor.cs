using Volo.Abp.Bundling;

namespace AbpProject.Blazor.Host
{
    public class AbpProjectBlazorHostBundleContributor : IBundleContributor
    {
        public void AddScripts(BundleContext context)
        {

        }

        public void AddStyles(BundleContext context)
        {
            context.Add("main.css", true);
        }
    }
}
