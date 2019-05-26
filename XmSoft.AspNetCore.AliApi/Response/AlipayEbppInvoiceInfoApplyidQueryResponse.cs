using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using XmSoft.AspNetCore.AliApi.Model;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// AlipayEbppInvoiceInfoApplyidQueryResponse.
    /// </summary>
    public class AlipayEbppInvoiceInfoApplyidQueryResponse : AliApiResponse
    {
        /// <summary>
        /// 发票信息
        /// </summary>
        [XmlArray("invoice_info")]
        [XmlArrayItem("invoice_query_open_model")]
        public List<InvoiceQueryOpenModel> InvoiceInfo { get; set; }
    }
}
