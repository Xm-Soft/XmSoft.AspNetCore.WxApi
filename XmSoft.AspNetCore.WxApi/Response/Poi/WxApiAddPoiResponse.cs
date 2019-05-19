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
       
    }
}
