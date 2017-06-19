using Abp.BackgroundJobs;
using TG.UBP.EF;

namespace TG.UBP.Domain.EntityConfiguration.OracleDevart.BaseManage.BackgroundJob
{
    public class BackgroundJobConfiguration : EntityConfigurationBase<BackgroundJobInfo, long>
    {
        public BackgroundJobConfiguration()
        {
            Property(j => j.JobArgs)
                .HasMaxLength(4000);
        }
    }
}
