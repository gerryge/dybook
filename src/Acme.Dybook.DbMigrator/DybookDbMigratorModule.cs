using Acme.Dybook.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace Acme.Dybook.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(DybookEntityFrameworkCoreModule),
    typeof(DybookApplicationContractsModule)
    )]
public class DybookDbMigratorModule : AbpModule
{

}
