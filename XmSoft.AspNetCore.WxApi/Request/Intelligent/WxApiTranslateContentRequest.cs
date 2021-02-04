using System;
using System.Collections.Generic;
using System.Text;
using XmSoft.AspNetCore.WxApi.Response.Intelligent;
using XmSoft.AspNetCore.WxApi.Response;

namespace XmSoft.AspNetCore.WxApi.Request.Intelligent
{
    /// <summary>
    /// 微信翻译
    /// </summary>
    public class WxApiTranslateContentRequest : IWxApiRequest<WxApiTranslateContentResponse>
    {
        /// <summary>
        ///微信翻译 - 公众平台
        /// </summary>
        public WxApiTranslateContentRequest()
        {
           
        }
        public string AccessToken { get; set; }
        /// <summary>
        /// 源语言，zh_CN 或 en_US
        /// </summary>
        public string Lfrom { get; set; }
        /// <summary>
        /// 目标语言，zh_CN 或 en_US
        /// </summary>
        public string Lto { get; set; }
        /// <summary>
        /// body 内容    与上传文件 二选一
        /// </summary>
        public string Body { get; set; }

        /// <summary>
        /// 上传 语音文件 文件格式 （只支持mp3，16k，单声道，最大1M）
        /// </summary>
        public string MediaPath { get; set; }

        #region IWxApiRequest Members

        public string GetRequestUrl()
        {
            return "https://api.weixin.qq.com/cgi-bin/media/voice/translatecontent";
        }

        public IDictionary<string, object> GetParameters()
        {
            var parameters = new WxApiDictionary
            {
                { "access_token", AccessToken },
                { "lfrom", Lfrom },
                { "lto", Lto },
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
                { "body", Body },
                { "media_path", MediaPath }
            };
            return parameters;
        }

        #endregion
    }
   

}
