using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// KoubeiTradeOrderPrecreateResponse.
    /// </summary>
    public class KoubeiTradeOrderPrecreateResponse : AliApiResponse
    {
        /// <summary>
        /// 订单号，唯一标识口碑侧一笔订单
        /// </summary>
        [XmlElement("order_no")]
        public string OrderNo { get; set; }

        /// <summary>
        /// 业务用到的码值，当前仅支持二维码  当biz_type传入POST_ORDER_PAY时，该字段为必选
        /// </summary>
        [XmlElement("qr_code")]
        public string QrCode { get; set; }
    }
}
