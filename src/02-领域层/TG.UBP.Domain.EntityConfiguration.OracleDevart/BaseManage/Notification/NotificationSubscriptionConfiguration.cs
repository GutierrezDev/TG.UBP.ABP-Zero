using Abp.Notifications;
using System;
using TG.UBP.EF;

namespace TG.UBP.Domain.EntityConfiguration.OracleDevart.BaseManage.Notification
{
    public class NotificationSubscriptionConfiguration : EntityConfigurationBase<NotificationSubscriptionInfo, Guid>
    {
        public NotificationSubscriptionConfiguration()
        {
            Property(j => j.EntityTypeAssemblyQualifiedName)
                .HasColumnName("EntityTypeAssemblyQN");
        }
    }
}
