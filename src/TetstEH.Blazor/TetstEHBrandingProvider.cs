using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace TetstEH.Blazor;

[Dependency(ReplaceServices = true)]
public class TetstEHBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "TetstEH";
}
