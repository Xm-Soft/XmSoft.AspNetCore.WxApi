using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// KoubeiCateringOrderInfoModifyResponse.
    /// </summary>
    public class KoubeiCateringOrderInfoModifyResponse : AliApiResponse
    {
        /// <summary>
        /// 是否需要重试,true-需要重试 ,false-不需要重试
        /// </summary>
        [XmlElement("retry")]
        public bool Retry { get; set; }
    }
}
