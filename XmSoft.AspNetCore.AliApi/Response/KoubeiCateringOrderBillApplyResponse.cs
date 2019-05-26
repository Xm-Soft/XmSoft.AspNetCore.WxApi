using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// KoubeiCateringOrderBillApplyResponse.
    /// </summary>
    public class KoubeiCateringOrderBillApplyResponse : AliApiResponse
    {
        /// <summary>
        /// 是否需要重试
        /// </summary>
        [XmlElement("retry")]
        public bool Retry { get; set; }
    }
}
