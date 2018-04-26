using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Web.Http;
using System.Web.Http.Cors;

namespace Author.API
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API 配置和服务
            config.AddApiVersioning(option =>
            {
                option.ReportApiVersions = true;
                option.AssumeDefaultVersionWhenUnspecified = true;
                option.DefaultApiVersion = new Microsoft.Web.Http.ApiVersion(1, 0);
            });
            // Web API 路由
            //config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "{controller}/{action}/{id}",
                defaults: new { controllers = "Home", action = "Index", id = RouteParameter.Optional }
            );
            //config.Routes.MapHttpRoute(
            //    name: "SwaggerApi",
            //    routeTemplate: "{controller}/{action}/{id}",
            //    defaults: new { controllers = "Default", action = "Index", id = RouteParameter.Optional }
            //    );

            //对参数类型为string的字段属性做Trim()处理
            //  config.BindParameter(typeof(string), new TrimModelBinder());
            //默认返回 json字符串
            GlobalConfiguration.Configuration.Formatters.XmlFormatter.SupportedMediaTypes.Clear();

            //解决IE下访问是下载文件的问题
            GlobalConfiguration.Configuration.Formatters.JsonFormatter.SupportedMediaTypes.Add(new MediaTypeHeaderValue("text/html"));

            // 对 JSON 数据使用混合大小写。驼峰式,但是是javascript 首字母小写形式.
            config.Formatters.JsonFormatter.SerializerSettings.ContractResolver = new CamelCasePropertyNamesContractResolver();

            //跨域
            var cors = new EnableCorsAttribute("*", "*", "*");
            cors.SupportsCredentials = true;
            config.EnableCors(cors);
            //ajax中加入 xhrFields: {withCredentials: true },

            //config.Filters.Add(new UserTrackingAttribute());

            //config.MessageHandlers.Add(new UrlParamsMessageHandler());
        }
    }
}
