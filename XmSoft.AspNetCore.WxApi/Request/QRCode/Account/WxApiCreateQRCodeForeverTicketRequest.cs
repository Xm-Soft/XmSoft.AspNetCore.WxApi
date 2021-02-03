using System;
using System.Collections.Generic;
using System.Text;
using XmSoft.AspNetCore.WxApi.Response.QRCode;
using Newtonsoft.Json;

namespace XmSoft.AspNetCore.WxApi.Request.QRCode
{
    /// <summary>
    /// 生成永久带参数二维码的接口
    /// </summary>
    public class WxApiCreateQRCodeForeverTicketRequest : IWxApiRequest<WxApiCreateQRCodeForeverTicketResponse>
    {
        /// <summary>
        /// 生成永久带参数二维码的接口 -- 公众平台
        /// </summary>
        public WxApiCreateQRCodeForeverTicketRequest()
        {
            action_name = "QR_LIMIT_SCENE";
        }
        /// <summary>
        /// token
        /// </summary>
        public string AccessToken { get; set; }
       
        /// <summary>
        /// 	二维码类型，QR_SCENE为临时的整型参数值，QR_STR_SCENE为临时的字符串参数值，
        /// 	QR_LIMIT_SCENE为永久的整型参数值，QR_LIMIT_STR_SCENE为永久的字符串参数值
        /// </summary>
        public string action_name { get; set; }
        /// <summary>
        /// 二维码详细信息
        /// </summary>
        public ActionInfo action_info { get; set; }

        #region IWxApiRequest Members

        public string GetRequestUrl()
        {
            return "https://api.weixin.qq.com/cgi-bin/qrcode/create";
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
                { "action_name", action_name },
                { "action_info",JsonConvert.SerializeObject(action_info) }
            };
            return parameters;
        }

        #endregion
    }
   
}
