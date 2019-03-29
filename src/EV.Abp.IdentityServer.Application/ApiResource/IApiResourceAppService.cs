using System;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace EV.Abp.IdentityServer
{
    public interface IApiResourceAppService: IAsyncCrudAppService<
            ApiResourceDto, //用来展示书籍
            Guid, //Book实体的主键
            PagedAndSortedResultRequestDto>
    {
    }
}