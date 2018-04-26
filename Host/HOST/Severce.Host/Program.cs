using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Severce.Host
{
    //==============================================================
    //  作者：三秋  (***@qq.com)
    //  时间：2018-4-10
    //  文件名：HOST
    //  版本：V1.0.1  
    //  说明： 服務端啓動
    //  修改者：***
    //  修改说明： 
    //==============================================================
    class Program
    {
      public static  string connection = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString.ToString();
        static void Main(string[] args)
        {
            #region 加載dll 配置文件
           // Author.Model.EntityFramework.DataContext dex = new Author.Model.EntityFramework.DataContext();
            
        #endregion


            #region Severce 啓動

            Console.Title = AppDomain.CurrentDomain.BaseDirectory + "\\OrleansHost";
            AppDomain hsotappDomain = AppDomain.CreateDomain("Host", null, new AppDomainSetup()
            {

                AppDomainInitializer = StartUp,
                AppDomainInitializerArguments = args
            });
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Orleans Silo is running.\nPress Enter to terminate...");

           

            Console.ReadLine();
            hsotappDomain.DoCallBack(ShutdownSilo);

            #endregion



        }

        static void StartUp(string[] args)
        {
            hostWrapper = new OrleansHostWrapper(args);
            if (!hostWrapper.Run)
            {
                Console.Error.WriteLine("Failed to initialize Orleans silo");
            }

        }

        static void ShutdownSilo()
        {
            if (hostWrapper != null)
            {
                hostWrapper.Dispose();
                GC.SuppressFinalize(hostWrapper);
            }
        }

        private static OrleansHostWrapper hostWrapper;
    }
}
