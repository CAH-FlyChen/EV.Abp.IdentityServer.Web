using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;
using Volo.Abp.IdentityServer.ApiResources;

namespace EV.Abp.IdentityServer.Sub
{
    public class ApiScopeDto:EntityDto
    {
        public virtual Guid ApiResourceId { get; protected set; }
        public virtual string Name { get; protected set; }
        public virtual string DisplayName { get; set; }
        public virtual string Description { get; set; }
        public virtual bool Required { get; set; }
        public virtual bool Emphasize { get; set; }
        public virtual bool ShowInDiscoveryDocument { get; set; }
        public virtual List<ApiScopeClaimDto> UserClaims { get; protected set; }
    }
}
