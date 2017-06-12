using System.Reflection;
using Abp.Modules;

namespace TG.UBP
{
    public class UBPCoreModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}
