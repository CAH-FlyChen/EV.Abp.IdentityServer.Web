using Volo.Abp.AspNetCore.Mvc.UI.Theme.Shared.Components;
using Volo.Abp.DependencyInjection;

namespace EV.Abp.IdentityServer.Branding
{
    [Dependency(ReplaceServices = true)]
    public class IdentityServerBrandingProvider : DefaultBrandingProvider
    {
        public override string AppName => "IdentityServer";
    }
}
