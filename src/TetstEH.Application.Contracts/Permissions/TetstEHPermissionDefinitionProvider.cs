using TetstEH.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace TetstEH.Permissions;

public class TetstEHPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(TetstEHPermissions.GroupName);
        //Define your own permissions here. Example:
        //myGroup.AddPermission(TetstEHPermissions.MyPermission1, L("Permission:MyPermission1"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<TetstEHResource>(name);
    }
}
