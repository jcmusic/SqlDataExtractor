using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YuStashSageX3_ETL;

namespace YuStashSageX3_ETL
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region

            //// create hosting object and DI layer
            //using IHost host = CreateHostBuilder(args).Build();

            //// create a service scope
            //using var scope = host.Services.CreateScope();

            //var services = scope.ServiceProvider;


            //// add entry point or call service methods
            //// more .....


            //// implementatinon of 'CreateHostBuilder' static method and create host object
            //IHostBuilder CreateHostBuilder(string[] strings)
            //{
            //    return Host.CreateDefaultBuilder()
            //        .ConfigureServices((_, services) =>
            //        {
            //            services.AddSingleton<ICustomerService, CustomerService>();
            //            services.AddSingleton<App>();
            //        });
            //}

            #endregion

            IDataExtractor extractor = new DataExtractor();

            extractor.ExtractDataAndUploadCsv();

            Console.ReadLine();
        }
    }
}
