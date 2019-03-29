using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EV.Abp.IdentityServer.Pages;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace EV.Abp.IdentityServer.Web.Pages.IdentityServer.PersistedGrant
{
    public class CreateModalModel : IdentityServerPageModelBase
    {
        [BindProperty]
        public PersistedGrantDto PersistedGrantCreateDto { get; set; }
        public void OnGet()
        {

        }
    }
}