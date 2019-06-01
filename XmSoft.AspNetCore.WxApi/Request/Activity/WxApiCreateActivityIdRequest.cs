using System;
using System.Collections.Generic;
using System.Text;
using XmSoft.AspNetCore.WxApi.Response.Activity;

namespace XmSoft.AspNetCore.WxApi.Request.Activity
{
    /// <summary>
    /// 创建被分享动态消息的 activity_id。详见动态消息。
    /// </summary>
    public class WxApiCreateActivityIdRequest : IWxApiRequest<WxApiCreateActivityIdResponse>
    {
        /// <summary>
        /// 创建被分享动态消息的 activity_id。详见动态消息。
        /// </summary>
        public WxApiCreateActivityIdRequest()
        {
           
        }
        /// <summary>
        /// Token
        /// </summary>
        public string AccessToken { get; set; }

        #region IWxApiRequest Members

        public string GetRequestUrl()
        {
            return "https://api.weixin.qq.com/cgi-bin/message/wxopen/activityid/create";
        }

        public IDictionary<string, object> GetParameters()
        {
            var parameters = new WxApiDictionary
            {
                { "access_token", AccessToken }
            };
            return parameters;
        }

        public bool IsPost()
        {
            return false;
        }

        #endregion
    }
}
