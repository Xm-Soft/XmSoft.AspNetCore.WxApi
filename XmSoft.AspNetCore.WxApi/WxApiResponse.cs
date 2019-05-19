using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace XmSoft.AspNetCore.WxApi
{
    public abstract class WxApiResponse:WxApiObject
    {
        /// <summary>
        /// 错误码，0为正常
        /// </summary>
        [JsonProperty(PropertyName = "errcode")]
        public int ErrCode { get; set; }
        /// <summary>
        /// 错误信息
        /// </summary>
        [JsonProperty(PropertyName = "errmsg")]
        public string Errmsg { get; set; }
    }
}
