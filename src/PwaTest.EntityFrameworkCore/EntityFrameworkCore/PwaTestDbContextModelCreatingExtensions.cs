using Microsoft.EntityFrameworkCore;
using Volo.Abp;

namespace PwaTest.EntityFrameworkCore
{
    public static class PwaTestDbContextModelCreatingExtensions
    {
        public static void ConfigurePwaTest(this ModelBuilder builder)
        {
            Check.NotNull(builder, nameof(builder));

            /* Configure your own tables/entities inside here */

            //builder.Entity<YourEntity>(b =>
            //{
            //    b.ToTable(PwaTestConsts.DbTablePrefix + "YourEntities", PwaTestConsts.DbSchema);

            //    //...
            //});
        }
    }
}