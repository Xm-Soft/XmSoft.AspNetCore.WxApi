using System;
using System.Collections.Generic;
using System.Text;
using XmSoft.AspNetCore.WxApi.Response.Card;
using XmSoft.AspNetCore.WxApi.Model.Card;
using Newtonsoft.Json;

namespace XmSoft.AspNetCore.WxApi.Request.Card
{
    /// <summary>
    ///设置测试白名单
    /// </summary>
    public class WxApiTestWhiteListRequest : IWxApiRequest<WxApiTestWhiteListResponse>
    {

        /// <summary>
        ///设置测试白名单-- 公众平台
        /// </summary>
        public WxApiTestWhiteListRequest()
        {
           
        }
        public string AccessToken { get; set; }
       
        public string[] Openid { get; set; }

        public string[] Username { get; set; }

        #region IWxApiRequest Members
        /// <summary>
        /// 请求路径
        /// </summary>
        /// <returns></returns>
        public string GetRequestUrl()
        {
            return "https://api.weixin.qq.com/card/testwhitelist/set";
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
                { "openid",Openid },
                { "username",Username }
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
