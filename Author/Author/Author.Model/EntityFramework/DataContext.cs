using Author.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Author.Model.EntityFramework
{
    //==============================================================
    //  作者：三秋  (@qq.com)
    //  时间：2018/4/10 11:46:42
    //  文件名：DataContext
    //  版本：V1.0.1  
    //  说明： 
    //  修改者：***
    //  修改说明： 
    //==============================================================
    public class DataContext :DbContext
    {
        public DataContext(DbContextOptions<DataContext> options)
            : base(options)
        {
        }

        public virtual DbSet<UserInfo> Users { get; set; }
        public virtual DbSet<UserRoleInfo> UserRoles { get; set; }
        public virtual DbSet<UsersDetailInfo> UsersDetails { get; set; }
    }
}
