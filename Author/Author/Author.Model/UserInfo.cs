using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Author.Model
{
    //==============================================================
    //  作者：三秋  (1172145574@qq.com)
    //  时间：2018/4/10 11:07:31
    //  文件名：UserInfo
    //  版本：V1.0.1  
    //  说明： 用戶表
    //  修改者：***
    //  修改说明： 
    //==============================================================
    [Table("Users")]
  public  class UserInfo: BaseMode
    {
        /// <summary>
        /// 角色Id
        /// </summary>
      
        [Display(Name = "角色Id")]
        public long UserRoleId { set; get; }
        [Display(Name = "用户编码")]
        public string UserCode { set; get; }
       
        /// <summary>
        /// 用戶名
        /// </summary>
        [Display(Name ="用戶名")]
        public string UserName { set; get; }
        /// <summary>
        /// 密碼
        /// </summary>
        [Display(Name = "密碼")]
        public string Pwd { set; get; }
        /// <summary>
        /// 聯係電話
        /// </summary>
        [Display(Name = "聯係電話")]
        public string Phone { set; get; }
        /// <summary>
        /// 郵箱
        /// </summary>
        [Display(Name = "郵箱")]
        public string Mail { set; get; }

        /// <summary>
        /// 頭像
        /// </summary>
        [Display(Name = "頭像")]
        public string ImageHeadPortrait { set; get; }
        /// <summary>
        /// 身份證正面圖
        /// </summary>
        [Display(Name = "身份證正面圖")]
        public string ImageFacadeIDcard { set; get; }
        /// <summary>
        /// 身份证背面
        /// </summary>
        [Display(Name = "身份證反面圖")]
        public string ImageBackIDcard { set; get; }

        /// <summary>
        /// 创建人Id
        /// </summary>
        [Display(Name = "创建人Id")]
        public long? CreateUserId { set; get; }

        /// <summary>
        /// 是否删除
        /// </summary>
        [Display(Name = "是否删除")]
        public bool IsDelete { set; get; }
        /// <summary>
        /// 删除操作人Id
        /// </summary>
        [Display(Name = "删除操作人Id")]
        public long? DeleteUserId { set; get; }
        /// <summary>
        /// 是否启用
        /// </summary>
        [Display(Name = "是否启用")]
        public bool IsActive { set; get; }

        /// <summary>
        /// 登陆次数
        /// </summary>
        [Display(Name = "登陆次数")]
        public int LoginCount { set; get; }
        /// <summary>
        /// 最后登陆时间
        /// </summary>
        [Display(Name = "最后登陆时间")]
        public DateTime? LastLoginTime { set; get; }

    }
}
