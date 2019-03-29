using Volo.Abp;

namespace EV.Abp.IdentityServer
{
    public abstract class IdentityServerApplicationTestBase : AbpIntegratedTest<IdentityServerApplicationTestModule>
    {
        protected override void SetAbpApplicationCreationOptions(AbpApplicationCreationOptions options)
        {
            options.UseAutofac();
        }
    }
}
