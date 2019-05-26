using System;
using System.Xml.Serialization;
using XmSoft.AspNetCore.AliApi.Model;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// AlipayEbppInvoiceInfoGetResponse.
    /// </summary>
    public class AlipayEbppInvoiceInfoGetResponse : AliApiResponse
    {
        /// <summary>
        /// 电子发票详情模型
        /// </summary>
        [XmlElement("invoice_model")]
        public InvoiceModelContent InvoiceModel { get; set; }
    }
}
