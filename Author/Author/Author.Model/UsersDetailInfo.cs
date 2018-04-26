using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Author.Model;

namespace Author.Model
{
    //==============================================================
    //  作者：三秋  (1172144574@qq.com)
    //  时间：2018/4/10 11:26:32
    //  文件名：UsersDetailInfo
    //  版本：V1.0.1  
    //  说明： 
    //  修改者：***
    //  修改说明： 
    //==============================================================
    [Table("UsersDetails")]
    public  class UsersDetailInfo:BaseMode
    {
        /// <summary>
        /// 登陆IP地址
        /// </summary>
        [Display(Name = "IP地址")]
        public string IP { set; get; }
        /// <summary>
        /// 主机名称
        /// </summary>
        [Display(Name = "主机名称")]
        public string HostName { set; get; }
        /// <summary>
        /// 最后登陆时间
        /// </summary>
        [Display(Name = "最后登陆时间")]
        public DateTime? LastLoginTime { set; get; }
        /// <summary>
        /// 开始登陆时间
        /// </summary>
        [Display(Name = "开始登陆时间")]
        public DateTime? StartlandingTime { set; get; }

        /// <summary>
        /// UserId
        /// </summary>
        public long UsersInfoId { set; get; }

        public virtual UserInfo UsersInfo { set; get; }
    }
}
