﻿using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace PwaTest.EntityFrameworkCore
{
    /* This class is needed for EF Core console commands
     * (like Add-Migration and Update-Database commands) */
    public class PwaTestMigrationsDbContextFactory : IDesignTimeDbContextFactory<PwaTestMigrationsDbContext>
    {
        public PwaTestMigrationsDbContext CreateDbContext(string[] args)
        {
            PwaTestEfCoreEntityExtensionMappings.Configure();

            var configuration = BuildConfiguration();

            var builder = new DbContextOptionsBuilder<PwaTestMigrationsDbContext>()
                .UseSqlServer(configuration.GetConnectionString("Default"));

            return new PwaTestMigrationsDbContext(builder.Options);
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
