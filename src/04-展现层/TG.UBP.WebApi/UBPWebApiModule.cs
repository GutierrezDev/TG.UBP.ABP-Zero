using System.Reflection;
using Abp.Application.Services;
using Abp.Configuration.Startup;
using Abp.Modules;
using Abp.WebApi;
using TG.UBP.Application.Service;

namespace TG.UBP
{
    [DependsOn(typeof(AbpWebApiModule), typeof(UbpApplicationServiceModule))]
    public class UBPWebApiModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());

            Configuration.Modules.AbpWebApi().DynamicApiControllerBuilder
                .ForAll<IApplicationService>(typeof(UbpApplicationServiceModule).Assembly, "app")
                .Build();
        }
    }
}
