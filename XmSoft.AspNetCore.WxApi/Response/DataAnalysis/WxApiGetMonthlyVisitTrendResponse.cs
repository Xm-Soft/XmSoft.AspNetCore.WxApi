using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace XmSoft.AspNetCore.WxApi.Response
{
    public class WxApiGetMonthlyVisitTrendResponse : WxApiResponse
    {
        [JsonProperty(PropertyName = "list")]
        public List<VisitTrend> list { get; set; }
       

        

    }

    
   
}
