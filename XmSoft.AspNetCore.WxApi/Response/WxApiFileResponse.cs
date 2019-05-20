using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace XmSoft.AspNetCore.WxApi.Response
{
    public class WxApiFileResponse : WxApiResponse
    {

        [JsonProperty(PropertyName = "buffer")]
        public byte[] Buffer { get; set; }
        [JsonProperty(PropertyName = "content-type")]
        public string ContentType { get;set; }
    }
}
