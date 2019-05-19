using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace XmSoft.AspNetCore.WxApi.Response.CustomerMessage
{
    /// <summary>
    /// 
    /// </summary>
    public class WxApiUploadTempMediaResponse : WxApiResponse
    {
        /// <summary>
        /// 文件类型
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public string Type { get; set; }
        /// <summary>
        /// 媒体文件上传后，获取标识，3天内有效。
        /// </summary>
        [JsonProperty(PropertyName = "media_id")]
        public string Media_id { get; set; }
        /// <summary>
        /// 媒体文件上传时间戳
        /// </summary>
        [JsonProperty(PropertyName = "created_at")]
        public string Created_at { get; set; }
      
    }
}
