using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace EV.Abp.IdentityServer.ClientSecret
{
    public class ClientGrantTypeDto:EntityDto
    {
        public virtual Guid ClientId { get; set; }
        public virtual string GrantType { get; set; }
    }
}
