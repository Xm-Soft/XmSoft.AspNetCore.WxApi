using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace XmSoft.AspNetCore.WxApi.Response
{
    /// <summary>
    /// 用户支付完成后，获取该用户的 UnionId，无需用户授权
    /// </summary>
    public class WxApiGetPaidUnionidResponse : WxApiResponse
    {
        /// <summary>
        /// 用户唯一标识，调用成功后返回
        /// </summary>
        [JsonProperty(PropertyName = "unionid")]
        public string Unionid { get; set; }

       
    }
}
