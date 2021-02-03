using System;
using System.Collections.Generic;
using System.Text;
using XmSoft.AspNetCore.WxApi.Response.CustomerMessage;

namespace XmSoft.AspNetCore.WxApi.Request.CustomerMessage
{
    /// <summary>
    /// 把媒体文件上传到微信服务器。目前仅支持图片。用于发送客服消息或被动回复用户消息。
    /// </summary>
    public class WxApiUploadTempMediaRequest : IWxApiRequest<WxApiUploadTempMediaResponse>
    {
        /// <summary>
        /// 把媒体文件上传到微信服务器。目前仅支持图片。用于发送客服消息或被动回复用户消息。
        /// </summary>
        public WxApiUploadTempMediaRequest()
        {
        }

        public string AccessToken { get; set; }
        /// <summary>
        /// 文件类型 媒体文件类型，分别有图片（image）、语音（voice）、视频（video）和缩略图（thumb）
        /// </summary>
        public string Type { get; set; }
        /// <summary>
        /// 媒体文件路径
        /// </summary>
        public string MediaPath { get; set; }


        #region IWxApiRequest Members

        public string GetRequestUrl()
        {
            return "https://api.weixin.qq.com/cgi-bin/media/upload";
        }

        public IDictionary<string, object> GetParameters()
        {
            var parameters = new WxApiDictionary
            {
                { "access_token", AccessToken },
                { "type", Type },
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
                {"media_path",MediaPath }
            };
            return parameters;
        }

        #endregion
    }
    
}
