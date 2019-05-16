using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace XmSoft.AspNetCore.WxApi.Response
{
    public class WxApiCode2SessionResponse : WxApiResponse
    {
        [JsonProperty(PropertyName = "openid")]
        public string OpenId {get;set;}

        [JsonProperty(PropertyName = "session_key")]
        public string SessionKey { get; set; }

        [JsonProperty(PropertyName = "unionid")]
        public string Unionid { get; set; }

        [JsonProperty(PropertyName = "errcode")]
        public int ErrCode { get; set; }

        [JsonProperty(PropertyName = "errmsg")]
        public string Errmsg { get; set; }
    }
}
