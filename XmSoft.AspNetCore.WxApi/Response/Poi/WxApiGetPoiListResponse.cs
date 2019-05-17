using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;


namespace XmSoft.AspNetCore.WxApi.Response.Poi
{
    /// <summary>
    /// 查询门店列表信息
    /// </summary>
    public class WxApiGetPoiListResponse : WxApiResponse
    {
        /// <summary>
        /// 查询门店列表信息
        /// </summary>
        public WxApiGetPoiListResponse()
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
        /// <summary>
        /// 门店总数量
        /// </summary>
        [JsonProperty(PropertyName = "total_count")]
        public string TotalCount { get; set; }

        /// <summary>
        /// 门店信息
        /// </summary>
        [JsonProperty(PropertyName = "business_list")]
        public List<Business> Businesslist { get; set; }
    }
    
}
