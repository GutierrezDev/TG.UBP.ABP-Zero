using System.Data.Entity;
using System.Reflection;
using Abp.EntityFramework;
using Abp.Modules;
using TG.UBP.EntityFramework;

namespace TG.UBP
{
    [DependsOn(typeof(AbpEntityFrameworkModule), typeof(UBPCoreModule))]
    public class UBPDataModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.DefaultNameOrConnectionString = "Default";
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
            Database.SetInitializer<UBPDbContext>(null);
        }
    }
}
