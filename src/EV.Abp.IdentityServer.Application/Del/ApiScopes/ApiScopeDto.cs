//using JetBrains.Annotations;
//using System;
//using System.Collections.Generic;
//using System.Text;
//using Volo.Abp.Application.Dtos;
//using Volo.Abp.AutoMapper;
//using Volo.Abp.IdentityServer.ApiResources;
//using Volo.Abp.IdentityServer.Clients;

//namespace EV.Abp.IdentityServer
//{
//    [AutoMapFrom(typeof(ApiScope))]
//    public class ApiScopeDto : EntityDto
//    {
//        public virtual Guid ApiResourceId { get; protected set; }

//        [NotNull]
//        public virtual string Name { get; protected set; }

//        public virtual string DisplayName { get; set; }

//        public virtual string Description { get; set; }

//        public virtual bool Required { get; set; }

//        public virtual bool Emphasize { get; set; }

//        public virtual bool ShowInDiscoveryDocument { get; set; }

//        //public virtual List<ApiScopeClaim> UserClaims { get; protected set; }
//    }
//}
