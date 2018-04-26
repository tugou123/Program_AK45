using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Author.WriteContract.Dtos
{
    //==============================================================
    //  作者：三秋  (***@qq.com)
    //  时间：2018/4/13 10:30:21
    //  文件名：IModel
    //  版本：V1.0.1  
    //  说明： 
    //  修改者：***
    //  修改说明： 
    //==============================================================
   public class IModel
    {
        /// <summary>
        /// Id 
        /// </summary>
        public long Id { set; get; }
        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime? CreateTime { set; get; }
    }
}
