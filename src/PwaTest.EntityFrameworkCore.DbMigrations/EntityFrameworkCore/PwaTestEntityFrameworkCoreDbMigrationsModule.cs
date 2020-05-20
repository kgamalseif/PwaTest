using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Modularity;

namespace PwaTest.EntityFrameworkCore
{
    [DependsOn(
        typeof(PwaTestEntityFrameworkCoreModule)
        )]
    public class PwaTestEntityFrameworkCoreDbMigrationsModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddAbpDbContext<PwaTestMigrationsDbContext>();
        }
    }
}
