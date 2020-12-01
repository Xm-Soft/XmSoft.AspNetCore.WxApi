using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace XmSoft.AspNetCore.WxApi.Response.Subscribe
{
    /// <summary>
    /// 获取模板标题下的关键词列表 返回
    /// </summary>
    public class WxApiGetPubTemplateKeyWordsByIdResponse : WxApiResponse
    {

        /// <summary>
        /// 模版标题列表总数
        /// </summary>
        [JsonProperty(PropertyName = "count")]
        public int Count { get; set; }
        /// <summary>
        /// 关键词列表
        /// </summary>
        [JsonProperty(PropertyName = "data")]
        public List<KeyWords> Data { get; set; }
    }
    /// <summary>
    /// 关键字
    /// </summary>
    public class KeyWords
    {
        /// <summary>
        /// 关键词 id，选用模板时需要
        /// </summary>
        [JsonProperty(PropertyName = "kid")]
        public int Kid { get; set; }
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
        /// <summary>
        /// 参数类型
        /// </summary>
        [JsonProperty(PropertyName = "rule")]
        public string Rule { get; set; }
    }
}
