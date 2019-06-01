using System;
using System.Collections.Generic;
using System.Text;
using XmSoft.AspNetCore.WxApi.Response.QRCode;
using Newtonsoft.Json;

namespace XmSoft.AspNetCore.WxApi.Request.QRCode
{
    /// <summary>
    /// 生成临时带参数二维码的接口
    /// </summary>
    public class WxApiCreateQRCodeShortTimeTicketRequest : IWxApiRequest<WxApiCreateQRCodeShortTimeTicketResponse>
    {
        /// <summary>
        /// 生成临时带参数二维码的接口 -- 公众平台
        /// </summary>
        public WxApiCreateQRCodeShortTimeTicketRequest()
        {
            action_name = "QR_SCENE";
        }
        /// <summary>
        /// token
        /// </summary>
        public string AccessToken { get; set; }
        /// <summary>
        /// 该二维码有效时间，以秒为单位。 最大不超过2592000（即30天），此字段如果不填，则默认有效期为30秒。
        /// </summary>
        public string expire_seconds { get; set; }
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
                 { "expire_seconds", expire_seconds },
                   { "action_name", action_name },
                    { "action_info",JsonConvert.SerializeObject(action_info) }
            };
            return parameters;
        }

        public bool IsPost()
        {
            return true;
        }

        #endregion
    }
    /// <summary>
    /// 二维码详细信息
    /// </summary>
    public class ActionInfo
    {
        /// <summary>
        /// 
        /// </summary>
        public scene scene { get; set; }
    }
    public class scene
    {
        /// <summary>
        /// 场景值ID，临时二维码时为32位非0整型，永久二维码时最大值为100000（目前参数只支持1--100000）
        /// </summary>
        public int scene_id { get; set; }
    }
}
