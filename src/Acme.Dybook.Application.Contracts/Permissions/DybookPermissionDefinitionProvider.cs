using Acme.Dybook.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace Acme.Dybook.Permissions
{
    public class DybookPermissionDefinitionProvider : PermissionDefinitionProvider
    {
        public override void Define(IPermissionDefinitionContext context)
        {
            var myGroup = context.AddGroup(DybookPermissions.GroupName);
            //Define your own permissions here. Example:
            //myGroup.AddPermission(DybookPermissions.MyPermission1, L("Permission:MyPermission1"));
        }

        private static LocalizableString L(string name)
        {
            return LocalizableString.Create<DybookResource>(name);
        }
    }
}
