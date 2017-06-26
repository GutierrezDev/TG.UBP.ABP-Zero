using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TG.UBP.Domain.Entity;
using TG.UBP.Domain.Entity.BaseManage.Permission;
using TG.UBP.EF;

namespace TG.UBP.Domain.EntityConfiguration.OracleDevart
{
    public class UserConfiguration : EntityConfigurationBase<User, long>
    {
        public UserConfiguration()
        {
            //this.ToTable("BASE_USERS");
            //this.Property(p => p.Id).HasColumnName("USER_ID");
            //this.Property(p => p.Surname).IsOptional();
            //this.Property(p => p.AccessFailedCount).IsOptional();
            //this.Property(p => p.IsLockoutEnabled).IsOptional();
            //this.Property(p => p.IsPhoneNumberConfirmed).IsOptional();
            //this.Property(p => p.IsTwoFactorEnabled).IsOptional();
            //this.Property(p => p.IsEmailConfirmed).IsOptional();

            //this.HasMany(m => m.Children).WithOptional(n => n.Parent);
        }
    }
}
