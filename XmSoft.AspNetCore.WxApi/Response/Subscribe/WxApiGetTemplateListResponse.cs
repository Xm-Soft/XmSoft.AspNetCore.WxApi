using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace XmSoft.AspNetCore.WxApi.Response.Subscribe
{
    /// <summary>
    /// 获取当前帐号下的个人模板列表 返回
    /// </summary>
    public class WxApiGetTemplateListResponse : WxApiResponse
    {
        /// <summary>
        /// 个人模板列表
        /// </summary>
        [JsonProperty(PropertyName ="data")]
        public List<Template> Data { get; set; }
    }
    /// <summary>
    /// 个人模板
    /// </summary>

    public class Template
    {
        /// <summary>
        /// 添加至帐号下的模板 id，发送小程序订阅消息时所需
        /// </summary>
        [JsonProperty(PropertyName = "priTmplId")]
        public string PriTmplId { get; set; }
        /// <summary>
        /// 模版标题
        /// </summary>
        [JsonProperty(PropertyName = "title")]
        public string Title { get; set; }
        /// <summary>
        /// 模版内容
        /// </summary>
        [JsonProperty(PropertyName = "content")]
        public string Content { get; set; }
        /// <summary>
        /// 模板内容示例
        /// </summary>
        [JsonProperty(PropertyName = "example")]
        public string Example { get; set; }
        /// <summary>
        /// 模版类型，2 为一次性订阅，3 为长期订阅
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public int Type { get; set; }
    }
}
