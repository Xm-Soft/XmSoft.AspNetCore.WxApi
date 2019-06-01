using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;
using XmSoft.AspNetCore.WxApi.Response.Activity;

namespace XmSoft.AspNetCore.WxApi.Request.Activity
{
    /// <summary>
    /// 修改被分享的动态消息。详见动态消息。
    /// </summary>
    public class WxApiSetUpdatableMsgRequest : IWxApiRequest<WxApiSetUpdatableMsgResponse>
    {
        /// <summary>
        /// 修改被分享的动态消息。详见动态消息。
        /// </summary>
        public WxApiSetUpdatableMsgRequest()
        {

        }
        /// <summary>
        /// Token
        /// </summary>
        public string AccessToken { get; set; }
        /// <summary>
        /// 动态消息的 ID，通过 CreateActivityId 接口获取
        /// </summary>
        public string Activity_id { get; set; }
        /// <summary>
        /// 动态消息修改后的状态（具体含义见后文） 0	未开始,1	已开始
        /// </summary>
        public int Target_state { get; set; }
        /// <summary>
        /// 动态消息对应的模板信息
        /// </summary>
        public Template_Info Template_info { get; set; }

        #region IWxApiRequest Members

        public string GetRequestUrl()
        {
            return "https://api.weixin.qq.com/cgi-bin/message/wxopen/updatablemsg/send";
        }

        public IDictionary<string, object> GetParameters()
        {
            var parameters = new WxApiDictionary
            {
                { "access_token", AccessToken },
                { "activity_id", Activity_id },
                { "target_state", Target_state },
                { "template_info", Template_info == null ? null : JsonConvert.SerializeObject(Template_info) }
              
            };
            return parameters;
        }

        public bool IsPost()
        {
            return true;
        }

        #endregion
    }

    public class Template_Info
    {
        [JsonProperty(PropertyName = "parameter_list")]
        public List<Parameter_List> parameter_list { get; set; }
    }
    public class Parameter_List
    {
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }
        [JsonProperty(PropertyName = "value")]
        public string Value { get; set; }
    }

}
