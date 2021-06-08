using System.Threading.Tasks;
using AbpProject.Localization;
using Volo.Abp.UI.Navigation;

namespace AbpProject.Blazor.Host
{
    public class AbpProjectHostMenuContributor : IMenuContributor
    {
        public Task ConfigureMenuAsync(MenuConfigurationContext context)
        {
            if(context.Menu.DisplayName != StandardMenus.Main)
            {
                return Task.CompletedTask;
            }

            var l = context.GetLocalizer<AbpProjectResource>();

            context.Menu.Items.Insert(
                0,
                new ApplicationMenuItem(
                    "AbpProject.Home",
                    l["Menu:Home"],
                    "/",
                    icon: "fas fa-home"
                )
            );

            return Task.CompletedTask;
        }
    }
}
