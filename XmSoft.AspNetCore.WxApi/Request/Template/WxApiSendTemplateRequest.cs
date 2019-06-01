using System;
using System.Collections.Generic;
using System.Text;
using XmSoft.AspNetCore.WxApi.Response.Template;
using Newtonsoft.Json;

namespace XmSoft.AspNetCore.WxApi.Request.Template
{
    /// <summary>
    /// 发送模板消息 
/* 
 {
  "touser": "OPENID",
  "template_id": "TEMPLATE_ID",
  "page": "index",
  "form_id": "FORMID",
  "data": {
    "keyword1": {
      "value": "339208499"
    },
    "keyword2": {
      "value": "2015年01月05日 12:30"
    },
    "keyword3": {
      "value": "腾讯微信总部"
    },
    "keyword4": {
      "value": "广州市海珠区新港中路397号"
    }
  },
  "emphasis_keyword": "keyword1.DATA"
}
*/
    /// </summary>
    public class WxApiSendTemplateRequest : IWxApiRequest<WxApiSendTemplateResponse>
    {
        /// <summary>
       /// 发送模板消息
        /// </summary>
        public WxApiSendTemplateRequest()
        {
        }
        /// <summary>
        /// Token
        /// </summary>
        public string AccessToken { get; set; }
        /// <summary>
        /// 接收者（用户）的 openid
        /// </summary>
        public string Touser { get; set; }
        /// <summary>
        /// 所需下发的模板消息的id
        /// </summary>
        public string Template_id { get; set; }
        /// <summary>
        /// 点击模板卡片后的跳转页面，仅限本小程序内的页面。支持带参数,（示例index?foo=bar）。该字段不填则模板无跳转。
        /// </summary>
        public string Page { get; set; }
        /// <summary>
        /// 表单提交场景下，为 submit 事件带上的 formId；支付场景下，为本次支付的 prepay_id
        /// </summary>
        public string Form_id { get; set; }
        /// <summary>
        /// 模板内容，不填则下发空模板。具体格式请参考示例。
        /// </summary>
        public object Data { get; set; }
        /// <summary>
        /// 模板需要放大的关键词，不填则默认无放大 可不填
        /// </summary>
        public string Emphasis_keyword { get; set; }


        #region IWxApiRequest Members
        /// <summary>
        /// 请求路径
        /// </summary>
        /// <returns></returns>
        public string GetRequestUrl()
        {
            return "https://api.weixin.qq.com/cgi-bin/message/wxopen/template/send";
        }
        /// <summary>
        /// 获取参数
        /// </summary>
        /// <returns></returns>
        public IDictionary<string, object> GetParameters()
        {
            var parameters = new WxApiDictionary
            {
                { "access_token", AccessToken },
                { "touser", Template_id },
                { "template_id", Template_id },
                { "page", Page },
                { "form_id", Form_id },
                { "data",  Data == null ? null : JsonConvert.SerializeObject( Data )},
                { "emphasis_keyword", Emphasis_keyword }
               


            };
            return parameters;
        }
        /// <summary>
        /// 请求方式 Post Or Get
        /// </summary>
        /// <returns></returns>
        public bool IsPost()
        {
            return true;
        }

        #endregion
    }
   
}
