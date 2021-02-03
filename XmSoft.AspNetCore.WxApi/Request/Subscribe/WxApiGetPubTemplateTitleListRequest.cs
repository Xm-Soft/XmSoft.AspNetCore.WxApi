using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XmSoft.AspNetCore.WxApi.Response.Subscribe;

namespace XmSoft.AspNetCore.WxApi.Request.Subscribe
{
    /// <summary>
    /// 获取帐号所属类目下的公共模板标题
    /// </summary>
    public class WxApiGetPubTemplateTitleListRequest : IWxApiRequest<WxApiGetPubTemplateTitleListResponse>
    {
        /// <summary>
        /// 获取帐号所属类目下的公共模板标题
        /// </summary>
        public WxApiGetPubTemplateTitleListRequest()
        {
            Start = 0;
            Limit = 10;
        }

        /// <summary>
        /// 类目 id，多个用逗号隔开
        /// </summary>
        public string Ids { get; set; }
        /// <summary>
        /// 用于分页，表示从 start 开始。从 0 开始计数
        /// </summary>
        public int Start { get; set; }
        /// <summary>
        /// 用于分页，表示拉取 limit 条记录。最大为 30
        /// </summary>
        public int Limit { get; set; }
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
                { "ids",Ids },
                { "start",Start },
                { "limit",Limit }
            };
            return parameters;
        }
        /// <summary>
        /// 请求地址
        /// </summary>
        /// <returns></returns>

        public string GetRequestUrl()
        {
            return "https://api.weixin.qq.com/wxaapi/newtmpl/getpubtemplatetitles";
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
