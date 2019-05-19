using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace XmSoft.AspNetCore.WxApi.Response
{
    public class WxApiGetDailyRetainResponse : WxApiResponse
    {
        [JsonProperty(PropertyName = "ref_date")]
        public string AccessToken { get; set; }

        [JsonProperty(PropertyName = "visit_uv_new")]
        public List<Visit_Uv_New> Visit_Uv_New { get; set; }

        [JsonProperty(PropertyName = "visit_uv")]
        public List<Visit_Uv> Visit_Uv { get; set; }
        


    }
    public class Visit_Uv_New
    {
        [JsonProperty(PropertyName = "key")]
        public int Key { get; set; }
        [JsonProperty(PropertyName = "value")]
        public int Value { get; set; }
    }
    public class Visit_Uv
    {
        [JsonProperty(PropertyName = "key")]
        public int Key { get; set; }
        [JsonProperty(PropertyName = "value")]
        public int Value { get; set; }
    }
}
