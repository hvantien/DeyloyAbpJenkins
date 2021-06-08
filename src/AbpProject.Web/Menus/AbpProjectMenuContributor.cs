using System.Threading.Tasks;
using Volo.Abp.UI.Navigation;

namespace AbpProject.Web.Menus
{
    public class AbpProjectMenuContributor : IMenuContributor
    {
        public async Task ConfigureMenuAsync(MenuConfigurationContext context)
        {
            if (context.Menu.Name == StandardMenus.Main)
            {
                await ConfigureMainMenuAsync(context);
            }
        }

        private Task ConfigureMainMenuAsync(MenuConfigurationContext context)
        {
            //Add main menu items.
            context.Menu.AddItem(new ApplicationMenuItem(AbpProjectMenus.Prefix, displayName: "AbpProject", "~/AbpProject", icon: "fa fa-globe"));

            return Task.CompletedTask;
        }
    }
}