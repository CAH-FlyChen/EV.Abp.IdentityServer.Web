using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace EV.Abp.IdentityServer.ClientSecret
{
    public class ClientIdPRestrictionDto:EntityDto
    {
        public virtual Guid ClientId { get; set; }
        public virtual string Provider { get; set; }
    }
}
