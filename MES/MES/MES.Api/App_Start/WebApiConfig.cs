using Microsoft.Web.Http;
using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Web.Http;
using System.Web.Http.Cors;
using System.Web.Http.Routing;

namespace MES.Api
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API 配置和服务

            // Web API 路由
            //  config.MapHttpAttributeRoutes();
            config.AddApiVersioning(option =>
            {
                option.ReportApiVersions = true;
                option.AssumeDefaultVersionWhenUnspecified = true;
                option.DefaultApiVersion = new ApiVersion(1, 0);
            });

            //var constraintResolver = new DefaultInlineConstraintResolver
            //{
            //    ConstraintMap = {
            //        ["apiVersion"]=typeof(ApiVersionRouteConstraint)
            //    },
            //};
            // Web API routes
           // config.MapHttpAttributeRoutes(constraintResolver);

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = RouteParameter.Optional }
            );

            //默认返回 json字符串
            GlobalConfiguration.Configuration.Formatters.XmlFormatter.SupportedMediaTypes.Clear();

            //解决IE下访问是下载文件的问题
            GlobalConfiguration.Configuration.Formatters.JsonFormatter.SupportedMediaTypes.Add(new MediaTypeHeaderValue("text/html"));

            //跨域
            var cors = new EnableCorsAttribute("*", "*", "*");
            //var cors = new EnableCorsAttribute("http://api.config.wcws.com" ?? "*", "Content-Type, Accept" ?? "*", "GET, POST, PUT, PATCH, DELETE, OPTIONS" ?? "*");
            cors.SupportsCredentials = true;
            config.EnableCors(cors);
            //ajax中加入 xhrFields: {withCredentials: true },  

            // 解决json序列化时的循环引用问题
            config.Formatters.JsonFormatter.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore;
            // 对 JSON 数据使用混合大小写。驼峰式,但是是javascript 首字母小写形式.
            config.Formatters.JsonFormatter.SerializerSettings.ContractResolver = new CamelCasePropertyNamesContractResolver();


            //config.Filters.Add(new UserTrackingAttribute());

            //config.MessageHandlers.Add(new UrlParamsMessageHandler());

            //config.Routes.MapHttpRoute(
            //    name: "DefaultApi",
            //    routeTemplate: "v1/{controller}/{Index}/{id}",
            //    defaults: new { controllers= "Home",action="Index", id = RouteParameter.Optional }
            //);

            //config.Routes.MapHttpRoute(
            //   name: "SwaggerApi",
            //   routeTemplate: "{controller}/{Index}/{id}",
            //   defaults: new { controllers = "Home", action = "Index", id = RouteParameter.Optional }
            //   );

            //   // 使api返回为json 
            //   GlobalConfiguration.Configuration.Formatters.XmlFormatter.SupportedMediaTypes.Clear();
            //  config.EnableCors(new EnableCorsAttribute("*", "*", "*"));
        }
    }
}
