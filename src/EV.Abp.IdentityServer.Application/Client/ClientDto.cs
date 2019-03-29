using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;
using Volo.Abp.AutoMapper;
using Volo.Abp.IdentityServer.Clients;

namespace EV.Abp.IdentityServer
{
    [AutoMapFrom(typeof(Client))]
    public class ClientDto : EntityDto<Guid>
    {
        public virtual int AccessTokenLifetime { get; set; }
        public virtual int IdentityTokenLifetime { get; set; }
        public virtual bool AllowOfflineAccess { get; set; }
        public virtual bool BackChannelLogoutSessionRequired { get; set; }
        public virtual string BackChannelLogoutUri { get; set; }
        public virtual bool FrontChannelLogoutSessionRequired { get; set; }
        public virtual string FrontChannelLogoutUri { get; set; }
        public virtual bool AllowAccessTokensViaBrowser { get; set; }
        public virtual bool AllowPlainTextPkce { get; set; }
        public virtual bool RequirePkce { get; set; }
        public virtual bool AlwaysIncludeUserClaimsInIdToken { get; set; }
        public virtual bool AllowRememberConsent { get; set; }
        public virtual bool RequireConsent { get; set; }
        public virtual bool RequireClientSecret { get; set; }
        public virtual string ProtocolType { get; set; }
        public virtual bool Enabled { get; set; }
        public virtual int AuthorizationCodeLifetime { get; set; }
        public virtual int? ConsentLifetime { get; set; }
        public virtual int AbsoluteRefreshTokenLifetime { get; set; }
        public virtual int SlidingRefreshTokenLifetime { get; set; }
        //public virtual List<ClientIdPRestriction> IdentityProviderRestrictions { get; set; }
        //public virtual List<ClientPostLogoutRedirectUri> PostLogoutRedirectUris { get; set; }
        //public virtual List<ClientRedirectUri> RedirectUris { get; set; }
        //public virtual List<ClientCorsOrigin> AllowedCorsOrigins { get; set; }
        //public virtual List<ClientGrantType> AllowedGrantTypes { get; set; }
        //public virtual List<ClientSecret> ClientSecrets { get; set; }
        //public virtual List<ClientScope> AllowedScopes { get; set; }
        public virtual string LogoUri { get; set; }
        public virtual string PairWiseSubjectSalt { get; set; }
        public virtual bool AlwaysSendClientClaims { get; set; }
        public virtual bool IncludeJwtId { get; set; }
        public virtual bool EnableLocalLogin { get; set; }
        public virtual int AccessTokenType { get; set; }
        public virtual int RefreshTokenExpiration { get; set; }
        public virtual bool UpdateAccessTokenClaimsOnRefresh { get; set; }
        public virtual int RefreshTokenUsage { get; set; }
        public virtual string ClientClaimsPrefix { get; set; }
        public virtual string ClientUri { get; set; }
        public virtual string Description { get; set; }
        public virtual string ClientName { get; set; }
        //public virtual List<ClientClaim> Claims { get; set; }
        //public virtual List<ClientProperty> Properties { get; set; }
        public virtual string ClientId { get; set; }
    }

    [AutoMapTo(typeof(Client))]
    public class ClientCreateUpdateDto
    {
        public virtual int AccessTokenLifetime { get; set; }
        public virtual int IdentityTokenLifetime { get; set; }
        public virtual bool AllowOfflineAccess { get; set; }
        public virtual bool BackChannelLogoutSessionRequired { get; set; }
        public virtual string BackChannelLogoutUri { get; set; }
        public virtual bool FrontChannelLogoutSessionRequired { get; set; }
        public virtual string FrontChannelLogoutUri { get; set; }
        public virtual bool AllowAccessTokensViaBrowser { get; set; }
        public virtual bool AllowPlainTextPkce { get; set; }
        public virtual bool RequirePkce { get; set; }
        public virtual bool AlwaysIncludeUserClaimsInIdToken { get; set; }
        public virtual bool AllowRememberConsent { get; set; }
        public virtual bool RequireConsent { get; set; }
        public virtual bool RequireClientSecret { get; set; }
        public virtual string ProtocolType { get; set; }
        public virtual bool Enabled { get; set; }
        public virtual int AuthorizationCodeLifetime { get; set; }
        public virtual int? ConsentLifetime { get; set; }
        public virtual int AbsoluteRefreshTokenLifetime { get; set; }
        public virtual int SlidingRefreshTokenLifetime { get; set; }
        //public virtual List<ClientIdPRestriction> IdentityProviderRestrictions { get; set; }
        //public virtual List<ClientPostLogoutRedirectUri> PostLogoutRedirectUris { get; set; }
        //public virtual List<ClientRedirectUri> RedirectUris { get; set; }
        //public virtual List<ClientCorsOrigin> AllowedCorsOrigins { get; set; }
        //public virtual List<ClientGrantType> AllowedGrantTypes { get; set; }
        //public virtual List<ClientSecret> ClientSecrets { get; set; }
        //public virtual List<ClientScope> AllowedScopes { get; set; }
        public virtual string LogoUri { get; set; }
        public virtual string PairWiseSubjectSalt { get; set; }
        public virtual bool AlwaysSendClientClaims { get; set; }
        public virtual bool IncludeJwtId { get; set; }
        public virtual bool EnableLocalLogin { get; set; }
        public virtual int AccessTokenType { get; set; }
        public virtual int RefreshTokenExpiration { get; set; }
        public virtual bool UpdateAccessTokenClaimsOnRefresh { get; set; }
        public virtual int RefreshTokenUsage { get; set; }
        public virtual string ClientClaimsPrefix { get; set; }
        public virtual string ClientUri { get; set; }
        public virtual string Description { get; set; }
        public virtual string ClientName { get; set; }
        //public virtual List<ClientClaim> Claims { get; set; }
        //public virtual List<ClientProperty> Properties { get; set; }
        public virtual string ClientId { get; set; }
    }
}
