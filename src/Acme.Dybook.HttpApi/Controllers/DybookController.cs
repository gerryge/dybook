using Acme.Dybook.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace Acme.Dybook.Controllers
{
    /* Inherit your controllers from this class.
     */
    public abstract class DybookController : AbpController
    {
        protected DybookController()
        {
            LocalizationResource = typeof(DybookResource);
        }
    }
}