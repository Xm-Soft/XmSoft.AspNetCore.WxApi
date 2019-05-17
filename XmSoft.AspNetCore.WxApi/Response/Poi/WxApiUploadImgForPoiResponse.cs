using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace XmSoft.AspNetCore.WxApi.Response.Poi
{
    /// <summary>
    /// 创建门店-上传图片
    /// </summary>
    public class WxApiUploadImgForPoiResponse : WxApiResponse
    {
        /// <summary>
        /// 创建门店-上传图片
        /// </summary>
        public WxApiUploadImgForPoiResponse()
        {

        }
        /// <summary>
        /// 返回路径
        /// </summary>
        [JsonProperty(PropertyName = "url")]
        public string UrL { get; set; }
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
