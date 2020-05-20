using PwaTest.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace PwaTest.Permissions
{
    public class PwaTestPermissionDefinitionProvider : PermissionDefinitionProvider
    {
        public override void Define(IPermissionDefinitionContext context)
        {
            var myGroup = context.AddGroup(PwaTestPermissions.GroupName);

            //Define your own permissions here. Example:
            //myGroup.AddPermission(PwaTestPermissions.MyPermission1, L("Permission:MyPermission1"));
        }

        private static LocalizableString L(string name)
        {
            return LocalizableString.Create<PwaTestResource>(name);
        }
    }
}
