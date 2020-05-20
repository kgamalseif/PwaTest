using PwaTest.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.BackgroundJobs;
using Volo.Abp.Modularity;

namespace PwaTest.DbMigrator
{
    [DependsOn(
        typeof(AbpAutofacModule),
        typeof(PwaTestEntityFrameworkCoreDbMigrationsModule),
        typeof(PwaTestApplicationContractsModule)
        )]
    public class PwaTestDbMigratorModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<AbpBackgroundJobOptions>(options => options.IsJobExecutionEnabled = false);
        }
    }
}
