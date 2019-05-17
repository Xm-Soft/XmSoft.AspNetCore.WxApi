using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;


namespace XmSoft.AspNetCore.WxApi.Response.Poi
{
    /// <summary>
    /// 删除门店信息
    /// </summary>
    public class WxApiDeletePoiResponse : WxApiResponse
    {
        /// <summary>
        /// 删除门店返回信息
        /// </summary>
        public WxApiDeletePoiResponse()
        {

        }
        /// <summary>
        /// 错误码，0为正常
        /// </summary>
        [JsonProperty(PropertyName = "errcode")]
        public int ErrCode { get; set; }
        /// <summary>
        /// 错误信息
        /// </summary>
        [JsonProperty(PropertyName = "errmsg")]
        public string Errmsg { get; set; }

    }
}
