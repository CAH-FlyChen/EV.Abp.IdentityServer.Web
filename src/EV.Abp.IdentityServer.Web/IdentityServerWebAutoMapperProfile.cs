using AutoMapper;
using Volo.Abp.IdentityServer.Clients;

namespace EV.Abp.IdentityServer
{
    public class IdentityServerWebAutoMapperProfile : Profile
    {
        public IdentityServerWebAutoMapperProfile()
        {
            //Configure your AutoMapper mapping configuration here...
            //CreateMap<Client, ClientDto>()
            //.ForMember(
            //   dst => dst.Enabled,
            //   opts =>
            //   {
            //       opts.SetMappingOrder(0);
            //   })
            //.ForAllOtherMembers(t => t.SetMappingOrder(99));
            
        }
    }
}
