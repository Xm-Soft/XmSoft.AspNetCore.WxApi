using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;
using XmSoft.AspNetCore.WxApi.Response.Template.Message;

namespace XmSoft.AspNetCore.WxApi.Request.Template.Message
{
    /// <summary>
    ///发送模板消息
    /// </summary>
    public class WxApiSendTemplateMessageRequest : IWxApiRequest<WxApiSendTemplateMessageResponse>
    {
        /// <summary>
        /// 发送模板消息 - 公众平台
        /// </summary>
        public WxApiSendTemplateMessageRequest()
        {
        }
        /// <summary>
        /// Token
        /// </summary>
        public string AccessToken { get; set; }
        /// <summary>
        /// 公众帐号下模板消息ID
        /// </summary>
        public string Template_id { get; set; }
        /// <summary>
        /// 接收者openid
        /// </summary>
        public string Touser { get; set; }
        /// <summary>
        /// 模板跳转链接（海外帐号没有跳转能力）
        /// </summary>
        public string Url { get; set; }

        /// <summary>
        /// 跳小程序所需数据，不需跳小程序可不用传该数据 非必填
        /// </summary>
        public MiniProgram Miniprogram { get; set; }
        /// <summary>
        /// 模板数据 Json 数据
        /// </summary>
        public object Data { get; set; }
        /// <summary>
        /// 模板内容字体颜色，不填默认为黑色 非必填
        /// </summary>
        public string Color { get; set; }

        #region IWxApiRequest Members
        /// <summary>
        /// 请求地址
        /// </summary>
        /// <returns></returns>
        public string GetRequestUrl()
        {
            return "https://api.weixin.qq.com/cgi-bin/message/template/send";
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
        /// IsPost
        /// </summary>
        /// <returns></returns>
        public bool IsPost()
        {
            return true;
        }
        /// <summary>
        /// 获取Body
        /// </summary>
        /// <returns></returns>
        public IDictionary<string, object> GetBodyParametes()
        {
            var parameters = new WxApiDictionary
            {
                { "touser", Touser },
                { "template_id", Template_id },
                { "url", Url },
                { "miniprogram", Miniprogram == null ? null: JsonConvert.SerializeObject(Miniprogram) },
                { "data", Data }
            };
            return parameters;
        }

        #endregion
    }
    /// <summary>
    /// 
    /// </summary>
    public class MiniProgram
    {
        /// <summary>
        /// 所需跳转到的小程序appid（该小程序appid必须与发模板消息的公众号是绑定关联关系，暂不支持小游戏）
        /// </summary>
        public string appid { get; set; }
        /// <summary>
        /// 所需跳转到小程序的具体页面路径，支持带参数,（示例index?foo=bar），要求该小程序已发布，暂不支持小游戏
        /// </summary>
        public string pagepath { get; set; }
    }


}
