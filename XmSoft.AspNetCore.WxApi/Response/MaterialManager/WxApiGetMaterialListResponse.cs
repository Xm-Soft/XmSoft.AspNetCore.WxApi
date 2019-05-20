using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace XmSoft.AspNetCore.WxApi.Response.MaterialManager
{
    /// <summary>
    /// 获取素材列表
    /// </summary>
    public class WxApiGetMaterialListResponse : WxApiResponse
    {
        /// <summary>
        /// 获取素材列表 - 公众平台
        /// </summary>
        public WxApiGetMaterialListResponse()
        {

        }
        /// <summary>
        /// 图文素材
        /// </summary>
        [JsonProperty(PropertyName = "total_count")]
        public int total_count { get; set; }
        /// <summary>
        /// 视频素材标题
        /// </summary>
        [JsonProperty(PropertyName = "item_count")]
        public int item_count { get; set; }
        /// <summary>
        /// 视频描述
        /// </summary>
        [JsonProperty(PropertyName = "item")]
        public Item item { get; set; }
       


    }
    
    public class Item
    {
        public string media_id { get; set; }
        public string update_time { get; set; }

        public Content content { get; set; }
       
    }
    public class Content
    {
        public List<NewItem> news_item { get; set; }
    }
}
