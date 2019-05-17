using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace XmSoft.AspNetCore.WxApi.Response.Poi
{
    /// <summary>
    /// 创建门店
    /// </summary>
    public class WxApiAddPoiResponse : WxApiResponse
    {
        /// <summary>
        /// 创建门店
        /// </summary>
        public WxApiAddPoiResponse()
        {

        }
        /// <summary>
        /// 唯一的poiid 门店Id
        /// </summary>
        [JsonProperty(PropertyName = "poi_id")]
        public string Poi_id { get; set; }
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
