using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace XmSoft.AspNetCore.WxApi.Response
{
    /// <summary>
    /// 公众号 通过code换取网页授权access_token ( 获取 accesstoken 和 openid)
    /// </summary>
    public class WxApiGetAccountAccessTokenResponse : WxApiResponse
    {
        /// <summary>
        /// 网页授权接口调用凭证,注意：此access_token与基础支持的access_token不同
        /// </summary>
        [JsonProperty(PropertyName = "access_token")]
        public string AccessToken { get; set; }
        /// <summary>
        /// access_token接口调用凭证超时时间，单位（秒）
        /// </summary>
        [JsonProperty(PropertyName = "expires_in")]
        public string ExpiresIn { get; set; }
        /// <summary>
        /// 用户刷新access_token
        /// </summary>
        [JsonProperty(PropertyName = "refresh_token")]
        public string RefreshToken { get; set; }
        /// <summary>
        /// 用户唯一标识，请注意，在未关注公众号时，用户访问公众号的网页，也会产生一个用户和公众号唯一的OpenID
        /// </summary>
        [JsonProperty(PropertyName = "openid")]
        public string OpenId { get; set; }
        /// <summary>
        /// 用户授权的作用域，使用逗号（,）分隔
        /// </summary>
        [JsonProperty(PropertyName = "scope")]
        public string Scope { get; set; }


    }
}
