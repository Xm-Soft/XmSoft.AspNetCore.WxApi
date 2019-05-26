using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using XmSoft.AspNetCore.AliApi.Model;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// KoubeiRetailWmsInboundorderQueryResponse.
    /// </summary>
    public class KoubeiRetailWmsInboundorderQueryResponse : AliApiResponse
    {
        /// <summary>
        /// 入库通知单明细列表
        /// </summary>
        [XmlArray("inbound_order_line_list")]
        [XmlArrayItem("inbound_order_line")]
        public List<InboundOrderLine> InboundOrderLineList { get; set; }

        /// <summary>
        /// 入库通知单信息
        /// </summary>
        [XmlElement("inbound_order_vo")]
        public InboundOrderVO InboundOrderVo { get; set; }
    }
}
