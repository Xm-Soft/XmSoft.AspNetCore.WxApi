using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace XmSoft.AspNetCore.WxApi.Response.User
{
    public class WxApiUserCreateTagResponse : WxApiResponse
    {
       
        /// <summary>
        /// 标签
        /// </summary>
        [JsonProperty(PropertyName = "tag")]
        public TagResponse Tag { get; set; }
       
    }
    public class TagResponse
    {
        /// <summary>
        /// 标签id，由微信分配
        /// </summary>
        public string id { get; set; }
        /// <summary>
        /// 	标签名，UTF8编码
        /// </summary>
        public string name { get; set; }
    }
}
