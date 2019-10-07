using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.AutoMapper;
using Volo.Abp.IdentityServer.Clients;

namespace EV.Abp.IdentityServer
{
    [AutoMapFrom(typeof(ClientGrantType))]
    public class ClientGrantTypeDto
    {
        public virtual Guid ClientId { get; protected set; }
        public virtual string GrantType { get; protected set; }

    }
}
