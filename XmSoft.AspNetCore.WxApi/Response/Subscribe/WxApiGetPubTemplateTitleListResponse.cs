using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace XmSoft.AspNetCore.WxApi.Response.Subscribe
{
    /// <summary>
    /// 获取帐号所属类目下的公共模板标题 返回
    /// </summary>
    public class WxApiGetPubTemplateTitleListResponse : WxApiResponse
    {
        /// <summary>
        /// 模版标题列表总数
        /// </summary>
        [JsonProperty(PropertyName = "count")]
        public int Count { get; set; }
        /// <summary>
        /// 模板标题列表
        /// </summary>
        [JsonProperty(PropertyName = "data")]
        public List<TemplateTitle> Data { get; set; }
    }
    /// <summary>
    /// 模板标题
    /// </summary>
    public class TemplateTitle
    {
        /// <summary>
        /// 模版标题 id
        /// </summary>
        [JsonProperty(PropertyName = "tid")]
        public int Tid { get; set; }
        /// <summary>
        /// 模版标题
        /// </summary>
        [JsonProperty(PropertyName = "title")]
        public string Title { get; set; }
        /// <summary>
        /// 模版类型，2 为一次性订阅，3 为长期订阅
        /// </summary>
        [JsonProperty(PropertyName = "categoryId")]
        public int CategoryId { get; set; }
        /// <summary>
        /// 模版所属类目 id
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public int Type { get; set; }
    }
}
