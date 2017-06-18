using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using TG.UBP.Domain.Entity.BaseManage.Permission;

namespace TG.UBP.Application.Dto.BaseManage.Permission.Sessions
{
    [AutoMapFrom(typeof(User))]
    public class UserLoginInfoDto : EntityDto<long>
    {
        public string Name { get; set; }

        public string Surname { get; set; }

        public string UserName { get; set; }

        public string EmailAddress { get; set; }
    }
}
