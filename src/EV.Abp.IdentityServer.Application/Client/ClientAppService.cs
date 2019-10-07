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

        public async override Task<PagedResultDto<ClientDto>> GetListAsync(PagedAndSortedResultRequestDto input)
        {
            await CheckGetAllPolicyAsync();

            var query = Repository.WithDetails(
                t=>t.ClientSecrets,
                b=>b.AllowedScopes,
                c=>c.Claims,
                d=>d.Properties,
                e=>e.AllowedGrantTypes,
                f=>f.AllowedCorsOrigins,
                g=>g.RedirectUris,
                h=>h.PostLogoutRedirectUris,
                i=>i.IdentityProviderRestrictions);

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
