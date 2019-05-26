using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// KoubeiRetailWmsOutboundorderCreateResponse.
    /// </summary>
    public class KoubeiRetailWmsOutboundorderCreateResponse : AliApiResponse
    {
        /// <summary>
        /// 出库通知单号
        /// </summary>
        [XmlElement("outbound_order_id")]
        public string OutboundOrderId { get; set; }
    }
}
