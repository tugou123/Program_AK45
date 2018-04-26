using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Severce.Host
{
    //==============================================================
    //  作者：***  (***@qq.com)
    //  时间：2018/4/13 16:18:47
    //  文件名：Test
    //  版本：V1.0.1  
    //  说明： 
    //  修改者：***
    //  修改说明： 
    //==============================================================
  public  class Test: ITest
    {
        private Author.Model.EntityFramework.DataContext _entity;
        public Test(Author.Model.EntityFramework.DataContext entity)
        {
            _entity = entity;
        }


        public void Tesdem()
        {
            _entity.UserRoles.Add(new Author.Model.UserRoleInfo() { CreateTime = DateTime.Now, IsActive = true, IsDelete = false, RoleName = "测试" });
            _entity.SaveChanges();
        }
    }



 public interface ITest
    {
        void Tesdem();
    }
}
