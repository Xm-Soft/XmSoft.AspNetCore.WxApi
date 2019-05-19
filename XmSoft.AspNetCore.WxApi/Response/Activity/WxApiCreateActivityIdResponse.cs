using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace XmSoft.AspNetCore.WxApi.Response.Activity
{
    public class WxApiCreateActivityIdResponse : WxApiResponse
    {
        [JsonProperty(PropertyName = "activity_id")]
        public string Activity_Id { get;set;}

        [JsonProperty(PropertyName = "expiration_time")]
        public long Expiration_Time { get; set; }


    }
}
