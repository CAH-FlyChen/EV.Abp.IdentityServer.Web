//using EV.Abp.IdentityServer.Localization.IdentityServer;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace EV.Abp.IdentityServer.Permissions
{
    public class IdentityServerPermissionDefinitionProvider : PermissionDefinitionProvider
    {
        public override void Define(IPermissionDefinitionContext context)
        {
            var myGroup = context.AddGroup(IdentityServerPermissions.GroupName);

            //Define your own permissions here. Examaple:
            //myGroup.AddPermission(IdentityServerPermissions.MyPermission1, L("Permission:MyPermission1"));
        }

        private static LocalizableString L(string name)
        {
            //return LocalizableString.Create<IdentityServerResource>(name);
            return null;
        }
    }
}
