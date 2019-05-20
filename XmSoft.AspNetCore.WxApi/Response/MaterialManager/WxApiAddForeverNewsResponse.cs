using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace XmSoft.AspNetCore.WxApi.Response.MaterialManager
{
    public class WxApiAddForeverNewsResponse : WxApiResponse
    {
        /// <summary>
        /// 返回新增的图文消息素材的media_id。
        /// </summary>
        [JsonProperty(PropertyName = "media_id")]
        public string Media_id { get; set; }
    }
}
