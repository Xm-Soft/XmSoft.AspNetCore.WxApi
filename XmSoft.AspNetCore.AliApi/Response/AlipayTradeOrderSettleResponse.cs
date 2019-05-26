using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// AlipayTradeOrderSettleResponse.
    /// </summary>
    public class AlipayTradeOrderSettleResponse : AliApiResponse
    {
        /// <summary>
        /// 支付宝交易号
        /// </summary>
        [XmlElement("trade_no")]
        public string TradeNo { get; set; }
    }
}
