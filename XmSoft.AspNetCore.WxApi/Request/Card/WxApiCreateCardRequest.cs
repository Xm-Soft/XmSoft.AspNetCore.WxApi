using System;
using System.Collections.Generic;
using System.Text;
using XmSoft.AspNetCore.WxApi.Response.Card;

namespace XmSoft.AspNetCore.WxApi.Request
{
    /// <summary>
    /// 创建卡券
    /// </summary>
    public class WxApiCreateCardRequest : IWxApiRequest<WxApiCreateCardResponse>
    {
        /// <summary>
        /// 创建卡券 -- 公众平台
        /// </summary>
        public WxApiCreateCardRequest()
        {
           
        }
        public string AccessToken { get; set; }
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
        public IDictionary<string, string> GetParameters()
        {
            var parameters = new WxApiDictionary
            {
                
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
