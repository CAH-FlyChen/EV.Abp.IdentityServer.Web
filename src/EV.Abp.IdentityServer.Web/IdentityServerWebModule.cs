﻿using System.IO;
using System.Linq;
using Localization.Resources.AbpUi;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
//using EV.Abp.IdentityServer.EntityFrameworkCore;
//using EV.Abp.IdentityServer.Localization.IdentityServer;
using EV.Abp.IdentityServer.Menus;
using EV.Abp.IdentityServer.Permissions;
using Swashbuckle.AspNetCore.Swagger;
using Volo.Abp;
using Volo.Abp.Account.Web;
using Volo.Abp.AspNetCore.Mvc;
using Volo.Abp.AspNetCore.Mvc.Localization;
using Volo.Abp.AspNetCore.Mvc.UI;
using Volo.Abp.AspNetCore.Mvc.UI.Bootstrap;
using Volo.Abp.AspNetCore.Mvc.UI.Theme.Basic;
using Volo.Abp.AspNetCore.Mvc.UI.Theme.Shared;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Autofac;
using Volo.Abp.AutoMapper;
using Volo.Abp.Identity;
using Volo.Abp.Identity.Web;
using Volo.Abp.Localization;
using Volo.Abp.Localization.Resources.AbpValidation;
using Volo.Abp.Modularity;
using Volo.Abp.PermissionManagement.Web;
using Volo.Abp.Threading;
using Volo.Abp.UI;
using Volo.Abp.UI.Navigation;
using Volo.Abp.VirtualFileSystem;
using Volo.Abp.PermissionManagement;
using Volo.Abp.EntityFrameworkCore;
using Volo.Abp.IdentityServer.EntityFrameworkCore;

namespace EV.Abp.IdentityServer
{
    [DependsOn(
        typeof(IdentityServerApplicationModule),
        typeof(AbpIdentityServerEntityFrameworkCoreModule),
        typeof(AbpAutofacModule),
        typeof(AbpIdentityWebModule),
        typeof(AbpAccountWebModule),
        typeof(AbpAspNetCoreMvcUiBasicThemeModule)
        )]
    public class IdentityServerWebModule : AbpModule
    {
        public override void PreConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddCors(options => options.AddPolicy("cors",
            builder => builder.WithOrigins("http://localhost:9527", "http://c.example.com")
            .AllowAnyMethod().AllowAnyHeader().AllowAnyOrigin().AllowCredentials()));

            context.Services.PreConfigure<AbpMvcDataAnnotationsLocalizationOptions>(options =>
            {
                //options.AddAssemblyResource(
                //    typeof(IdentityServerResource),
                //    typeof(IdentityServerDomainModule).Assembly,
                //    typeof(IdentityServerApplicationModule).Assembly,
                //    typeof(IdentityServerWebModule).Assembly
                //);
            });
        }

        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            var hostingEnvironment = context.Services.GetHostingEnvironment();
            var configuration = context.Services.GetConfiguration();

            ConfigureDatabaseServices();
            ConfigureAutoMapper();
            ConfigureVirtualFileSystem(hostingEnvironment);
            ConfigureLocalizationServices();
            ConfigureNavigationServices();
            ConfigureAutoApiControllers();
            ConfigureSwaggerServices(context.Services);
        }

        private void ConfigureDatabaseServices()
        {
            Configure<AbpDbContextOptions>(options =>
            {
                options.UseMySQL();
            });
        }

        private void ConfigureAutoMapper()
        {
            Configure<AbpAutoMapperOptions>(options =>
            {
                options.AddProfile<IdentityServerWebAutoMapperProfile>();
            });
        }

        private void ConfigureVirtualFileSystem(IHostingEnvironment hostingEnvironment)
        {
            if (hostingEnvironment.IsDevelopment())
            {
                //Configure<VirtualFileSystemOptions>(options =>
                //{
                //    options.FileSets.ReplaceEmbeddedByPhysical<IdentityServerDomainModule>(Path.Combine(hostingEnvironment.ContentRootPath, string.Format("..{0}EV.Abp.IdentityServer.Domain", Path.DirectorySeparatorChar)));
                //});
            }
        }

        private void ConfigureLocalizationServices()
        {
            Configure<AbpLocalizationOptions>(options =>
            {
                //options.Resources
                //    .Get<IdentityServerResource>()
                //    .AddBaseTypes(
                //        typeof(AbpValidationResource),
                //        typeof(AbpUiResource)
                //    );

                options.Languages.Add(new LanguageInfo("en", "en", "English"));
                options.Languages.Add(new LanguageInfo("pt-BR", "pt-BR", "Português"));
                options.Languages.Add(new LanguageInfo("tr", "tr", "Türkçe"));
                options.Languages.Add(new LanguageInfo("zh-Hans", "zh-Hans", "简体中文"));
            });
        }

        private void ConfigureNavigationServices()
        {
            Configure<NavigationOptions>(options =>
            {
                options.MenuContributors.Add(new IdentityServerMenuContributor());
            });
        }

        private void ConfigureAutoApiControllers()
        {
            Configure<AbpAspNetCoreMvcOptions>(options =>
            {
                options.ConventionalControllers.Create(typeof(IdentityServerApplicationModule).Assembly);
            });
        }

        private void ConfigureSwaggerServices(IServiceCollection services)
        {
            services.AddSwaggerGen(
                options =>
                {
                    options.SwaggerDoc("v1", new Info { Title = "IdentityServer API", Version = "v1" });
                    options.DocInclusionPredicate((docName, description) => true);
                    options.CustomSchemaIds(type => type.FullName);
                });
        }

        public override void OnApplicationInitialization(ApplicationInitializationContext context)
        {
            var app = context.GetApplicationBuilder();
            var env = context.GetEnvironment();

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseErrorPage();
            }

            app.UseVirtualFiles();
            app.UseAuthentication();
            app.UseAbpRequestLocalization();

            app.UseSwagger();
            app.UseSwaggerUI(options =>
            {
                options.SwaggerEndpoint("/swagger/v1/swagger.json", "IdentityServer API");
            });

            app.UseAuditing();

            app.UseCors("cors");

            app.UseMvcWithDefaultRouteAndArea();

            SeedDatabase(context);
        }

        private static void SeedDatabase(ApplicationInitializationContext context)
        {
            //using (var scope = context.ServiceProvider.CreateScope())
            //{
            //    AsyncHelper.RunSync(async () =>
            //    {
            //        var identitySeedResult = await scope.ServiceProvider
            //            .GetRequiredService<IIdentityDataSeeder>()
            //            .SeedAsync(
            //                "1q2w3E*"
            //            );

            //        if (identitySeedResult.CreatedAdminRole)
            //        {
            //            await scope.ServiceProvider
            //                .GetRequiredService<IPermissionDataSeeder>()
            //                .SeedAsync(
            //                    RolePermissionValueProvider.ProviderName,
            //                    "admin",
            //                    IdentityPermissions.GetAll().Union(IdentityServerPermissions.GetAll())
            //                );
            //        }
            //    });
            //}
        }
    }
}
