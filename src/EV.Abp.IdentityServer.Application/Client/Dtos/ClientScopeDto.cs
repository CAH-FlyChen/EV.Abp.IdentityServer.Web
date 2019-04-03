using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.AutoMapper;
using Volo.Abp.IdentityServer.Clients;

namespace EV.Abp.IdentityServer
{
    [AutoMapFrom(typeof(ClientScope))]
    public class ClientScopeDto
    {
        public virtual Guid ClientId { get; protected set; }
        public virtual string Scope { get; protected set; }
    }
}
