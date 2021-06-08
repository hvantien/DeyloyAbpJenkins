using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace AbpProject.EntityFrameworkCore
{
    public class AbpProjectHttpApiHostMigrationsDbContextFactory : IDesignTimeDbContextFactory<AbpProjectHttpApiHostMigrationsDbContext>
    {
        public AbpProjectHttpApiHostMigrationsDbContext CreateDbContext(string[] args)
        {
            var configuration = BuildConfiguration();

            var builder = new DbContextOptionsBuilder<AbpProjectHttpApiHostMigrationsDbContext>()
                .UseSqlServer(configuration.GetConnectionString("AbpProject"));

            return new AbpProjectHttpApiHostMigrationsDbContext(builder.Options);
        }

        private static IConfigurationRoot BuildConfiguration()
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: false);

            return builder.Build();
        }
    }
}
