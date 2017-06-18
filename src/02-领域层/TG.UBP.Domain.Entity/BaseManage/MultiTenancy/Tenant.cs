using Abp.MultiTenancy;
using TG.UBP.Domain.Entity.BaseManage.Permission;

namespace TG.UBP.Domain.Entity.BaseManage.MultiTenancy
{
    public class Tenant : AbpTenant<User>
    {
        public Tenant()
        {
            
        }

        public Tenant(string tenancyName, string name)
            : base(tenancyName, name)
        {
        }
    }
}