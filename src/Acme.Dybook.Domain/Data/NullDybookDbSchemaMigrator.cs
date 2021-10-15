using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace Acme.Dybook.Data
{
    /* This is used if database provider does't define
     * IDybookDbSchemaMigrator implementation.
     */
    public class NullDybookDbSchemaMigrator : IDybookDbSchemaMigrator, ITransientDependency
    {
        public Task MigrateAsync()
        {
            return Task.CompletedTask;
        }
    }
}