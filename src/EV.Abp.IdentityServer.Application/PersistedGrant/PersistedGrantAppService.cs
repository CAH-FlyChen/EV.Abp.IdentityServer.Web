using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;
using Volo.Abp.IdentityServer.Clients;
using Volo.Abp.IdentityServer.Grants;

namespace EV.Abp.IdentityServer
{
    public class PersistedGrantAppService : AsyncCrudAppService<PersistedGrant, PersistedGrantDto, Guid>, IPersistedGrantAppService
    {
        public PersistedGrantAppService(IRepository<PersistedGrant, Guid> repository)
            :base(repository)
        {
        }
    }
}
