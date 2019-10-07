using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.AutoMapper;
using Volo.Abp.IdentityServer.ApiResources;

namespace EV.Abp.IdentityServer
{
    [AutoMapFrom(typeof(ApiResourceClaim))]
    public class ApiResourceClaimDto
    {
        public virtual Guid ApiResourceId { get; set; }
    }
}
