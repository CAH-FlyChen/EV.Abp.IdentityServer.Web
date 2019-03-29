using System;

namespace EV.Abp.IdentityServer.Permissions
{
    public static class IdentityServerPermissions
    {
        public const string GroupName = "IdentityServer";

        //Add your own permission names. Example:
        //public const string MyPermission1 = GroupName + ".MyPermission1";

        public static string[] GetAll()
        {
            //Return an array of all permissions
            return Array.Empty<string>();
        }
    }
}