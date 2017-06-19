﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abp.Notifications;
using TG.UBP.EF;

namespace TG.UBP.Domain.EntityConfiguration.OracleDevart.BaseManage.Notification
{
    public class NotificationConfiguration : EntityConfigurationBase<NotificationInfo, Guid>
    {
        public NotificationConfiguration()
        {
            Property(j => j.EntityTypeAssemblyQualifiedName)
                .HasColumnName("EntityTypeAssemblyQN");
            Property(j => j.Data)
                .HasMaxLength(4000);
            Property(j => j.UserIds)
                .HasMaxLength(4000);
            Property(j => j.ExcludedUserIds)
                .HasMaxLength(4000);
            Property(j => j.TenantIds)
                .HasMaxLength(4000);
        }
    }
}
