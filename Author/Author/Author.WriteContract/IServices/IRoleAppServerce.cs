using Author.WriteContract.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Author.WriteContract.IServices
{
   public  interface IRoleAppServerce
    {
        /// <summary>
        /// 創建角色
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        Task CreateRoule(RouleDto model);
        /// <summary>
        /// 編輯角色
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        Task UpdateRoule(RouleDto model);
        /// <summary>
        /// 刪除角色
        /// </summary>
        /// <param name="id">橘色Id</param>
        /// <param name="carrId">操作人Id</param>
        /// <returns></returns>
        Task DeleteRoule(long id, long carrId);
        /// <summary>
        /// 启用/禁用 
        /// </summary>
        /// <param name="id"></param>
        /// <param name="carrId"></param>
        /// <returns></returns>
        Task IsActive(long id, long carrId, bool trg = true);
    }
}
