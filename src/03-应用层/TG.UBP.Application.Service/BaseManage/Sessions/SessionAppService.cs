using System.Threading.Tasks;
using Abp.Auditing;
using Abp.AutoMapper;
using TG.UBP.Application.Dto.BaseManage.Permission.Sessions;

namespace TG.UBP.Application.Service.BaseManage.Sessions
{
    public class SessionAppService : UbpAppServiceBase, ISessionAppService
    {
        [DisableAuditing]
        public async Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations()
        {
            var output = new GetCurrentLoginInformationsOutput();

            if (AbpSession.UserId.HasValue)
            {
                output.User = (await GetCurrentUserAsync()).MapTo<UserLoginInfoDto>();
            }

            if (AbpSession.TenantId.HasValue)
            {
                output.Tenant = (await GetCurrentTenantAsync()).MapTo<TenantLoginInfoDto>();
            }

            return output;
        }
    }
}