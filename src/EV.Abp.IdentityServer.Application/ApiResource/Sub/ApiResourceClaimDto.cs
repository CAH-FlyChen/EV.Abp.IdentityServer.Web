using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace EV.Abp.IdentityServer.Sub
{
    public class ApiResourceClaimDto:EntityDto
    {
        public virtual Guid ApiResourceId { get; set; }
        public virtual string Type { get; protected set; }
    }
}
