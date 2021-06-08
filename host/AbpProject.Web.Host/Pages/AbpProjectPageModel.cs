using AbpProject.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace AbpProject.Pages
{
    public abstract class AbpProjectPageModel : AbpPageModel
    {
        protected AbpProjectPageModel()
        {
            LocalizationResourceType = typeof(AbpProjectResource);
        }
    }
}