using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Exceptionless;
using log4net;
using log4net.Config;
using log4net.Repository;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using XmSoft.AspNetCore.Sample.Common;
using XmSoft.AspNetCore.Sample.Extensions;

namespace XmSoft.AspNetCore.Sample
{
    public class Startup
    {
        /// <summary>
        /// 
        /// </summary>
        public static ILoggerRepository repository { get; set; }
        public Startup(IConfiguration configuration)
        {
            repository = LogManager.CreateRepository("NetCoreRepository");
            System.IO.FileInfo fi = new System.IO.FileInfo("Config/log4net.config");
            XmlConfigurator.ConfigureAndWatch(repository, fi);
            ConfigurationHelper.InitConfigurationHelper(configuration);
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            //分布式日志
            ExceptionlessClient.Default.Configuration.ApiKey = Configuration.GetSection("Exceptionless:ApiKey").Value;
            ExceptionlessClient.Default.Configuration.ServerUrl = Configuration.GetSection("Exceptionless:ServerUrl").Value;
            services.SwaggerConfig(Configuration);
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            #region Swagger
            // 启用Swagger中间件
            app.UseSwagger();
            // 配置SwaggerUI
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "XmSoft.AspNetCore.WxApi");
                //c.RoutePrefix = string.Empty;

            });
            #endregion

            app.UseHttpsRedirection();
            app.UseMvc();
        }
    }
}
