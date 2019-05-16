using System;
using System.Collections.Generic;
using System.Text;
using XmSoft.AspNetCore.WxApi.Response.CustomerMessage;

namespace XmSoft.AspNetCore.WxApi.Request.CustomerMessage
{
    /// <summary>
    /// 下发客服当前输入状态给用户。详见 客服消息输入状态
    /// </summary>
    public class WxApiSetTypingRequest : IWxApiRequest<WxApiSetTypingResponse>
    {

        /// <summary>
        /// 下发客服当前输入状态给用户。详见 客服消息输入状态
        /// </summary>
        public WxApiSetTypingRequest()
        { }
        public string AccessToken { get; set; }
        /// <summary>
        /// 用户的 OpenID
        /// </summary>
        public string Touser { get; set; }
        /// <summary>
        /// 命令
        /// </summary>
        public string Command { get; set; }
       

        #region IWxApiRequest Members

        public string GetRequestUrl()
        {
            return "https://api.weixin.qq.com/cgi-bin/message/custom/typing";
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new WxApiDictionary
            {
                { "access_token", AccessToken },
                { "touser", Touser },
                { "command", Command }

            };
            return parameters;
        }

        public bool IsPost()
        {
            return true;
        }

        #endregion
    }
   
}
