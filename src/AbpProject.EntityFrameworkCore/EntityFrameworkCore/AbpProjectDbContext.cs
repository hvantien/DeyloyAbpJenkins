using Microsoft.EntityFrameworkCore;
using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;

namespace AbpProject.EntityFrameworkCore
{
    [ConnectionStringName(AbpProjectDbProperties.ConnectionStringName)]
    public class AbpProjectDbContext : AbpDbContext<AbpProjectDbContext>, IAbpProjectDbContext
    {
        /* Add DbSet for each Aggregate Root here. Example:
         * public DbSet<Question> Questions { get; set; }
         */

        public AbpProjectDbContext(DbContextOptions<AbpProjectDbContext> options) 
            : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.ConfigureAbpProject();
        }
    }
}