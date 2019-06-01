using System;
using System.Collections.Generic;
using System.Text;
using XmSoft.AspNetCore.WxApi.Response.User;

namespace XmSoft.AspNetCore.WxApi.Request.User
{
    /// <summary>
    /// 获取用户列表 - 公众平台
    /// </summary>
    public class WxApiGetUserListRequest : IWxApiRequest<WxApiGetUserListResponse>
    {
        /// <summary>
        /// 获取用户列表  - 公众平台
        /// </summary>
        public WxApiGetUserListRequest()
        {
           
        }
        /// <summary>
        /// Token
        /// </summary>
        public string AccessToken { get; set; }

        /// <summary>
        /// 第一个拉取的OPENID，不填默认从头开始拉取
        /// </summary>
        public string Next_Openid { get; set; }
      

        #region IWxApiRequest Members
        /// <summary>
        /// 请求路径
        /// </summary>
        /// <returns></returns>
        public string GetRequestUrl()
        {
            return "https://api.weixin.qq.com/cgi-bin/user/get";
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
                { "next_openid", Next_Openid }
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

        #endregion
    }

   
}
