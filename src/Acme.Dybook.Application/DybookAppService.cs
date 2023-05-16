using System;
using System.Collections.Generic;
using System.Text;
using Acme.Dybook.Localization;
using Volo.Abp.Application.Services;

namespace Acme.Dybook;

/* Inherit your application services from this class.
 */
public abstract class DybookAppService : ApplicationService
{
    protected DybookAppService()
    {
        LocalizationResource = typeof(DybookResource);
    }
}
