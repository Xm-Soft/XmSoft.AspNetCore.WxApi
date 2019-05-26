using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Model
{
    /// <summary>
    /// AlipayOpenServicemarketOrderAcceptModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenServicemarketOrderAcceptModel : AliApiObject
    {
        /// <summary>
        /// 服务商品订单ID
        /// </summary>
        [XmlElement("commodity_order_id")]
        public string CommodityOrderId { get; set; }
    }
}
