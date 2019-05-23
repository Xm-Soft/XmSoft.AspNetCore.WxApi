using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace XmSoft.AspNetCore.WxApi.Response.QRCode
{
    /// <summary>
    /// 长链接转短链接接口 返回
    /// </summary>
    public class WxApiShortUrlResponse : WxApiResponse
    {

        /// <summary>
        /// 	短链接。
        /// </summary>
        [JsonProperty(PropertyName = "short_url")]
        public int Short_url { get; set; }

        
    }
}
