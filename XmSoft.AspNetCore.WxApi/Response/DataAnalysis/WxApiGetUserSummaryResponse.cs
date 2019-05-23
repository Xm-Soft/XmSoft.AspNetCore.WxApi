using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace XmSoft.AspNetCore.WxApi.Response.DataAnalysis
{
    public class WxApiGetUserSummaryResponse : WxApiResponse
    {

        [JsonProperty(PropertyName = "list")]
        public List<UserSummary> list { get; set; }



    }
    public class UserSummary
    {
        [JsonProperty(PropertyName = "ref_date")]
        public string Ref_date { get; set; }
        /// <summary>
        /// 	用户的渠道，数值代表的含义如下： 0代表其他合计 1代表公众号搜索 17代表名片分享 30代表扫描二维码 
        /// 	<para>43代表图文页右上角菜单 51代表支付后关注（在支付完成页） 57代表图文页内公众号名称 75代表公众号文章广告 78代表朋友圈广告</para>
        /// </summary>
        [JsonProperty(PropertyName = "user_source")]
        public int User_source { get; set; }
        /// <summary>
        /// 新增的用户数量
        /// </summary>
        [JsonProperty(PropertyName = "new_user")]
        public int New_user { get; set; }
        /// <summary>
        /// 取消关注的用户数量，new_user减去cancel_user即为净增用户数量
        /// </summary>
        [JsonProperty(PropertyName = "cancel_user")]
        public int Cancel_user { get; set; }

    }
  
}
