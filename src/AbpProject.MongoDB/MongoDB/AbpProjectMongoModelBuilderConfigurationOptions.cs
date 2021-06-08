using JetBrains.Annotations;
using Volo.Abp.MongoDB;

namespace AbpProject.MongoDB
{
    public class AbpProjectMongoModelBuilderConfigurationOptions : AbpMongoModelBuilderConfigurationOptions
    {
        public AbpProjectMongoModelBuilderConfigurationOptions(
            [NotNull] string collectionPrefix = "")
            : base(collectionPrefix)
        {
        }
    }
}