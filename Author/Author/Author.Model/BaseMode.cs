using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Author.Model
{
    //==============================================================
    //  作者：三秋  (1172145574@qq.com)
    //  时间：2018/4/10 11:29:21
    //  文件名：BaseMode
    //  版本：V1.0.1  
    //  说明： 
    //  修改者：***
    //  修改说明： 
    //==============================================================
  public  class BaseMode
    {
        /// <summary>
        /// Id 
        /// </summary>
        [Key]
        [Display(Name = "ID")]
        public long Id { set; get; }
        /// <summary>
        /// 创建时间
        /// </summary>
        [Display(Name = "创建时间")]
        public DateTime? CreateTime { set; get; }
    }
}
