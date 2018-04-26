using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Author.WriteContract.Dtos
{
    //==============================================================
    //  作者：三秋  (***@qq.com)
    //  时间：2018/4/13 10:29:21
    //  文件名：RouleDto
    //  版本：V1.0.1  
    //  说明： 
    //  修改者：***
    //  修改说明： 
    //==============================================================
   public  class RouleDto:IModel
    {
        /// <summary>
        /// 用户角色名称
        /// </summary>
        public string RoleName { set; get; }
        /// <summary>
        /// 是否启用
        /// </summary>  
        public bool IsActive { set; get; }
        /// <summary>
        /// 是否删除
        /// </summary>
        public bool IsDelete { set; get; }
    }
}
