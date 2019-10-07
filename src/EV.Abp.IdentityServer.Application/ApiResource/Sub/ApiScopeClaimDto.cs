using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace EV.Abp.IdentityServer.Sub
{
    public class ApiScopeClaimDto:EntityDto
    {
        public Guid ApiResourceId { get; protected set; }
        public string Name { get; protected set; }
    }
}
