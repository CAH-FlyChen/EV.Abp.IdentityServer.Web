using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;
using Volo.Abp.IdentityServer.Clients;

namespace EV.Abp.IdentityServer
{
    public class TestAppService : AsyncCrudAppService<Client, ClientDto, Guid>, IClientAppService
    {
        public TestAppService(IRepository<Client, Guid> repository)
            : base(repository)
        {
        }
        public class inputdata
        {
            public int code { get; set; }
            public Dictionary<string,object> data { get; set; }
        }
        public async Task<inputdata> login(inputdata d)
        {
            d = new inputdata();
            d.code = 20000;
            d.data = new Dictionary<string, object>();
            d.data.Add("token", "admin-token");

            return await Task.FromResult(d);
        }

        public async Task<Dictionary<string,object>> getuserinfo(inputdata d)
        {
            var v = new Dictionary<string, object>();
            v.Add("roles",new string[] { "admin" });
            v.Add("introduction", "I am a super administrator");
            v.Add("avatar", "https://wpimg.wallstcn.com/f778738c-e4f8-4870-b634-56703b4acafe.gif");
            v.Add("name", "'Super Admin");

            var x = new Dictionary<string, object>();
            x.Add("code",20000);
            x.Add("data",v);

            return await Task.FromResult(x);
        }


}
}
