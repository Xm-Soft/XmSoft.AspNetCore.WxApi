using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using XmSoft.AspNetCore.AliApi.Model;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// AlipayCommerceTransportAdStocktaskBatchqueryResponse.
    /// </summary>
    public class AlipayCommerceTransportAdStocktaskBatchqueryResponse : AliApiResponse
    {
        /// <summary>
        /// 库存查询任务
        /// </summary>
        [XmlArray("stock_task")]
        [XmlArrayItem("stock_task")]
        public List<StockTask> StockTask { get; set; }
    }
}
