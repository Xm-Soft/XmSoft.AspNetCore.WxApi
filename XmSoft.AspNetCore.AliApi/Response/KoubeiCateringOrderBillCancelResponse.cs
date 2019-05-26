using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// KoubeiCateringOrderBillCancelResponse.
    /// </summary>
    public class KoubeiCateringOrderBillCancelResponse : AliApiResponse
    {
        /// <summary>
        /// 是否需要重试
        /// </summary>
        [XmlElement("retry")]
        public bool Retry { get; set; }
    }
}
