using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace EV.Abp.IdentityServer.ClientSecret
{
    public class ClientPropertyDto:EntityDto
    {
        public virtual Guid ClientId { get; set; }
        public virtual string Key { get; set; }
        public virtual string Value { get; set; }
    }
}
