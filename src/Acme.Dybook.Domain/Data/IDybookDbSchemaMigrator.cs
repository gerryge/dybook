using System.Threading.Tasks;

namespace Acme.Dybook.Data
{
    public interface IDybookDbSchemaMigrator
    {
        Task MigrateAsync();
    }
}
