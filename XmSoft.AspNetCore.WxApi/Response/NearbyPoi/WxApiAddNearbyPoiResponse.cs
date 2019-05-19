using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace XmSoft.AspNetCore.WxApi.Response.NearbyPoi
{
    public class WxApiAddNearbyPoiResponse : WxApiResponse
    {

        [JsonProperty(PropertyName = "data")]
        public PoiData Data { get; set; }


        
    }
    public class PoiData
    {
        [JsonProperty(PropertyName = "audit_id")]
        public string Audit_id { get; set; }
        [JsonProperty(PropertyName = "poi_id")]
        public string Poi_id { get; set; }
        [JsonProperty(PropertyName = "related_credential")]
        public string Related_credential { get; set; }
    }
}
