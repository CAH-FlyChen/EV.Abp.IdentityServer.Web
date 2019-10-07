using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.AutoMapper;
using Volo.Abp.IdentityServer.Clients;

namespace EV.Abp.IdentityServer
{
    [AutoMapFrom(typeof(ClientIdPRestriction))]
    public class ClientIdPRestrictionDto
    {
        public virtual Guid ClientId { get; set; }
        public virtual string Provider { get; set; }
    }
}
