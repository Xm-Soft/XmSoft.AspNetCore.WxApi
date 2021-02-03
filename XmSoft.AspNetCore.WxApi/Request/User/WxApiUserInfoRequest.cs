using System;
using System.Collections.Generic;
using System.Text;
using XmSoft.AspNetCore.WxApi.Response.User;

namespace XmSoft.AspNetCore.WxApi.Request.User
{
    /// <summary>
    /// 获取用户基本信息（包括UnionID机制）- 
    /// </summary>
    public class WxApiUserInfoRequest: IWxApiRequest<WxApiUserInfoResponse>
    {
        /// <summary>
        /// 获取用户基本信息（包括UnionID机制）-- 公众平台
        /// </summary>
        public WxApiUserInfoRequest()
        {
            Lang = "zh_CN";
        }
        /// <summary>
        /// Token
        /// </summary>
        public string AccessToken { get; set; }

        public string Openid { get; set; }

        public string Lang { get; set; }

        #region IWxApiRequest Members
        /// <summary>
        /// 请求路径
        /// </summary>
        /// <returns></returns>
        public string GetRequestUrl()
        {
            return "https://api.weixin.qq.com/cgi-bin/user/info";
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
                { "openid", Openid },
                { "Lang", Lang }
               
            };
            return parameters;
        }
        /// <summary>
        /// 请求方式Post Or Get
        /// </summary>
        /// <returns></returns>
        public bool IsPost()
        {
            return false;
        }

        public IDictionary<string, object> GetBodyParametes()
        {
            return new WxApiDictionary();
        }

        #endregion
    }
}
