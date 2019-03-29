using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EV.Abp.IdentityServer.Pages;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace EV.Abp.IdentityServer.Web.Pages.IdentityServer.PersistedGrant
{
    public class EditModalModel : IdentityServerPageModelBase
    {
        [HiddenInput]
        [BindProperty(SupportsGet = true)]
        public Guid Id { get; set; }

        [BindProperty]
        public PersistedGrantDto PersistedGrantUpdateDto { get; set; }

        private readonly IPersistedGrantAppService _persistedGrantAppService;

        public EditModalModel(IPersistedGrantAppService persistedGrantAppService)
        {
            _persistedGrantAppService = persistedGrantAppService;
        }

        public async Task OnGetAsync()
        {
            var dataDto = await _persistedGrantAppService.GetAsync(Id);
            PersistedGrantUpdateDto = ObjectMapper.Map<PersistedGrantDto, PersistedGrantDto>(dataDto);
        }
    }
}