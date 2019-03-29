using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;
using Volo.Abp.IdentityServer.Clients;
using Volo.Abp.IdentityServer.Grants;
using Volo.Abp.IdentityServer.IdentityResources;

namespace EV.Abp.IdentityServer
{
    public class IdentityResourceAppService : AsyncCrudAppService<IdentityResource, IdentityResourceDto, Guid>, IIdentityResourceAppService
    {
        public IdentityResourceAppService(IRepository<IdentityResource, Guid> repository)
            :base(repository)
        {
        }
    }
}
