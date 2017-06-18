using System;
using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using TG.UBP.Domain.Entity.BaseManage.Permission;

namespace TG.UBP.Application.Dto.BaseManage.Permission.Users
{
    [AutoMapFrom(typeof(User))]
    public class UserListDto : EntityDto<long>
    {
        public string Name { get; set; }

        public string Surname { get; set; }

        public string UserName { get; set; }

        public string FullName { get; set; }

        public string EmailAddress { get; set; }

        public bool IsEmailConfirmed { get; set; }

        public DateTime? LastLoginTime { get; set; }

        public bool IsActive { get; set; }

        public DateTime CreationTime { get; set; }
    }
}