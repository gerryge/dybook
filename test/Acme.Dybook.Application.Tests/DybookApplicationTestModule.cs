using Volo.Abp.Modularity;

namespace Acme.Dybook
{
    [DependsOn(
        typeof(DybookApplicationModule),
        typeof(DybookDomainTestModule)
        )]
    public class DybookApplicationTestModule : AbpModule
    {

    }
}