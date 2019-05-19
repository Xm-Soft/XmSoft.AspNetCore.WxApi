using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace XmSoft.AspNetCore.WxApi.Response.QRCode
{
    public class WxApiCreateQRCodeResponse : WxApiResponse
    {

        [JsonProperty(PropertyName = "buffer")]
        public byte[] Buffer { get; set; }


       
    }
}
