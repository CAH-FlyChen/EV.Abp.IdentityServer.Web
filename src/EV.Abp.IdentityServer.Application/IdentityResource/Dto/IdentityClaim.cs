using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.AutoMapper;
using Volo.Abp.Identity;

namespace EV.Abp.IdentityServer
{
    [AutoMapFrom(typeof(IdentityClaim))]
    public class IdentityClaimDto
    {
        public virtual Guid? TenantId { get; protected set; }
        public virtual string ClaimType { get; protected set; }
        public virtual string ClaimValue { get; protected set; }
    }
}
