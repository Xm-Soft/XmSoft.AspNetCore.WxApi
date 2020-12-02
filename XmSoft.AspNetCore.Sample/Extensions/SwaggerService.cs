using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.OpenApi.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace XmSoft.AspNetCore.Sample.Extensions
{
    /// <summary>
    /// Swagger配置
    /// </summary>
    public static class SwaggerService
    {
        /// <summary>
        /// Swagger配置
        /// </summary>
        /// <param name="services"></param>
        /// <param name="configuration"></param>
        public static void SwaggerConfig(this IServiceCollection services, IConfiguration configuration)
        {
            var path = System.AppDomain.CurrentDomain.BaseDirectory;
            //var commentsFile = Path.Combine(path, @"XmSoft.AspNetCore.WxApi.xml");
            // 注册Swagger服务
            services.AddSwaggerGen(c =>
            {
                // 添加文档信息
                c.SwaggerDoc("v1", new Microsoft.OpenApi.Models.OpenApiInfo { Title = "ZYL.Core.Api", Version = "v1" });
                c.ResolveConflictingActions(apiDescriptions => apiDescriptions.First());

                c.AddSecurityDefinition("oauth2", new OpenApiSecurityScheme
                {
                    Description = "JWT授权(数据将在请求头中进行传递)直接在下面框中输入Bearer {token}(注意两者之间是一个空格) \"",
                    Name = "Authorization",//jwt默认的参数名称
                    In = ParameterLocation.Header,//jwt默认存放Authorization信息的位置(请求头中)
                    Type = SecuritySchemeType.ApiKey
                });

                //开启权限小锁
                //c.OperationFilter<AddResponseHeadersFilter>();
                //c.OperationFilter<GlobalHttpHeaderFilter>();
                //c.OperationFilter<AppendAuthorizeToSummaryOperationFilter>();
                //c.OperationFilter<SecurityRequirementsOperationFilter>();

                //单个xml文件注释读取
                //c.IncludeXmlComments(commentsFile);
  
            });
        }
    }
}
