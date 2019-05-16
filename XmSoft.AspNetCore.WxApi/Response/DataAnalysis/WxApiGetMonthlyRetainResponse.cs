using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace XmSoft.AspNetCore.WxApi.Response
{
    public class WxApiGetMonthlyRetainResponse : WxApiResponse
    {
        [JsonProperty(PropertyName = "ref_date")]
        public string AccessToken { get; set; }

        [JsonProperty(PropertyName = "visit_uv_new")]
        public List<Visit_Uv_New> Visit_Uv_New { get; set; }

        [JsonProperty(PropertyName = "visit_uv")]
        public List<Visit_Uv> Visit_Uv { get; set; }
        [JsonProperty(PropertyName = "errcode")]
        public int ErrCode { get; set; }

        [JsonProperty(PropertyName = "errmsg")]
        public string Errmsg { get; set; }


    }
   
}
