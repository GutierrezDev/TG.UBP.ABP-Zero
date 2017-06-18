using System.Threading.Tasks;
using Abp.Application.Services;
using TG.UBP.Application.Dto.BaseManage.Permission.Roles;

namespace TG.UBP.Application.Service.BaseManage.Permission.Roles
{
    public interface IRoleAppService : IApplicationService
    {
        Task UpdateRolePermissions(UpdateRolePermissionsInput input);
    }
}
