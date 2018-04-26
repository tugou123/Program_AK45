using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Base.Commomet
{
    public class WebApiResult<T> : WebApiResult
    {
       
        public  T Data { set; get; }
       
    }

    public class WebApiResult
    {
        public int Code { set; get; }

        public string Message { set; get; }


        public dynamic _other { get; set; }
    }

   
}
