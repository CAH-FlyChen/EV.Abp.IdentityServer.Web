using System;
using System.Collections.Generic;
using System.Linq;
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
        public override async Task<PagedResultDto<ClientDto>> GetListAsync(PagedAndSortedResultRequestDto input)
        {
            await CheckGetAllPolicyAsync();

            var query = Repository.WithDetails(t=>t.AllowedScopes,b=>b.ClientSecrets,c=>c.AllowedGrantTypes,d=>d.AllowedCorsOrigins,
                e=>e.RedirectUris,f=>f.PostLogoutRedirectUris,g=>g.IdentityProviderRestrictions);

            var totalCount = await AsyncQueryableExecuter.CountAsync(query);

            query = ApplySorting(query, input);
            query = ApplyPaging(query, input);

            var entities = await AsyncQueryableExecuter.ToListAsync(query);

            return new PagedResultDto<ClientDto>(
                totalCount,
                entities.Select(MapToEntityDto).ToList()
            );
        }

    }
}
