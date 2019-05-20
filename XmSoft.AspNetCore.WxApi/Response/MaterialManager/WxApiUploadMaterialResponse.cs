using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace XmSoft.AspNetCore.WxApi.Response.MaterialManager
{
    /// <summary>
    /// 新增其他类型永久素材
    /// </summary>
    public class WxApiUploadMaterialResponse : WxApiResponse
    {
        /// <summary>
        /// 新增其他类型永久素材 
        /// </summary>
        public WxApiUploadMaterialResponse()
        {

        }
        /// <summary>
        /// 新增的图片素材的图片URL（仅新增图片素材时会返回该字段）
        /// </summary>
        [JsonProperty(PropertyName = "url")]
        public string UrL { get; set; }
        /// <summary>
        /// 新增的永久素材的media_id
        /// </summary>
        [JsonProperty(PropertyName = "media_id")]
        public string Media_id { get; set; }


    }
}
