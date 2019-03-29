using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Localization;
//using EV.Abp.IdentityServer.Localization.IdentityServer;
using Volo.Abp.UI.Navigation;

namespace EV.Abp.IdentityServer.Menus
{
    public class IdentityServerMenuContributor : IMenuContributor
    {
        public async Task ConfigureMenuAsync(MenuConfigurationContext context)
        {
            if (context.Menu.Name == StandardMenus.Main)
            {
                await ConfigureMainMenuAsync(context);
            }
        }

        private async Task ConfigureMainMenuAsync(MenuConfigurationContext context)
        {
            //var l = context.ServiceProvider.GetRequiredService<IStringLocalizer<IdentityServerResource>>();

            context.Menu.Items.Insert(0, new ApplicationMenuItem("IdentityServer.Home", "Menu:Home", "/"));
        }
    }
}
