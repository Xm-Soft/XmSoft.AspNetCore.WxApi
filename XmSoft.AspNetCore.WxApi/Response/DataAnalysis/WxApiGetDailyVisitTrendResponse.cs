using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace XmSoft.AspNetCore.WxApi.Response
{
    public class WxApiGetDailyVisitTrendResponse : WxApiResponse
    {
        [JsonProperty(PropertyName = "list")]
        public List<VisitTrend> list { get; set; }
       

        [JsonProperty(PropertyName = "errcode")]
        public int ErrCode { get; set; }

        [JsonProperty(PropertyName = "errmsg")]
        public string Errmsg { get; set; }

    }

    public class VisitTrend
    {
        /// <summary>
        /// 日期，格式为 yyyymmd
        /// </summary>
        public string ref_date { get; set; }
        /// <summary>
        /// 打开次数
        /// </summary>
        public int session_cnt { get; set; }
        /// <summary>
        /// 访问次数
        /// </summary>
        public int visit_pv { get; set; }
        /// <summary>
        /// 访问人数
        /// </summary>
        public int visit_uv { get; set; }
        /// <summary>
        /// 新用户数
        /// </summary>
        public int visit_uv_new { get; set; }
        /// <summary>
        /// 人均停留时长 (浮点型，单位：秒)
        /// </summary>
        public decimal stay_time_uv { get; set; }
        /// <summary>
        /// 次均停留时长 (浮点型，单位：秒)
        /// </summary>
        public decimal stay_time_session { get; set; }
        /// <summary>
        /// 平均访问深度 (浮点型)
        /// </summary>
        public decimal visit_depth { get; set; }
    }
   
}
