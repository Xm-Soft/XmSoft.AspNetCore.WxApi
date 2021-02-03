using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XmSoft.AspNetCore.WxApi.Response.Subscribe;

namespace XmSoft.AspNetCore.WxApi.Request.Subscribe
{
    /// <summary>
    /// 获取模板标题下的关键词列表
    /// </summary>
    public class WxApiGetPubTemplateKeyWordsByIdRequest : IWxApiRequest<WxApiGetPubTemplateKeyWordsByIdResponse>
    {
        /// <summary>
        /// 获取模板标题下的关键词列表
        /// </summary>
        public WxApiGetPubTemplateKeyWordsByIdRequest()
        {
        }
        /// <summary>
        /// 模板标题 id，可通过接口获取
        /// </summary>
        public string Tid { get; set; }
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
                { "tid",Tid }
            };
            return parameters;
        }
        /// <summary>
        /// 请求地址
        /// </summary>
        /// <returns></returns>

        public string GetRequestUrl()
        {
            return "https://api.weixin.qq.com/wxaapi/newtmpl/getpubtemplatekeywords";
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
