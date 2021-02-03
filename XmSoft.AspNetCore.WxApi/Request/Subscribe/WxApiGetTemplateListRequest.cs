using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XmSoft.AspNetCore.WxApi.Response.Subscribe;

namespace XmSoft.AspNetCore.WxApi.Request.Subscribe
{
    /// <summary>
    /// 获取当前帐号下的个人模板列表
    /// </summary>
    public class WxApiGetTemplateListRequest : IWxApiRequest<WxApiGetTemplateListResponse>
    {
        /// <summary>
        /// 获取当前帐号下的个人模板列表
        /// </summary>
        public WxApiGetTemplateListRequest()
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
            return "https://api.weixin.qq.com/wxaapi/newtmpl/gettemplate";
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
