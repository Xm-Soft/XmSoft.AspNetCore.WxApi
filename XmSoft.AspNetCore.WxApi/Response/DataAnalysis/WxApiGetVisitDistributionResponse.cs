using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace XmSoft.AspNetCore.WxApi.Response
{
    public class WxApiGetVisitDistributionResponse : WxApiResponse
    {
        [JsonProperty(PropertyName = "ref_date")]
        public string RefDate { get; set; }
        [JsonProperty(PropertyName = "list")]
        public List<DistributionList> list { get; set; }
       

        

    }
    public class DistributionList
    {
        [JsonProperty(PropertyName = "index")]
        public string Index { get; set; }
        [JsonProperty(PropertyName = "item_list")]
        public List<DistributionListData> Item_list { get; set; }
    }
    public class DistributionListData
    {
        [JsonProperty(PropertyName = "key")]
        public string Key { get; set; }
        [JsonProperty(PropertyName = "value")]
        public string Value { get; set; }
    }



}
