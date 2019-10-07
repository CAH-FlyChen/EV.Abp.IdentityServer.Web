using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.AutoMapper;
using Volo.Abp.IdentityServer.Clients;

namespace EV.Abp.IdentityServer
{
    [AutoMapFrom(typeof(ClientCorsOrigin))]
    public class ClientCorsOriginDto
    {
        public virtual Guid ClientId { get; protected set; }
        public virtual string Origin { get; protected set; }
    }
}
