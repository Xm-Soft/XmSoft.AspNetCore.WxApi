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
    public class WxApiQueryRecoresultfortextRequest : IWxApiRequest<WxApiQueryRecoresultfortextResponse>
    {
        /// <summary>
        ///提交语音 - 公众平台
        /// </summary>
        public WxApiQueryRecoresultfortextRequest()
        {
            Lang = "zh_CN";
        }
        public string AccessToken { get; set; }
        /// <summary>
        /// 语音唯一标识
        /// </summary>
        public string Voice_id { get; set; }
        /// <summary>
        /// 语言，zh_CN 或 en_US，默认中文
        /// </summary>
        public string Lang { get; set; }


        #region IWxApiRequest Members

        public string GetRequestUrl()
        {
            return "http://api.weixin.qq.com/cgi-bin/media/voice/queryrecoresultfortext";
        }

        public IDictionary<string, object> GetParameters()
        {
            var parameters = new WxApiDictionary
            {
                { "access_token", AccessToken },
                { "voice_id", Voice_id },
                { "lang", Lang }


            };
            return parameters;
        }

        public bool IsPost()
        {
            return false;
        }

        public IDictionary<string, object> GetBodyParametes()
        {
            return new WxApiDictionary();
        }

        #endregion
    }
   

}
