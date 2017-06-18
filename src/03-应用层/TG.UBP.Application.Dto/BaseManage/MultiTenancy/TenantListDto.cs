using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using TG.UBP.Domain.Entity.BaseManage.MultiTenancy;
using TG.UBP.Domain.Entity.BaseManage.Permission;

namespace TG.UBP.Application.Dto.BaseManage.MultiTenancy
{
    [AutoMapFrom(typeof(Tenant))]
    public class TenantListDto : EntityDto
    {
        public string TenancyName { get; set; }

        public string Name { get; set; }
    }
}