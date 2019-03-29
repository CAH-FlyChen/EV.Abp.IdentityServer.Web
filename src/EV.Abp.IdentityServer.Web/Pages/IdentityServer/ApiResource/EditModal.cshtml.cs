using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EV.Abp.IdentityServer.Pages;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace EV.Abp.IdentityServer.Web.Pages.IdentityServer.ApiResource
{
    public class EditModalModel : IdentityServerPageModelBase
    {
        [HiddenInput]
        [BindProperty(SupportsGet = true)]
        public Guid Id { get; set; }

        [BindProperty]
        public ApiResourceDto ApiResourceUpdateDto { get; set; }

        private readonly IApiResourceAppService _apiResourceAppService;

        public EditModalModel(IApiResourceAppService apiResourceAppService)
        {
            _apiResourceAppService = apiResourceAppService;
        }

        public async Task OnGetAsync()
        {
            var dataDto = await _apiResourceAppService.GetAsync(Id);
            ApiResourceUpdateDto = ObjectMapper.Map<ApiResourceDto, ApiResourceDto>(dataDto);
        }
    }
}