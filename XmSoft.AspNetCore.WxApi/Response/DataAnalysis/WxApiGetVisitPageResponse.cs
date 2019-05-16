using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace XmSoft.AspNetCore.WxApi.Response
{
    public class WxApiGetVisitPageResponse : WxApiResponse
    {
        [JsonProperty(PropertyName = "ref_date")]
        public string RefDate { get; set; }
        [JsonProperty(PropertyName = "list")]
        public List<PageInfo> list { get; set; }
       

        [JsonProperty(PropertyName = "errcode")]
        public int ErrCode { get; set; }

        [JsonProperty(PropertyName = "errmsg")]
        public string Errmsg { get; set; }

    }
    public class PageInfo
    {
        /// <summary>
        /// 页面路径
        /// </summary>
        [JsonProperty(PropertyName = "page_path")]
        public string Page_path { get; set; }
        /// <summary>
        /// 访问次数
        /// </summary>
        [JsonProperty(PropertyName = "page_visit_pv")]
        public int Page_visit_pv { get; set; }
        /// <summary>
        /// 访问人数
        /// </summary>
        [JsonProperty(PropertyName = "page_visit_uv")]
        public int Page_visit_uv { get; set; }
        /// <summary>
        /// 次均停留时长
        /// </summary>
        [JsonProperty(PropertyName = "page_staytime_pv")]
        public decimal Page_staytime_pv { get; set; }
        /// <summary>
        /// 进入页次数
        /// </summary>
        [JsonProperty(PropertyName = "entrypage_pv")]
        public int Entrypage_pv { get; set; }
        /// <summary>
        /// 退出页次数
        /// </summary>
        [JsonProperty(PropertyName = "exitpage_pv")]
        public int Exitpage_pv { get; set; }
        /// <summary>
        /// ///转发次数
        /// </summary>
        [JsonProperty(PropertyName = "page_share_pv")]
        
        public int Page_share_pv { get; set; }
        /// <summary>
        /// 转发人数
        /// </summary>
        [JsonProperty(PropertyName = "page_share_uv")]
        public int Page_share_uv { get; set; }
    }
   



}
