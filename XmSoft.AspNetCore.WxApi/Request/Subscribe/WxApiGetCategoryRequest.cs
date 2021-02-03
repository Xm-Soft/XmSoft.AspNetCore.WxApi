using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XmSoft.AspNetCore.WxApi.Response.Subscribe;

namespace XmSoft.AspNetCore.WxApi.Request.Subscribe
{
    /// <summary>
    /// 获取小程序账号的类目
    /// </summary>
    public class WxApiGetCategoryRequest : IWxApiRequest<WxApiGetCategoryResponse>
    {
        /// <summary>
        /// 获取小程序账号的类目
        /// </summary>
        public WxApiGetCategoryRequest()
        {
        }
        /// <summary>
        /// 授权token （必填）
        /// </summary>
        public string AccessToken { get; set; }

        public IDictionary<string, object> GetBodyParametes()
        {
            return new WxApiDictionary();
        }

        /// <summary>
        /// 请求参数
        /// </summary>
        /// <returns></returns>
        public IDictionary<string, object> GetParameters()
        {
            var parameters = new WxApiDictionary
            {
                { "access_token", AccessToken },
            };
            return parameters;
        }
        
        /// <summary>
        /// 请求地址
        /// </summary>
        /// <returns></returns>
        public string GetRequestUrl()
        {
            return "https://api.weixin.qq.com/wxaapi/newtmpl/getcategory";
        }
        /// <summary>
        /// IsPost
        /// </summary>
        /// <returns></returns>
        public bool IsPost()
        {
            return false;
        }
    }
}
