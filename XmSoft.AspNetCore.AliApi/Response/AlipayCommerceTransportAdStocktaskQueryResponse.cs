using System;
using System.Xml.Serialization;
using XmSoft.AspNetCore.AliApi.Model;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// AlipayCommerceTransportAdStocktaskQueryResponse.
    /// </summary>
    public class AlipayCommerceTransportAdStocktaskQueryResponse : AliApiResponse
    {
        /// <summary>
        /// 库存任务执行情况
        /// </summary>
        [XmlElement("stock_task")]
        public StockTask StockTask { get; set; }
    }
}
