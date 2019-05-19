using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace XmSoft.AspNetCore.WxApi.Response.CustomerServer
{
    public class WxApiCustomerListResponse : WxApiResponse
    {
        /// <summary>
        /// 客服列表
        /// </summary>
        public List<KFList> kf_list { get; set; }


    }
    public class KFList
    {
        /// <summary>
        /// 完整客服账号，格式为：账号前缀@公众号微信号
        /// </summary>
        public string kf_account { get; set; }
        /// <summary>
        /// 客服昵称
        /// </summary>
        public string kf_nick { get; set; }
        /// <summary>
        /// 	客服工号
        /// </summary>
        public string kf_id { get; set; }
        /// <summary>
        /// 客服昵称，最长6个汉字或12个英文字符
        /// </summary>
        public string kf_headimgurl { get; set; }
    }
}
