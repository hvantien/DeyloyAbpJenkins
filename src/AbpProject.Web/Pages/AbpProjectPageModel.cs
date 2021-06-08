using AbpProject.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace AbpProject.Web.Pages
{
    /* Inherit your PageModel classes from this class.
     */
    public abstract class AbpProjectPageModel : AbpPageModel
    {
        protected AbpProjectPageModel()
        {
            LocalizationResourceType = typeof(AbpProjectResource);
            ObjectMapperContext = typeof(AbpProjectWebModule);
        }
    }
}