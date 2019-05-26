using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// KoubeiMarketingMallTradeSubscribeResponse.
    /// </summary>
    public class KoubeiMarketingMallTradeSubscribeResponse : AliApiResponse
    {
        /// <summary>
        /// 申请工单id（用以查询申请工单状态）
        /// </summary>
        [XmlElement("order_flow_id")]
        public string OrderFlowId { get; set; }
    }
}
