using JetBrains.Annotations;
using Volo.Abp.EntityFrameworkCore.Modeling;

namespace AbpProject.EntityFrameworkCore
{
    public class AbpProjectModelBuilderConfigurationOptions : AbpModelBuilderConfigurationOptions
    {
        public AbpProjectModelBuilderConfigurationOptions(
            [NotNull] string tablePrefix = "",
            [CanBeNull] string schema = null)
            : base(
                tablePrefix,
                schema)
        {

        }
    }
}