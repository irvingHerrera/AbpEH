using TetstEH.Localization;
using Volo.Abp.AspNetCore.Components;

namespace TetstEH.Blazor;

public abstract class TetstEHComponentBase : AbpComponentBase
{
    protected TetstEHComponentBase()
    {
        LocalizationResource = typeof(TetstEHResource);
    }
}
