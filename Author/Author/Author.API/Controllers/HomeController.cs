using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Threading;
using System.Threading.Tasks;
using Base.Commomet;
using Author.API.Models;
using Orleans;
using Orleans.Runtime.Configuration;
using Author.WriteContract.IFacade;
using Author.WriteContract.Dtos;
using Base.Expand;

namespace Author.API.Controllers
{
    public class HomeController : ApiController
    {
       
        public HomeController()
        {
            var config = ClientConfiguration.LocalhostSilo();
            GrainClient.Initialize(config);
        }
        public IHttpActionResult Index()
        {
            return Ok("<html><body>webapi成功启动  swagger调试页路径 <a href='/swagger/ui/index'>/swagger/ui/index</a><script>location.href='/swagger/ui/index';</script></body></html>");
        }

        // GET: api/Home
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Home/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Home
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Home/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Home/5
        public void Delete(int id)
        {
        }


        public async Task<WebApiResult> TestT([FromBody]  RoleRequest model)
        {
            if (model == null || !ModelState.IsValid)
            {
                return ModelState.toJsonError();
            }
            if (string.IsNullOrWhiteSpace(model.RoleName))
            {
                return new WebApiResult()
                {
                    Code = 1,
                    Message = "请求参数未携带RoleName"
                };
            }

            var userService = GrainClient.GrainFactory.GetGrain<IRoleFacades>(0);
            var _model = model.MapTo<RouleDto>();
            await userService.CreateRoule(_model);
            return new WebApiResult
            {
                Code = 0,
                Message = "Success"

            };
        }
    }
}
