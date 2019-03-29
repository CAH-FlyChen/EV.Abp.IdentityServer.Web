//using EV.Abp.IdentityServer.Localization.IdentityServer;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace EV.Abp.IdentityServer.Pages
{
    public abstract class IdentityServerPageModelBase : AbpPageModel
    {
        protected IdentityServerPageModelBase()
        {
            //LocalizationResourceType = typeof(IdentityServerResource);
        }
    }
}