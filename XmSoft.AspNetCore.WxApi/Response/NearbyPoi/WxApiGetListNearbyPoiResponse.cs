using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace XmSoft.AspNetCore.WxApi.Response.NearbyPoi
{
    public class WxApiGetListNearbyPoiResponse : WxApiResponse
    {

        [JsonProperty(PropertyName = "data")]
        public PoiData Data { get; set; }


       
    }
    public class PoiListData
    {
        [JsonProperty(PropertyName = "left_apply_num")]
        public int Left_apply_num { get; set; }
        [JsonProperty(PropertyName = "max_apply_num")]
        public int Max_apply_num { get; set; }
        [JsonProperty(PropertyName = "data")]
        public string Data { get; set; }
    }
    public class Poi_list
    {
        /// <summary>
        /// 附近地点 ID
        /// </summary>
        public string poi_id { get; set; }
        /// <summary>
        /// 资质证件地址
        /// </summary>
        public string qualification_address { get; set; }
        /// <summary>
        /// 资质证件证件号
        /// </summary>
        public string qualification_num { get; set; }
        /// <summary>
        /// 地点审核状态
        /// </summary>
        public int audit_status { get; set; }
        /// <summary>
        /// 地点展示在附近状态
        /// </summary>
        public int display_status { get; set; }
        /// <summary>
        /// 审核失败原因，audit_status=4 时返回
        /// </summary>
        public string refuse_reason { get; set; }
    }
}
