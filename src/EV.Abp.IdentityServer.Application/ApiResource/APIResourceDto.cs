using JetBrains.Annotations;
using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;
using Volo.Abp.AutoMapper;
using Volo.Abp.IdentityServer.ApiResources;
using Volo.Abp.IdentityServer.Clients;

namespace EV.Abp.IdentityServer
{
    [AutoMapFrom(typeof(ApiResource))]
    public class ApiResourceDto : EntityDto<Guid>
    {
        [NotNull]
        public virtual string Name { get; protected set; }

        public virtual string DisplayName { get; set; }
        public virtual string Description { get; set; }

        public virtual bool Enabled { get; set; }

        public virtual List<ApiSecretDto> Secrets { get; protected set; }

        public virtual List<ApiScopeDto> Scopes { get; protected set; }

        public virtual List<ApiResourceClaimDto> UserClaims { get; protected set; }
    }
}
