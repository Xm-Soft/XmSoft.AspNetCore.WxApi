using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace XmSoft.AspNetCore.WxApi.Response
{
    public class WxApiGetUserPortraitResponse : WxApiResponse
    {
        [JsonProperty(PropertyName = "ref_date")]
        public string AccessToken { get; set; }

        [JsonProperty(PropertyName = "visit_uv_new")]
        public Visit_Uv_New_User Visit_Uv_New { get; set; }

        [JsonProperty(PropertyName = "visit_uv")]
        public Visit_Uv_New_User Visit_Uv { get; set; }
        [JsonProperty(PropertyName = "errcode")]
        public int ErrCode { get; set; }

        [JsonProperty(PropertyName = "errmsg")]
        public string Errmsg { get; set; }


    }
    public class Visit_Uv_New_User
    {
        /// <summary>
        /// 分布类型
        /// </summary>
        [JsonProperty(PropertyName = "index")]
        public int Index { get; set; }
        [JsonProperty(PropertyName = "province")]
        public List<ResponseObject> Province { get; set; }
        [JsonProperty(PropertyName = "city")]
        public List<ResponseObject> City { get; set; }
        /// <summary>
        /// 性别，包括男、女、未知
        /// </summary>
        [JsonProperty(PropertyName = "genders")]
        public List<ResponseObject> Genders { get; set; }
        /// <summary>
        /// 终端类型，包括 iPhone，android，其他
        /// </summary>
        [JsonProperty(PropertyName = "platforms")]
        public List<ResponseObject> Platforms { get; set; }
        /// <summary>
        /// 机型，如苹果 iPhone 6，OPPO R9 等
        /// </summary>
        [JsonProperty(PropertyName = "devices")]
        public List<ResponseObject> Devices { get; set; }
        /// <summary>
        /// 年龄，包括17岁以下、18-24岁等区间
        /// </summary>
        [JsonProperty(PropertyName = "ages")]
        public List<ResponseObject> Ages { get; set; }
        
    }

    public class ResponseObject
    {
        /// <summary>
        /// 属性值id
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public int Id { get; set; }
        /// <summary>
        /// 属性值名称，与id对应。如属性为 province 时，返回的属性值名称包括「广东」等。
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }
        /// <summary>
        /// 该场景访问uv
        /// </summary>
        [JsonProperty(PropertyName = "value")]
        public string Value { get; set; }
    }
    
}
