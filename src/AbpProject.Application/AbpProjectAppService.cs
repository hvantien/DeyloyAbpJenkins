using AbpProject.Localization;
using Volo.Abp.Application.Services;

namespace AbpProject
{
    public abstract class AbpProjectAppService : ApplicationService
    {
        protected AbpProjectAppService()
        {
            LocalizationResource = typeof(AbpProjectResource);
            ObjectMapperContext = typeof(AbpProjectApplicationModule);
        }
    }
}
