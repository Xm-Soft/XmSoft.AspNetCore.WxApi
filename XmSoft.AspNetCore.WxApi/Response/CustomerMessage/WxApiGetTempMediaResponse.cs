using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace XmSoft.AspNetCore.WxApi.Response.CustomerMessage
{
    public class WxApiGetTempMediaResponse:WxApiResponse
    {
        [JsonProperty(PropertyName = "buffer")]
        public byte[] Buffer { get; set; }
       
    }
}
