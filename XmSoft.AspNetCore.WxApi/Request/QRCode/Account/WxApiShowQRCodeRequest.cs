using System;
using System.Collections.Generic;
using System.Text;
using XmSoft.AspNetCore.WxApi.Response.QRCode;
using Newtonsoft.Json;
using System.Web;
using XmSoft.AspNetCore.WxApi.Response;

namespace XmSoft.AspNetCore.WxApi.Request.QRCode
{
    /// <summary>
    /// ticket换取二维码图片
    /// </summary>
    public class WxApiShowQRCodeRequest : IWxApiRequest<WxApiFileResponse>
    {
        /// <summary>
        /// 通过 Ticket换取二维码图片-- 公众平台
        /// </summary>
        public WxApiShowQRCodeRequest()
        {
           
        }
        /// <summary>
        /// ticket 数据
        /// </summary>
        public string Ticket { get; set; }
      

        #region IWxApiRequest Members
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public string GetRequestUrl()
        {
            return "https://mp.weixin.qq.com/cgi-bin/showqrcode";
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public IDictionary<string, object> GetParameters()
        {
            var parameters = new WxApiDictionary
            {
                { "ticket", HttpUtility.UrlDecode(Ticket)  }// 进行UrlEncode
                
            };
            return parameters;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public bool IsPost()
        {
            return false;
        }

        #endregion
    }
   
}
