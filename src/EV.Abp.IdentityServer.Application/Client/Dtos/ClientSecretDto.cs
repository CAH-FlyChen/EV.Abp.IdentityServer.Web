using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.AutoMapper;
using Volo.Abp.IdentityServer.Clients;

namespace EV.Abp.IdentityServer
{
    [AutoMapFrom(typeof(ClientSecret))]
    public class ClientSecretDto
    {
        public virtual Guid ClientId { get; protected set; }
        public virtual string Type { get; protected set; }
        public virtual string Value { get; set; }
        public virtual string Description { get; set; }
        public virtual DateTime? Expiration { get; set; }
    }
}
