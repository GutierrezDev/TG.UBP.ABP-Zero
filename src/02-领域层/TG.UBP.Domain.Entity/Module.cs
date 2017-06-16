using Abp.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TG.UBP.Domain.Entity
{
    public class Module : FullAuditedEntity
    {
        #region 实体成员
        /// <summary>
        /// 父级主键
        /// </summary>
        public int ParentId { set; get; }
        /// <summary>
        /// 编号
        /// </summary>
        [StringLength(10)]
        public string EnCode { set; get; }
        /// <summary>
        /// 名称
        /// </summary>
        [StringLength(50)]
        public string FullName { set; get; }
        #endregion
    }
}
