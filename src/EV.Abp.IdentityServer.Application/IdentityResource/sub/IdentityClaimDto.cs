using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace EV.Abp.IdentityServer.sub
{
    public class IdentityClaimDto:EntityDto
    {
        public virtual Guid IdentityResourceId { get; set; }
        public virtual string Type { get; protected set; }
    }
}
