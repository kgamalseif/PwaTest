using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace PwaTest.Data
{
    /* This is used if database provider does't define
     * IPwaTestDbSchemaMigrator implementation.
     */
    public class NullPwaTestDbSchemaMigrator : IPwaTestDbSchemaMigrator, ITransientDependency
    {
        public Task MigrateAsync()
        {
            return Task.CompletedTask;
        }
    }
}