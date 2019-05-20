using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace XmSoft.AspNetCore.WxApi.Response.MaterialManager
{
    /// <summary>
    /// 获取素材总数
    /// </summary>
    public class WxApiGetMaterialCountResponse : WxApiResponse
    {
        /// <summary>
        /// 获取素材总数 - 公众平台
        /// </summary>
        public WxApiGetMaterialCountResponse()
        {

        }
        /// <summary>
        /// 图文素材
        /// </summary>
        [JsonProperty(PropertyName = "voice_count")]
        public int Voice_Count { get; set; }
        /// <summary>
        /// 视频素材标题
        /// </summary>
        [JsonProperty(PropertyName = "video_count")]
        public int Video_Count { get; set; }
        /// <summary>
        /// 视频描述
        /// </summary>
        [JsonProperty(PropertyName = "image_count")]
        public int Image_Count { get; set; }
        [JsonProperty(PropertyName = "news_count")]
        public int News_Count { get; set; }
        /// <summary>
        /// 视频下载地址
        /// </summary>
        [JsonProperty(PropertyName = "down_url")]
        public string Down_url { get; set; }


    }
   
}
