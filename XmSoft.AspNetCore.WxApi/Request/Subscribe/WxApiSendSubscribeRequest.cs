using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XmSoft.AspNetCore.WxApi.Response.Subscribe;

namespace XmSoft.AspNetCore.WxApi.Request.Subscribe
{
    /// <summary>
    /// 发送订阅消息
    /// </summary>
    public class WxApiSendSubscribeRequest : IWxApiRequest<WxApiSendSubscribeResponse>
    {
        /// <summary>
        /// 发送订阅消息
        /// </summary>
        public WxApiSendSubscribeRequest()
        {
            Miniprogram_State = "formal";
            Lang = "zh_CN";
        }
        /// <summary>
        /// 授权token （必填）
        /// </summary>
        public string AccessToken { get; set; }
        /// <summary>
        /// 接收者（用户）的 openid （必填）
        /// </summary>
        public string Touser { get; set; }
        /// <summary>
        /// 所需下发的订阅模板id （必填）
        /// </summary>
        public string Template_Id { get; set; }
        /// <summary>
        /// 点击模板卡片后的跳转页面，仅限本小程序内的页面。支持带参数,（示例index?foo=bar）。该字段不填则模板无跳转 （可选）
        /// </summary>
        public string Page { get; set; }
        /// <summary>
        /// 模板内容，格式形如 { "key1": { "value": any }, "key2": { "value": any } }  （必填）
        /// </summary>
        public string Data { get; set; }
        /// <summary>
        /// 跳转小程序类型：developer为开发版；trial为体验版；formal为正式版；默认为正式版  （可选）
        /// </summary>
        public string Miniprogram_State { get; set; }
        /// <summary>
        /// 进入小程序查看”的语言类型，支持zh_CN(简体中文)、en_US(英文)、zh_HK(繁体中文)、zh_TW(繁体中文)，默认为zh_CN （可选）
        /// </summary>
        public string Lang { get; set; }
        /// <summary>
        /// 请求参数
        /// </summary>
        /// <returns></returns>
        public IDictionary<string, object> GetParameters()
        {
            var parameters = new WxApiDictionary
            {
                { "access_token", AccessToken },
                { "touser", Touser },
                { "template_id", Template_Id },
                { "page", Page },
                { "data", Data },
                { "miniprogram_state", Miniprogram_State },
                { "lang",Lang }


            };
            return parameters;
        }
        /// <summary>
        /// 请求地址
        /// </summary>
        /// <returns></returns>
        public string GetRequestUrl()
        {
            return "https://api.weixin.qq.com/cgi-bin/message/subscribe/send";
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
