using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace XmSoft.AspNetCore.WxApi.Response.Subscribe
{
    /// <summary>
    /// 获取小程序账号的类目
    /// </summary>
    public class WxApiGetCategoryResponse : WxApiResponse
    {
        /// <summary>
        /// 类目列表
        /// </summary>
        [JsonProperty(PropertyName = "data")]
        public List<Category> Data { get; set; }
    }
    /// <summary>
    /// 类目
    /// </summary>
    public class Category
    {
        /// <summary>
        /// 类目id，查询公共库模版时需要
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public int Id { get; set; }
        /// <summary>
        /// 类目的中文名
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }
    }
}
