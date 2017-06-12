using System.Reflection;
using Abp.Modules;

namespace TG.UBP
{
    [DependsOn(typeof(UBPCoreModule))]
    public class UBPApplicationModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}
