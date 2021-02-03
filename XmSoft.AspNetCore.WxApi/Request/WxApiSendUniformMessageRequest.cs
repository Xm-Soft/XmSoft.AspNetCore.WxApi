using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;
using XmSoft.AspNetCore.WxApi.Response;

namespace XmSoft.AspNetCore.WxApi.Request
{
    /// <summary>
    /// 下发小程序和公众号统一的服务消息
    /// </summary>
    public class WxApiSendUniformMessageRequest : IWxApiRequest<WxApiSendUniformMessageResponse>
    {
        /// <summary>
        ///下发小程序和公众号统一的服务消息
        /// </summary>
        public WxApiSendUniformMessageRequest()
        {
        }
        /// <summary>
        /// token
        /// </summary>
        public string AccessToken { get; set; }
        /// <summary>
        /// 用户的 OpenID
        /// </summary>
        public string Touser { get; set; }
        /// <summary>
        ///小程序模板消息相关的信息，可以参考小程序模板消息接口; 有此节点则优先发送小程序模板消息 否
        /// </summary>
        public Weapp_Template_Msg Weapp_Template_Msg { get; set; }
        /// <summary>
        /// 公众号模板消息相关的信息，可以参考公众号模板消息接口；有此节点并且没有weapp_template_msg节点时，发送公众号模板消息
        /// </summary>
        public Mp_Template_Msg Mp_Template_Msg { get; set; }

        #region IWxApiRequest Members
        /// <summary>
        /// 请求地址
        /// </summary>
        /// <returns></returns>
        public string GetRequestUrl()
        {
            return "https://api.weixin.qq.com/cgi-bin/message/wxopen/template/uniform_send";
        }
        /// <summary>
        /// 获取Url参数
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
        /// 请求方式Get Or Post
        /// </summary>
        /// <returns></returns>
        public bool IsPost()
        {
            return true;
        }
        /// <summary>
        /// Body参数
        /// </summary>
        /// <returns></returns>
        public IDictionary<string, object> GetBodyParametes()
        {
            var parameters = new WxApiDictionary
            {
                { "touser", Touser },
                { "weapp_template_msg",Weapp_Template_Msg == null?null:JsonConvert.SerializeObject(Weapp_Template_Msg) },
                { "mp_template_msg",Mp_Template_Msg == null ? null: JsonConvert.SerializeObject(Mp_Template_Msg) }
            };
            return parameters;
        }

        #endregion
    }

    public class Weapp_Template_Msg
    {
        [JsonProperty(PropertyName = "template_id")]
        public string Template_id { get; set; }
        [JsonProperty(PropertyName = "page")]
        public string Page { get; set; }
        [JsonProperty(PropertyName = "form_id")]
        public string Form_id { get; set; }
        [JsonProperty(PropertyName = "data")]
        public object Data { get; set; }
        [JsonProperty(PropertyName = "emphasis_keyword")]
        public string Emphasis_keyword { get; set; }
    }
    public class Mp_Template_Msg
    {
        [JsonProperty(PropertyName = "appid")]
        public string Appid { get; set; }
        [JsonProperty(PropertyName = "template_id")]
        public string Template_id { get; set; }
        [JsonProperty(PropertyName = "url")]
        public string Url { get; set; }
        [JsonProperty(PropertyName = "miniprogram")]
        public Miniprogram  Miniprogram { get; set; }
        [JsonProperty(PropertyName = "data")]
        public object Data { get; set; }
    }
    public class Miniprogram
    {
        [JsonProperty(PropertyName = "appid")]
        public string Appid { get; set; }
        [JsonProperty(PropertyName = "pagepath")]
        public string Pgepath { get; set; }
    }
}
