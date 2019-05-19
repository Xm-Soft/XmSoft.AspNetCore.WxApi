using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace XmSoft.AspNetCore.WxApi.Response.Template
{
    public class WxApiGetTemplateLibraryListResponse : WxApiResponse
    {
       
        /// <summary>
        /// 模板标题id（获取模板标题下的关键词库时需要）
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }
        /// <summary>
        /// 模板标题内容
        /// </summary>
        [JsonProperty(PropertyName = "title")]
        public string Title { get; set; }
        /// <summary>
        /// 模板库标题总数
        /// </summary>
        [JsonProperty(PropertyName = "total_count")]
        public int Total_count { get; set; }
    }
}
