using System;
using System.Collections.Generic;
using System.Text;
using TetstEH.Localization;
using Volo.Abp.Application.Services;

namespace TetstEH;

/* Inherit your application services from this class.
 */
public abstract class TetstEHAppService : ApplicationService
{
    protected TetstEHAppService()
    {
        LocalizationResource = typeof(TetstEHResource);
    }
}
