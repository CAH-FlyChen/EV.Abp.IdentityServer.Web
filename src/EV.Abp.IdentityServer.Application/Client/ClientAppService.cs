using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;
using Volo.Abp.IdentityServer.Clients;

namespace EV.Abp.IdentityServer
{
    public class ClientAppService : AsyncCrudAppService<Client,ClientDto,Guid>, IClientAppService
    {
        public ClientAppService(IRepository<Client, Guid> repository)
            :base(repository)
        {
        }
    }
}
