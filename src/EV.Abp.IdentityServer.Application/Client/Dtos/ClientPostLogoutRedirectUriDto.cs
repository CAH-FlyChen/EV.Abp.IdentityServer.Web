using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.AutoMapper;
using Volo.Abp.IdentityServer.Clients;

namespace EV.Abp.IdentityServer
{
    [AutoMapFrom(typeof(ClientPostLogoutRedirectUri))]
    public class ClientPostLogoutRedirectUriDto
    {
        public virtual Guid ClientId { get; protected set; }
        public virtual string PostLogoutRedirectUri { get; protected set; }
    }
}
