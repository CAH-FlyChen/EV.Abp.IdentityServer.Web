using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EV.Abp.IdentityServer.Pages;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace EV.Abp.IdentityServer.Web.Pages.IdentityServer.Client
{
    public class EditModalModel : IdentityServerPageModelBase
    {
        [HiddenInput]
        [BindProperty(SupportsGet = true)]
        public Guid Id { get; set; }

        [BindProperty]
        public ClientCreateUpdateDto ClientUpdateDto { get; set; }

        private readonly IClientAppService _clientAppService;

        public EditModalModel(IClientAppService clientAppService)
        {
            _clientAppService = clientAppService;
        }

        public async Task OnGetAsync()
        {
            var clientDto = await _clientAppService.GetAsync(Id);
            ClientUpdateDto = ObjectMapper.Map<ClientDto, ClientCreateUpdateDto>(clientDto);
        }
    }
}