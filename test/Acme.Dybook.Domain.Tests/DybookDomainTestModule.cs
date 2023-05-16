using Acme.Dybook.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace Acme.Dybook;

[DependsOn(
    typeof(DybookEntityFrameworkCoreTestModule)
    )]
public class DybookDomainTestModule : AbpModule
{

}
