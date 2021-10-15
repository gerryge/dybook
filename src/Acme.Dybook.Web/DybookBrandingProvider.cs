using Volo.Abp.Ui.Branding;
using Volo.Abp.DependencyInjection;

namespace Acme.Dybook.Web
{
    [Dependency(ReplaceServices = true)]
    public class DybookBrandingProvider : DefaultBrandingProvider
    {
        public override string AppName => "Dybook";
    }
}
