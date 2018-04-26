using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Author.Model
{
    //==============================================================
    //  作者：三秋  (***@qq.com)
    //  时间：2018/4/10 11:31:21
    //  文件名：UserRoleInfo
    //  版本：V1.0.1  
    //  说明： 
    //  修改者：***
    //  修改说明： 
    //==============================================================
    [Table("UserRoles")]
   public class UserRoleInfo:BaseMode
    {
        [Display(Name = "用户角色名称")]
        public string RoleName { set; get; }
        /// <summary>
        /// 是否启用
        /// </summary>
        [Display(Name = "是否启用")]

        public bool IsActive { set; get; }
        /// <summary>
        /// 是否删除
        /// </summary>
        [Display(Name = "是否删除")]
        public bool IsDelete { set; get; }
    }
}
