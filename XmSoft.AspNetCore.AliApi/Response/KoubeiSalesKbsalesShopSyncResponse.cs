using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// KoubeiSalesKbsalesShopSyncResponse.
    /// </summary>
    public class KoubeiSalesKbsalesShopSyncResponse : AliApiResponse
    {
        /// <summary>
        /// 流水结果描述
        /// </summary>
        [XmlElement("desc")]
        public string Desc { get; set; }

        /// <summary>
        /// 口碑流水id
        /// </summary>
        [XmlElement("order_id")]
        public string OrderId { get; set; }

        /// <summary>
        /// 处理结果
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }
    }
}
