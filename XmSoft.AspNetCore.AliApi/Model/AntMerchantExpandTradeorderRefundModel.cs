using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Model
{
    /// <summary>
    /// AntMerchantExpandTradeorderRefundModel Data Structure.
    /// </summary>
    [Serializable]
    public class AntMerchantExpandTradeorderRefundModel : AliApiObject
    {
        /// <summary>
        /// 订单ID；订单唯一标识
        /// </summary>
        [XmlElement("order_id")]
        public string OrderId { get; set; }

        /// <summary>
        /// 退款理由
        /// </summary>
        [XmlElement("refund_reason")]
        public string RefundReason { get; set; }
    }
}
