using System;
using System.Collections.Generic;
using System.Text;
using XmSoft.AspNetCore.WxApi.Response;

namespace XmSoft.AspNetCore.WxApi.Request
{
    /// <summary>
    /// 获取小程序全局唯一后台接口调用凭据（access_token）
    /// </summary>
    public class WxApiGetAccessTokenRequest : IWxApiRequest<WxApiGetAccessTokenResponse>
    {
        /// <summary>
        /// 获取小程序全局唯一后台接口调用凭据（access_token）
        /// </summary>
        public WxApiGetAccessTokenRequest()
        {
            GrantType = "client_credential";
        }
        /// <summary>
        /// 商户AppId
        /// </summary>
        public string AppId { get; set; }
        /// <summary>
        /// 商户Secret
        /// </summary>
        public string Secret { get; set; }
        /// <summary>
        /// 默认类型 client_credential
        /// </summary>
        public string GrantType { get; set; }

        #region IWxApiRequest Members
        /// <summary>
        /// 请求路径
        /// </summary>
        /// <returns></returns>
        public string GetRequestUrl()
        {
            return "https://api.weixin.qq.com/cgi-bin/token";
        }
        /// <summary>
        /// 获取参数
        /// </summary>
        /// <returns></returns>
        public IDictionary<string, object> GetParameters()
        {
            var parameters = new WxApiDictionary
            {
                { "appid", AppId },
                { "secret", Secret },
                { "grant_type", GrantType }
            };
            return parameters;
        }
        /// <summary>
        /// 请求方式 Post Or Get
        /// </summary>
        /// <returns></returns>
        public bool IsPost()
        {
            return false;
        }

        #endregion
    }
}
