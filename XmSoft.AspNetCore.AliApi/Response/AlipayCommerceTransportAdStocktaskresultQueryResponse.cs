using System;
using System.Xml.Serialization;
using XmSoft.AspNetCore.AliApi.Model;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// AlipayCommerceTransportAdStocktaskresultQueryResponse.
    /// </summary>
    public class AlipayCommerceTransportAdStocktaskresultQueryResponse : AliApiResponse
    {
        /// <summary>
        /// 库存查询结果
        /// </summary>
        [XmlElement("stock_task_result")]
        public StockTaskResult StockTaskResult { get; set; }
    }
}
