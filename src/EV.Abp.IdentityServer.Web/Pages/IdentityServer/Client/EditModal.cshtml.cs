using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;
using EV.Abp.IdentityServer.Dtos.Client;
using EV.Abp.IdentityServer.Pages;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Volo.Abp.AspNetCore.Mvc.UI.Bootstrap.TagHelpers.Form;

namespace EV.Abp.IdentityServer.Web.Pages.IdentityServer.Client
{
    public class ClientIdPRestrictionWebDto
    {
        public virtual Guid ClientId { get; set; }
        public virtual string Provider { get; set; }
    }

    public class ClientPostLogoutRedirectUriWebDto
    {
        public virtual Guid ClientId { get; protected set; }
        public virtual string PostLogoutRedirectUri { get; protected set; }
    }

    public class ClientRedirectUriWebDto
    {
        public virtual Guid ClientId { get; set; }
        public virtual string RedirectUri { get; set; }
    }

    public class ClientCorsOriginWebDto
    {
        public virtual Guid ClientId { get; protected set; }
        public virtual string Origin { get; protected set; }

    }

    public class ClientGrantTypeWebDto
    {
        public virtual Guid ClientId { get; protected set; }
        public virtual string GrantType { get; protected set; }
    }

    public class ClientPropertyWebDto
    {
        public virtual Guid ClientId { get; set; }
        public virtual string Key { get; set; }
        public virtual string Value { get; set; }
    }

    public class ClientClaimWebDto
    {
        public virtual Guid ClientId { get; set; }
        public virtual string Type { get; set; }
        public virtual string Value { get; set; }
    }
    public class ClientScopeWebDto
    {
        public virtual Guid ClientId { get; set; }
        public virtual string Scope { get; set; }
    }
    public class ClientSecretWebDto
    {
        public virtual Guid ClientId { get; set; }
        public virtual string Type { get; protected set; }
        public virtual string Value { get; set; }
        public virtual string Description { get; set; }
        public virtual DateTime? Expiration { get; set; }
    }

    public class ClientCreateUpdateWebDto
    {
        [DisplayOrder(0)]
        [DisplayName("客户端唯一Id")]
        public virtual string ClientId { get; set; }
        /// <summary>
        /// 是否启用
        /// </summary>
        [DisplayOrder(1)]
        [DisplayName("是否启用")]
        public virtual bool Enabled { get; set; }
        /// <summary>
        /// 客户端名称
        /// </summary>
        [DisplayOrder(2)]
        [DisplayName("客户端名称")]
        public virtual string ClientName { get; set; }
        /// <summary>
        /// 描述
        /// </summary>
        [DisplayOrder(3)]
        [DisplayName("客户端描述")]
        public virtual string Description { get; set; }

        [DisplayName("AccessToken有效时长")]
        public virtual int AccessTokenLifetime { get; set; }
        [DisplayName("IdentityToken有效时长")]
        public virtual int IdentityTokenLifetime { get; set; }

        //指定从令牌端点请求令牌时使用的客户机密码。
        public virtual List<ClientSecretWebDto> ClientSecrets { get; set; }
        //指定客户端可访问的资源。默认情况下，客户端无权访问任何资源。
        public virtual List<ClientScopeWebDto> AllowedScopes { get; set; }


        [DisplayName("客户端是否可以请求刷新令牌。")]
        public virtual bool AllowOfflineAccess { get; set; }
        public virtual bool BackChannelLogoutSessionRequired { get; set; }
        public virtual string BackChannelLogoutUri { get; set; }

        public virtual bool FrontChannelLogoutSessionRequired { get; set; }

        public virtual string FrontChannelLogoutUri { get; set; }
        /// <summary>
        /// Specifies whether this client is allowed to receive access tokens via the browser. This is useful to harden flows that allow multiple response types (e.g. by disallowing a hybrid flow client that is supposed to use code id_token to add the token response type and thus leaking the token to the browser.
        /// </summary>
        [DisplayName("允许通过浏览器获取access tokens")]
        public virtual bool AllowAccessTokensViaBrowser { get; set; }
        [DisplayName("允许客户端使用明文的PKCE Code challenge")]
        public virtual bool AllowPlainTextPkce { get; set; }
        [DisplayName("使用授权码的客户端必须发送证明密钥")]
        public virtual bool RequirePkce { get; set; }
        [DisplayName("请求Token时总包含Claim")]
        [Description("在请求id_token和access_token时总包含Claim，而不用userinfo端点获取")]
        public virtual bool AlwaysIncludeUserClaimsInIdToken { get; set; }
        [DisplayName("允许用户选择是否存储Concent中的决定")]
        public virtual bool AllowRememberConsent { get; set; } = true;
        [DisplayName("弹出Concent确认界面")]
        public virtual bool RequireConsent { get; set; }
        [DisplayName("客户端需要发送secret到token断点")]
        [Description("Specifies whether this client needs a secret to request tokens from the token endpoint (defaults to true)")]
        public virtual bool RequireClientSecret { get; set; }
        public virtual string ProtocolType { get; set; }
        [DisplayName("AuthorizationCode有效时长")]
        public virtual int AuthorizationCodeLifetime { get; set; } = 300;
        [DisplayName("用户Concent的过期时间。（默认永不过期）")]
        public virtual int? ConsentLifetime { get; set; }
        [DisplayName("refresh token absulute方式过期时间。默认30天")]
        public virtual int AbsoluteRefreshTokenLifetime { get; set; } = 2592000;
        [DisplayName("refresh token sliding方式 过期时间。默认15天")]
        public virtual int SlidingRefreshTokenLifetime { get; set; } = 1296000;
        public virtual List<ClientIdPRestrictionWebDto> IdentityProviderRestrictions { get; set; }
        //指定注销后重定向到的允许URI。
        public virtual List<ClientPostLogoutRedirectUriWebDto> PostLogoutRedirectUris { get; set; }
        //指定允许的URI返回令牌或授权码。
        public virtual List<ClientRedirectUriWebDto> RedirectUris { get; set; }
        //指定客户端的来源，以便IdentityServer可以允许来自原点的跨原点呼叫。
        public virtual List<ClientCorsOriginWebDto> AllowedCorsOrigins { get; set; }
        public virtual List<ClientGrantTypeWebDto> AllowedGrantTypes { get; set; }
        [DisplayName("Consent界面显示的客户端Logo")]
        public virtual string LogoUri { get; set; }
        [DisplayName("Salt value")]
        [Description("Salt value used in pair-wise subjectId generation for users of this client.")]
        public virtual string PairWiseSubjectSalt { get; set; }
        [DisplayName("在所有流程中始终发送Claims")]
        [Description("the client claims will be sent for every flow")]
        public virtual bool AlwaysSendClientClaims { get; set; }
        [DisplayName("JWT access tokens 包含唯一Id")]
        [Description("JWT access tokens should have an embedded unique ID")]
        public virtual bool IncludeJwtId { get; set; }
        [DisplayName("允许本地帐户")]
        [Description("Specifies if this client can use local accounts, or external IdPs only")]
        public virtual bool EnableLocalLogin { get; set; }
        [DisplayName("Access token类型")]
        [Description("access token 是否是reference token or a self contained JWT token")]
        public virtual int AccessTokenType { get; set; }
        [DisplayName("RefreshTokenExpiration过期方式")]
        [Description("Absolute 指定时间过期参照AbsoluteRefreshTokenLifetime,Sliding参考SlidingRefreshTokenLifetime重新创建过期时间")]
        public virtual int RefreshTokenExpiration { get; set; }
        [DisplayName("刷新token时更新Claims")]
        [Description("刷新token时，access_token和claims是否也更新")]
        public virtual bool UpdateAccessTokenClaimsOnRefresh { get; set; }
        [DisplayName("RefreshToken的使用方式")]
        [Description("ReUse还是用老token，OneTime 刷新token时候refreshtoken也更新")]
        public virtual int RefreshTokenUsage { get; set; }
        [DisplayName("ClientClaims前缀")]
        public virtual string ClientClaimsPrefix { get; set; }
        [DisplayName("用于显示客户端更加详细信息的Url")]
        public virtual string ClientUri { get; set; }

        public virtual List<ClientClaimWebDto> Claims { get; set; }
        //Dictionary to hold any custom client-specific values as needed.
        public virtual List<ClientPropertyWebDto> Properties { get; set; }

    }

    public class EditModalModel : IdentityServerPageModelBase
    {
        [HiddenInput]
        [BindProperty(SupportsGet = true)]
        public Guid Id { get; set; }

        [BindProperty]
        public ClientCreateUpdateWebDto ClientUpdateDto { get; set; }

        private readonly IClientAppService _clientAppService;

        public EditModalModel(IClientAppService clientAppService)
        {
            _clientAppService = clientAppService;
        }

        public async Task OnGetAsync()
        {
            var clientDto = await _clientAppService.GetAsync(Id);
            ClientUpdateDto = ObjectMapper.Map<ClientDto, ClientCreateUpdateWebDto>(clientDto);
        }

        
    }
}