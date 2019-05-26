using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// AlipayOpenServicemarketOrderCreateResponse.
    /// </summary>
    public class AlipayOpenServicemarketOrderCreateResponse : AliApiResponse
    {
        /// <summary>
        /// 订单号
        /// </summary>
        [XmlElement("commodity_order_id")]
        public string CommodityOrderId { get; set; }

        /// <summary>
        /// 支付宝分配给开发者的应用ID
        /// </summary>
        [XmlElement("mini_app_id")]
        public string MiniAppId { get; set; }
    }
}
