using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace XmSoft.AspNetCore.WxApi.Response
{
    public class WxApiGetDailySummaryResponse : WxApiResponse
    {
      
        [JsonProperty(PropertyName = "list")]
        public List<DailySummaryInfo> list { get; set; }
       

       

    }
    public class DailySummaryInfo
    {
        [JsonProperty(PropertyName = "ref_date")]
        public string Ref_date { get; set; }
        /// <summary>
        /// 累计用户数
        /// </summary>
        [JsonProperty(PropertyName = "visit_total")]
        public int Visit_total { get; set; }
        /// <summary>
        /// 转发次数
        /// </summary>
        [JsonProperty(PropertyName = "share_pv")]
        public int Share_pv { get; set; }
        /// <summary>
        /// 转发人数
        /// </summary>
        [JsonProperty(PropertyName = "share_uv")]
        public int Share_uv { get; set; }
     
    }
   



}
