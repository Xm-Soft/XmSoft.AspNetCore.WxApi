using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace XmSoft.AspNetCore.WxApi.Response.MaterialManager
{
    /// <summary>
    /// 上传图片
    /// </summary>
    public class WxApiUploadImgResponse : WxApiResponse
    {
        /// <summary>
        /// 上传图片 
        /// </summary>
        public WxApiUploadImgResponse()
        {

        }
        /// <summary>
        /// 返回路径
        /// </summary>
        [JsonProperty(PropertyName = "url")]
        public string UrL { get; set; }
        
    }
}
