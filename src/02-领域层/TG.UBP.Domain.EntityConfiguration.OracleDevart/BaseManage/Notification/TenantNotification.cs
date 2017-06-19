using Abp.Notifications;
using System;
using TG.UBP.EF;

namespace TG.UBP.Domain.EntityConfiguration.OracleDevart.BaseManage.Notification
{
    public class TenantNotificationConfiguration : EntityConfigurationBase<TenantNotificationInfo, Guid>
    {
        public TenantNotificationConfiguration()
        {
            Property(j => j.EntityTypeAssemblyQualifiedName)
                .HasColumnName("EntityTypeAssemblyQN");
            Property(j => j.Data)
                .HasMaxLength(4000);
        }
    }
}
