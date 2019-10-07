using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace EV.Abp.IdentityServer.Sub
{
    public class ApiSecretDto:EntityDto
    {
        public virtual Guid ApiResourceId { get; set; }
        public virtual string Type { get; protected set; }
        public virtual string Value { get; set; }
        public virtual string Description { get; set; }
        public virtual DateTime? Expiration { get; set; }
    }
}
