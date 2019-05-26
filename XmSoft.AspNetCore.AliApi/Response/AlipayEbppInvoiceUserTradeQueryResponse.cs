using System;
using System.Xml.Serialization;
using XmSoft.AspNetCore.AliApi.Model;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// AlipayEbppInvoiceUserTradeQueryResponse.
    /// </summary>
    public class AlipayEbppInvoiceUserTradeQueryResponse : AliApiResponse
    {
        /// <summary>
        /// 发票管家发票交易信息
        /// </summary>
        [XmlElement("trade_info")]
        public InvoiceTradeInfo TradeInfo { get; set; }
    }
}
