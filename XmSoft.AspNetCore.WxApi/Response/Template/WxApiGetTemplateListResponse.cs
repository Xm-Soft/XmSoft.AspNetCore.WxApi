using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace XmSoft.AspNetCore.WxApi.Response.Template
{
    public class WxApiGetTemplateListResponse : WxApiResponse
    {
      
        /// <summary>
        /// 模板列表
        /// </summary>
        [JsonProperty(PropertyName = "list")]
        public List<Template> List { get; set; }
       
    }

    public class Template
    {
        [JsonProperty(PropertyName = "template_id")]
        public string Template_id { get; set; }
        [JsonProperty(PropertyName = "title")]
        public string Title { get; set; }
        [JsonProperty(PropertyName = "content")]
        public string Content { get; set; }
        [JsonProperty(PropertyName = "example")]
        public string Example { get; set; }
    }
}
