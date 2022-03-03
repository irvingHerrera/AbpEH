using TetstEH.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace TetstEH.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class TetstEHController : AbpControllerBase
{
    protected TetstEHController()
    {
        LocalizationResource = typeof(TetstEHResource);
    }
}
