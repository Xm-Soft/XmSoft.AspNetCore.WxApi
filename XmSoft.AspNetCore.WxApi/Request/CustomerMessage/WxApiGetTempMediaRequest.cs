using System;
using System.Collections.Generic;
using System.Text;
using XmSoft.AspNetCore.WxApi.Response.CustomerMessage;
using XmSoft.AspNetCore.WxApi.Response;

namespace XmSoft.AspNetCore.WxApi.Request.CustomerMessage
{
    /// <summary>
    /// 获取客服消息内的临时素材。即下载临时的多媒体文件。目前小程序仅支持下载图片文件。
    /// </summary>
    public class WxApiGetTempMediaRequest : IWxApiRequest<WxApiFileResponse>
    {
        /// <summary>
        /// 获取客服消息内的临时素材。即下载临时的多媒体文件。目前小程序仅支持下载图片文件。
        /// </summary>
        public WxApiGetTempMediaRequest()
        {

        }
        public string AccessToken { get; set; }
        /// <summary>
        /// 媒体文件 ID
        /// </summary>
        public string Media_id { get; set; }
       


        #region IWxApiRequest Members

        public string GetRequestUrl()
        {
            return "https://api.weixin.qq.com/cgi-bin/media/get";
        }

        public IDictionary<string, object> GetParameters()
        {
            var parameters = new WxApiDictionary
            {
                { "access_token", AccessToken },
                { "media_id", Media_id }
                
            };
            return parameters;
        }

        public bool IsPost()
        {
            return false;
        }

        #endregion
    }
    
}
