using AbpProject.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace AbpProject
{
    public abstract class AbpProjectController : AbpController
    {
        protected AbpProjectController()
        {
            LocalizationResource = typeof(AbpProjectResource);
        }
    }
}
