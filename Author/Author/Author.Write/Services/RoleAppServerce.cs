using Author.WriteContract.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Author.WriteContract.Dtos;
using Author.Model.EntityFramework;
using Base.Expand;
using Author.Model;

namespace Author.Write.Services
{
    //==============================================================
    //  作者：三秋  (***@qq.com)
    //  时间：2018/4/13 11:14:01
    //  文件名：RoleAppServerce
    //  版本：V1.0.1  
    //  说明： 
    //  修改者：***
    //  修改说明： 
    //==============================================================
    public class RoleAppServerce : IRoleAppServerce
    {
        private DataContext _entity;
       public RoleAppServerce(DataContext entity)
        {
            _entity = entity;
        }
        /// <summary>
        /// 创建新角色
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public async Task CreateRoule(RouleDto model)
        {
            var _roleinfo = model.MapTo<UserRoleInfo>();
            _roleinfo.IsDelete = false;
            _roleinfo.IsActive = true;
            _roleinfo.CreateTime = DateTime.Now;
            _entity.UserRoles.Add(_roleinfo);
            await _entity.SaveChangesAsync();
        }
        /// <summary>
        /// 删除角色
        /// </summary>
        /// <param name="id">角色ID</param>
        /// <param name="carrId">操作人Id</param>
        /// <returns></returns>
        public async Task DeleteRoule(long id, long carrId)
        {
         var _roleinfo=  _entity.UserRoles.Where(n => n.Id == id).FirstOrDefault();
            if (_roleinfo == null)
                throw new Exception("删除失败！不存在该角色相关的信息");
            _roleinfo.IsActive = false;
            _roleinfo.IsDelete = true;
           await _entity.SaveChangesAsync();
        }

        public void Dispose()
        {
           
        }
        /// <summary>
        /// 启用/禁用
        /// </summary>
        /// <param name="id">角色Id</param>
        /// <param name="carrId">操作人Id</param>
        /// <param name="trg">true:启用/false:禁用</param>
        /// <returns></returns>
        public async Task IsActive(long id, long carrId, bool trg = true)
        {
            var _roleinfo = _entity.UserRoles.Where(n => n.Id == id).FirstOrDefault();
            if (_roleinfo == null)
                throw new Exception("操作失败！不存在该角色相关的信息");
            if (_roleinfo.IsDelete == true)
            {
                throw new Exception("不存在该角色相关的信息");
            }
            if (trg)
            {
                if (!_roleinfo.IsActive)
                    _roleinfo.IsActive = true;
            }
            else
            {
                if (_roleinfo.IsActive)
                    _roleinfo.IsActive = false;
            }
            await _entity.SaveChangesAsync();
        }
        /// <summary>
        /// 更新 角色信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public async Task UpdateRoule(RouleDto model)
        {
            var _roleinfo = _entity.UserRoles.Where(n => n.Id == model.Id).FirstOrDefault();

            if (_roleinfo == null)
                throw new Exception("更新失败！不存在该角色相关的信息");
            _roleinfo.IsActive = model.IsActive;
            _roleinfo.RoleName = model.RoleName;
            await _entity.SaveChangesAsync();
        }
    }
}
