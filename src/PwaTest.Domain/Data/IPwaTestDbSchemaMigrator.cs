using System.Threading.Tasks;

namespace PwaTest.Data
{
    public interface IPwaTestDbSchemaMigrator
    {
        Task MigrateAsync();
    }
}
