using System;
using System.Collections.Generic;
using System.Text;
using XmSoft.AspNetCore.WxApi.Response.User;

namespace XmSoft.AspNetCore.WxApi.Request.User
{
    /// <summary>
    /// 设置用户备注名 - 公众平台
    /// </summary>
    public class WxApiUpdateUserRemarkRequest : IWxApiRequest<WxApiUpdateUserRemarkResponse>
    {
        /// <summary>
        /// 设置用户备注名  - 公众平台
        /// </summary>
        public WxApiUpdateUserRemarkRequest()
        {
           
        }
        /// <summary>
        /// Token
        /// </summary>
        public string AccessToken { get; set; }

        /// <summary>
        /// 用户OpenId
        /// </summary>
        public string Openid { get; set; }
        /// <summary>
        /// 备注名
        /// </summary>
        public string Remark { get; set; }

        #region IWxApiRequest Members
        /// <summary>
        /// 请求路径
        /// </summary>
        /// <returns></returns>
        public string GetRequestUrl()
        {
            return "https://api.weixin.qq.com/cgi-bin/user/info/updateremark";
        }
        /// <summary>
        /// 获取参数
        /// </summary>
        /// <returns></returns>
        public IDictionary<string, string> GetParameters()
        {
            var parameters = new WxApiDictionary
            {
                { "access_token", AccessToken },
                { "openid", Openid },
                {"remark",Remark }
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
