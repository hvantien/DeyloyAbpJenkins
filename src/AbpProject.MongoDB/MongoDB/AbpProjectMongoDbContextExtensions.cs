using System;
using Volo.Abp;
using Volo.Abp.MongoDB;

namespace AbpProject.MongoDB
{
    public static class AbpProjectMongoDbContextExtensions
    {
        public static void ConfigureAbpProject(
            this IMongoModelBuilder builder,
            Action<AbpMongoModelBuilderConfigurationOptions> optionsAction = null)
        {
            Check.NotNull(builder, nameof(builder));

            var options = new AbpProjectMongoModelBuilderConfigurationOptions(
                AbpProjectDbProperties.DbTablePrefix
            );

            optionsAction?.Invoke(options);
        }
    }
}