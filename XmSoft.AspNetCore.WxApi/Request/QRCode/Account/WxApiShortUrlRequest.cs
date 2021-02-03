using System;
using System.Collections.Generic;
using System.Text;
using XmSoft.AspNetCore.WxApi.Response.QRCode;
using Newtonsoft.Json;

namespace XmSoft.AspNetCore.WxApi.Request.QRCode
{
    /// <summary>
    /// 长链接转短链接接口
    /// </summary>
    public class WxApiShortUrlRequest : IWxApiRequest<WxApiShortUrlResponse>
    {
        /// <summary>
        /// 长链接转短链接接口 -- 公众平台
        /// </summary>
        public WxApiShortUrlRequest()
        {
            Action = "long2short";
        }
        /// <summary>
        /// token
        /// </summary>
        public string AccessToken { get; set; }

        /// <summary>
        /// 	此处填long2short，代表长链接转短链接
        /// </summary>
        public string Action { get; set; }
        /// <summary>
        /// 需要转换的长链接，支持http://、https://、weixin://wxpay 格式的url
        /// </summary>
        public string Long_url { get; set; }

        #region IWxApiRequest Members

        public string GetRequestUrl()
        {
            return "https://api.weixin.qq.com/cgi-bin/shorturl";
        }

        public IDictionary<string, object> GetParameters()
        {
            var parameters = new WxApiDictionary
            {
                { "access_token", AccessToken },
            };
            return parameters;
        }

        public bool IsPost()
        {
            return true;
        }

        public IDictionary<string, object> GetBodyParametes()
        {
            var parameters = new WxApiDictionary
            {
                { "action", Action },
                { "long_url",Long_url }
            };
            return parameters;
        }

        #endregion
    }
   
}
