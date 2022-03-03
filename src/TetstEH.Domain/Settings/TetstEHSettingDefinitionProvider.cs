using Volo.Abp.Settings;

namespace TetstEH.Settings;

public class TetstEHSettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(TetstEHSettings.MySetting1));
    }
}
