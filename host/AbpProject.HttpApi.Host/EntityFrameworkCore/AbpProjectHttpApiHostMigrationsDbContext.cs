using Microsoft.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace AbpProject.EntityFrameworkCore
{
    public class AbpProjectHttpApiHostMigrationsDbContext : AbpDbContext<AbpProjectHttpApiHostMigrationsDbContext>
    {
        public AbpProjectHttpApiHostMigrationsDbContext(DbContextOptions<AbpProjectHttpApiHostMigrationsDbContext> options)
            : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ConfigureAbpProject();
        }
    }
}
