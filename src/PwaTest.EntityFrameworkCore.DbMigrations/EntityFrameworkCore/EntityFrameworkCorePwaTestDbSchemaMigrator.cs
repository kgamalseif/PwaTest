using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using PwaTest.Data;
using Volo.Abp.DependencyInjection;

namespace PwaTest.EntityFrameworkCore
{
    public class EntityFrameworkCorePwaTestDbSchemaMigrator
        : IPwaTestDbSchemaMigrator, ITransientDependency
    {
        private readonly IServiceProvider _serviceProvider;

        public EntityFrameworkCorePwaTestDbSchemaMigrator(
            IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public async Task MigrateAsync()
        {
            /* We intentionally resolving the PwaTestMigrationsDbContext
             * from IServiceProvider (instead of directly injecting it)
             * to properly get the connection string of the current tenant in the
             * current scope.
             */

            await _serviceProvider
                .GetRequiredService<PwaTestMigrationsDbContext>()
                .Database
                .MigrateAsync();
        }
    }
}