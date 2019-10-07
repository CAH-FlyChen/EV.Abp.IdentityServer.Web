using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace EV.Abp.IdentityServer.ClientSecret
{
    public class ClientSecretDto : EntityDto
    {
        public virtual Guid ClientId { get; set; }
        public virtual string Type { get; set; }
        public virtual string Value { get; set; }
        public virtual string Description { get; set; }
        public virtual DateTime? Expiration { get; set; }
    }
}
