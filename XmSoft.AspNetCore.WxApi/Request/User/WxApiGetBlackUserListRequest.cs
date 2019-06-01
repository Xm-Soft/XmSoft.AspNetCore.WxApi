using System;
using System.Collections.Generic;
using System.Text;
using XmSoft.AspNetCore.WxApi.Response.User;

namespace XmSoft.AspNetCore.WxApi.Request.User
{
    /// <summary>
    ///  获取公众号的黑名单列表 - 公众平台
    /// </summary>
    public class WxApiGetBlackUserListRequest : IWxApiRequest<WxApiGetUserListResponse>
    {
        /// <summary>
        ///  获取公众号的黑名单列表  - 公众平台
        /// </summary>
        public WxApiGetBlackUserListRequest()
        {
           
        }
        /// <summary>
        /// Token
        /// </summary>
        public string AccessToken { get; set; }

        /// <summary>
        /// 当 begin_openid 为空时，默认从开头拉取。
        /// </summary>
        public string Begin_openid { get; set; }
      

        #region IWxApiRequest Members
        /// <summary>
        /// 请求路径
        /// </summary>
        /// <returns></returns>
        public string GetRequestUrl()
        {
            return "https://api.weixin.qq.com/cgi-bin/tags/members/getblacklist";
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
                { "begin_openid", Begin_openid }
            };
            return parameters;
        }
        /// <summary>
        /// 请求方式Post Or Get
        /// </summary>
        /// <returns></returns>
        public bool IsPost()
        {
            return true;
        }

        #endregion
    }

   
}
