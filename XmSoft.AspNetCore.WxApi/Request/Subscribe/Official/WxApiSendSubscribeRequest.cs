using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XmSoft.AspNetCore.WxApi.Response.Subscribe;

namespace XmSoft.AspNetCore.WxApi.Request.Subscribe.Official
{
    /// <summary>
    /// 发送订阅通知 - 公众号
    /// </summary>
    public class WxApiBizSendSubscribeRequest : IWxApiRequest<WxApiSendSubscribeResponse>
    {
        /// <summary>
        /// 发送订阅消息
        /// </summary>
        public WxApiBizSendSubscribeRequest()
        {
        }
        /// <summary>
        /// 授权token （必填）
        /// </summary>
        public string AccessToken { get; set; }
        /// <summary>
        /// 接收者（用户）的 openid
        /// </summary>
        public string Touser { get; set; }
        /// <summary>
        /// 所需下发的订阅模板id
        /// </summary>
        public string Template_Id { get; set; }
        /// <summary>
        /// 跳转网页时填写
        /// </summary>
        public string Page { get; set; }
        /// <summary>
        /// 模板内容，格式形如 { "key1": { "value": any }, "key2": { "value": any } }
        /// </summary>
        public string Data { get; set; }
        /// <summary>
        /// 跳转小程序时填写，格式如{ "appid": "pagepath": { "value": any } }
        /// </summary>
        public string Miniprogram_State { get; set; }
       

        public IDictionary<string, object> GetBodyParametes()
        {
            var parameters = new WxApiDictionary
            {
                { "touser", Touser },
                { "template_id", Template_Id },
                { "page", Page },
                { "data", Data },
                { "miniprogram", Miniprogram_State },
            };
            return parameters;
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
            return "https://api.weixin.qq.com/cgi-bin/message/subscribe/bizsend";
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
