using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// AlipayMarketingVoucherStockQueryResponse.
    /// </summary>
    public class AlipayMarketingVoucherStockQueryResponse : AliApiResponse
    {
        /// <summary>
        /// 剩余可用库存数量
        /// </summary>
        [XmlElement("available_count")]
        public long AvailableCount { get; set; }

        /// <summary>
        /// 库存总量
        /// </summary>
        [XmlElement("total_count")]
        public long TotalCount { get; set; }
    }
}
