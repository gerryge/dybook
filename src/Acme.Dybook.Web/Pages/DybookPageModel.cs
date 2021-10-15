using Acme.Dybook.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace Acme.Dybook.Web.Pages
{
    /* Inherit your PageModel classes from this class.
     */
    public abstract class DybookPageModel : AbpPageModel
    {
        protected DybookPageModel()
        {
            LocalizationResourceType = typeof(DybookResource);
        }
    }
}