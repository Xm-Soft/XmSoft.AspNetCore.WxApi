using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Model
{
    /// <summary>
    /// AlipayOpenServicemarketOrderRejectModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenServicemarketOrderRejectModel : AliApiObject
    {
        /// <summary>
        /// 订购服务商品订单ID
        /// </summary>
        [XmlElement("commodity_order_id")]
        public string CommodityOrderId { get; set; }

        /// <summary>
        /// 拒绝接单原因
        /// </summary>
        [XmlElement("reject_reason")]
        public string RejectReason { get; set; }
    }
}
