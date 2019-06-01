using System;
using System.Collections.Generic;
using System.Text;
using XmSoft.AspNetCore.WxApi.Response.Intelligent;
using XmSoft.AspNetCore.WxApi.Response;

namespace XmSoft.AspNetCore.WxApi.Request.Intelligent
{
    /// <summary>
    /// 提交语音
    /// </summary>
    public class WxApiAddVoiceTorecofortextRequest : IWxApiRequest<WxApiAddVoiceTorecofortextResponse>
    {
        /// <summary>
        ///提交语音 - 公众平台
        /// </summary>
        public WxApiAddVoiceTorecofortextRequest()
        {
            Lang = "zh_CN";
        }
        public string AccessToken { get; set; }
        /// <summary>
        /// 文件格式 （只支持mp3，16k，单声道，最大1M）
        /// </summary>
        public string Format { get; set; }
        /// <summary>
        /// 语音唯一标识
        /// </summary>
        public string Voice_id { get; set; }
        /// <summary>
        /// 语言，zh_CN 或 en_US，默认中文
        /// </summary>
        public string Lang { get; set; }
        /// <summary>
        /// 文本内容，不是Json数据
        /// </summary>
        public string Body { get; set; }

        /// <summary>
        /// 上传 语音文件 文件格式 （只支持mp3，16k，单声道，最大1M）
        /// </summary>
        public string MediaPath { get; set; }

        #region IWxApiRequest Members

        public string GetRequestUrl()
        {
            return "http://api.weixin.qq.com/cgi-bin/media/voice/addvoicetorecofortext";
        }

        public IDictionary<string, object> GetParameters()
        {
            var parameters = new WxApiDictionary
            {
                { "access_token", AccessToken },
                { "format", Format },
                { "voice_id", Voice_id },
                { "lang", Lang },
                { "body",Body },
                { "media_path",MediaPath }

            };
            return parameters;
        }

        public bool IsPost()
        {
            return true;
        }

        #endregion
    }
   

}
