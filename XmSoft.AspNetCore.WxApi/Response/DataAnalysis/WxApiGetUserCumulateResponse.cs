using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace XmSoft.AspNetCore.WxApi.Response.DataAnalysis
{
    public class WxApiGetUserCumulateResponse : WxApiResponse
    {
        [JsonProperty(PropertyName = "list")]
        public List<UserCumulate> list { get; set; }


    }
    
    public class UserCumulate
    {
        /// <summary>
        /// 总用户量
        /// </summary>
        public int cumulate_user { get; set; }
    }


}
