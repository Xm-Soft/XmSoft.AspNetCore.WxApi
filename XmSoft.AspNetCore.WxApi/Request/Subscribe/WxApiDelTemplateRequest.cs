using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XmSoft.AspNetCore.WxApi.Response.Subscribe;

namespace XmSoft.AspNetCore.WxApi.Request.Subscribe
{
    /// <summary>
    /// 删除帐号下的个人模板 请求
    /// </summary>
    public class WxApiDelTemplateRequest : IWxApiRequest<WxApiDelTemplateResponse>
    {
        /// <summary>
        /// 删除帐号下的个人模板 请求
        /// </summary>
        public WxApiDelTemplateRequest()
        {
        }
        /// <summary>
        /// 授权token （必填）
        /// </summary>
        public string AccessToken { get; set; }
        /// <summary>
        /// 要删除的模板id
        /// </summary>
        public string PriTmplId { get; set; }
        /// <summary>
        /// 请求参数
        /// </summary>
        /// <returns></returns>
        public IDictionary<string, object> GetParameters()
        {
            var parameters = new WxApiDictionary
            {
                { "access_token", AccessToken },
                { "priTmplId",PriTmplId },
            };
            return parameters;
        }
        /// <summary>
        /// 请求地址
        /// </summary>
        /// <returns></returns>
        public string GetRequestUrl()
        {
            return "https://api.weixin.qq.com/wxaapi/newtmpl/deltemplate";
        }
        /// <summary>
        /// IsPost
        /// </summary>
        /// <returns></returns>
        public bool IsPost()
        {
            return true;
        }
    }
}
