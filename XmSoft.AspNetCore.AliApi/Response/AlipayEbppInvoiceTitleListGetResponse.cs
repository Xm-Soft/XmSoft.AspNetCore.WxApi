using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using XmSoft.AspNetCore.AliApi.Model;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// AlipayEbppInvoiceTitleListGetResponse.
    /// </summary>
    public class AlipayEbppInvoiceTitleListGetResponse : AliApiResponse
    {
        /// <summary>
        /// 抬头列表
        /// </summary>
        [XmlArray("title_list")]
        [XmlArrayItem("invoice_title_model")]
        public List<InvoiceTitleModel> TitleList { get; set; }
    }
}
