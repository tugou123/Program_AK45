using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MES.Api.Controllers
{
    public class HomeController : ApiController
    {
        [HttpGet]
        [AllowAnonymous]
        public IHttpActionResult Index()
        {
            return Ok("<html><body>webapi成功启动  swagger调试页路径 <a href='/swagger/ui/index'>/swagger/ui/index</a><script>location.href='/swagger/ui/index';</script></body></html>");
        }
        // GET api/<controller>
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<controller>/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<controller>
        public void Post([FromBody]string value)
        {
        }

        // PUT api/<controller>/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
        }
    }
}