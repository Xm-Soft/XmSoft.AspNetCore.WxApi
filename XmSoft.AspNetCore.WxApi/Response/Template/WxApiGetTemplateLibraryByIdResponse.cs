using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace XmSoft.AspNetCore.WxApi.Response.Template
{
    public class WxApiGetTemplateLibraryByIdResponse : WxApiResponse
    {
       
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }
        [JsonProperty(PropertyName = "title")]
        public string Title { get; set; }
        [JsonProperty(PropertyName = "keyword_List")]
        public List<Keyword_list> Keyword_List { get; set; }
    }

    public class Keyword_list
    {
        /// <summary>
        /// 关键词 id，添加模板时需要
        /// </summary>
        [JsonProperty(PropertyName = "keyword_id")]
        public string Keyword_id { get; set; }
        /// <summary>
        /// 关键词内容
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }
        /// <summary>
        /// 关键词内容对应的示例
        /// </summary>
        [JsonProperty(PropertyName = "example")]
        public string Example { get; set; }
    }
}
