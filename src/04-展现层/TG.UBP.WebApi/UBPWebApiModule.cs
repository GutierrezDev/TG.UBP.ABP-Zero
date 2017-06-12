using System.Reflection;
using Abp.Application.Services;
using Abp.Configuration.Startup;
using Abp.Modules;
using Abp.WebApi;

namespace TG.UBP
{
    [DependsOn(typeof(AbpWebApiModule), typeof(UBPApplicationModule))]
    public class UBPWebApiModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());

            Configuration.Modules.AbpWebApi().DynamicApiControllerBuilder
                .ForAll<IApplicationService>(typeof(UBPApplicationModule).Assembly, "app")
                .Build();
        }
    }
}
