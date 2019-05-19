using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace XmSoft.AspNetCore.WxApi.Response.Template.Message
{
    public class WxApiGetIndustryResponse : WxApiResponse
    {
        /// <summary>
        /// 帐号设置的主营行业
        /// </summary>
        public Industry primary_industry { get; set; }
        /// <summary>
        /// 帐号设置的副营行业
        /// </summary>
        public Industry secondary_industry { get; set; }
    }
    public class Industry
    {
        public string first_class { get; set; }
        public string second_class { get; set; }
    }
  
    
}
