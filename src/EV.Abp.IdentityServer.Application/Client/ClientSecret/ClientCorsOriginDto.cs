using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace EV.Abp.IdentityServer.ClientSecret
{
    public class ClientCorsOriginDto:EntityDto
    {
        public virtual Guid ClientId { get; set; }
        public virtual string Origin { get; set; }

    }
}
