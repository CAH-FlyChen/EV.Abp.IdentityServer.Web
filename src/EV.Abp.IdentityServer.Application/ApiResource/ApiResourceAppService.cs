using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;
using Volo.Abp.IdentityServer.ApiResources;
using Volo.Abp.IdentityServer.Clients;

namespace EV.Abp.IdentityServer
{
    public class ApiResourceAppService : AsyncCrudAppService<ApiResource,ApiResourceDto,Guid>, IApiResourceAppService
    {
        public ApiResourceAppService(IRepository<ApiResource, Guid> repository)
            :base(repository)
        {
        }
    }
}
