using System.Reflection;
using Abp.Modules;
using TG.UBP.Domain.Core;
using Abp.AutoMapper;

namespace TG.UBP.Application.Service
{
    [DependsOn(typeof(UbpDomainCoreModule), typeof(AbpAutoMapperModule))]
    public class UbpApplicationServiceModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Modules.AbpAutoMapper().Configurators.Add(mapper =>
            {
                //Add your custom AutoMapper mappings here...
                //mapper.CreateMap<,>()
            });
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}
