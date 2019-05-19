using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace XmSoft.AspNetCore.WxApi.Response.User
{
    public class WxApiGetUserListResponse : WxApiResponse
    {
       [JsonProperty(PropertyName = "total")]
        public int Total { get; set; }
        [JsonProperty(PropertyName = "count")]
        public int Count { get; set; }
        /// <summary>
        /// [JsonProperty(PropertyName = "data")]
        /// </summary>
        public OpenIdInfo Data { get; set; }
    }
    public class OpenIdInfo
    {
        public string[] openid { get; set; }
        public string next_openid { get; set; }
    }
}
