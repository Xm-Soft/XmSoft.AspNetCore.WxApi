using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// KoubeiRetailWmsInboundorderCreateResponse.
    /// </summary>
    public class KoubeiRetailWmsInboundorderCreateResponse : AliApiResponse
    {
        /// <summary>
        /// 入库通知单id
        /// </summary>
        [XmlElement("inbound_order_id")]
        public string InboundOrderId { get; set; }
    }
}
