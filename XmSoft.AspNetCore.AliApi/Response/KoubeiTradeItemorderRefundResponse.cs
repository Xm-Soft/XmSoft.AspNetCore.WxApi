using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// KoubeiTradeItemorderRefundResponse.
    /// </summary>
    public class KoubeiTradeItemorderRefundResponse : AliApiResponse
    {
        /// <summary>
        /// 口碑订单号
        /// </summary>
        [XmlElement("order_no")]
        public string OrderNo { get; set; }

        /// <summary>
        /// 退款唯一请求号
        /// </summary>
        [XmlElement("out_request_no")]
        public string OutRequestNo { get; set; }

        /// <summary>
        /// 实际退的资金。
        /// </summary>
        [XmlElement("real_refund_amount")]
        public string RealRefundAmount { get; set; }
    }
}
