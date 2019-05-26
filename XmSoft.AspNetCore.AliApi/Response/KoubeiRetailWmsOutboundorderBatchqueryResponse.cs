using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using XmSoft.AspNetCore.AliApi.Model;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// KoubeiRetailWmsOutboundorderBatchqueryResponse.
    /// </summary>
    public class KoubeiRetailWmsOutboundorderBatchqueryResponse : AliApiResponse
    {
        /// <summary>
        /// 出库通知单列表
        /// </summary>
        [XmlArray("outbound_order_vo_list")]
        [XmlArrayItem("outbound_order_v_o")]
        public List<OutboundOrderVO> OutboundOrderVoList { get; set; }
    }
}
