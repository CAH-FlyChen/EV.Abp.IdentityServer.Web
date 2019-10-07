using System;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Volo.Abp;

namespace EV.Abp.IdentityServer
{
    public class Startup
    {
        public IServiceProvider ConfigureServices(IServiceCollection services)
        {
            ////配置跨域处理，允许所有来源：
            //services.AddCors(options =>
            //    options.AddPolicy("自定义的跨域策略名称",
            //    p => p.AllowAnyOrigin())
            //);

            services.AddApplication<IdentityServerWebModule>(options =>
            {
                options.UseAutofac();
            });

            return services.BuildServiceProviderFromFactory();
        }

        public void Configure(IApplicationBuilder app, ILoggerFactory loggerFactory)
        {
            app.InitializeApplication();
        }
    }
}
