using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Orleans;
using Author.WriteContract.IFacade;
using Author.WriteContract.Dtos;
using Author.WriteContract.IServices;

namespace Author.Write.Facade
{
    //==============================================================
    //  作者：三秋  (***@qq.com)
    //  时间：2018/4/13 11:04:52
    //  文件名：RoleFacades
    //  版本：V1.0.1  
    //  说明： 
    //  修改者：***
    //  修改说明： 
    //==============================================================
    public class RoleFacades : Grain, IRoleFacades
    {
      private readonly  IRoleAppServerce _iroleappserverce;
        /// <summary>
        /// 依赖注入
        /// </summary>
        public RoleFacades(IRoleAppServerce iroleappserverce)
        {
            _iroleappserverce = iroleappserverce;
        }
        /// <summary>
        /// 创建角色
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public async Task CreateRoule(RouleDto model)
        {
            IsValidate(model);
        
            await _iroleappserverce.CreateRoule(model);
        }
        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="id">角色Id</param>
        /// <param name="carrId">操作人Id</param>
        /// <returns></returns>
        public async Task DeleteRoule(long id, long carrId)
        {
            if (id <= 0)
                throw new Exception("角色Id不存在");
          await  _iroleappserverce.DeleteRoule(id, carrId);
        }
        /// <summary>
        ///激活角色
        /// </summary>
        /// <param name="id">角色Id</param>
        /// <param name="carrId">操作人Id</param>
        /// <param name="trg">true:激活/fasle:禁用</param>
        /// <returns></returns>
        public async Task IsActive(long id, long carrId, bool trg = true)
        {
            if (id <= 0)
                throw new Exception("角色Id不存在");
            await _iroleappserverce.IsActive(id, carrId, trg);
        }
        /// <summary>
        /// 更新角色
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public async Task UpdateRoule(RouleDto model)
        {
            IsValidate(model);
            await _iroleappserverce.UpdateRoule(model);
        }
        /// <summary>
        /// 验证
        /// </summary>
        /// <param name="model"></param>
        public void IsValidate(RouleDto model)
        {
            if (model == null)
                throw new Exception("角色信息不存在");
            if(model.Id<=0)
                throw new Exception("角色信息ID不存在");
            if(string.IsNullOrWhiteSpace(model.RoleName))
                throw new Exception("角色信息名称不存在");
        }
    }
}
