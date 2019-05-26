using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Model
{
    /// <summary>
    /// AlipayEbppInvoiceFileQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEbppInvoiceFileQueryModel : AliApiObject
    {
        /// <summary>
        /// 支付宝端生成的发票id，该字段可从发票详情查询接口获得
        /// </summary>
        [XmlElement("invoice_id")]
        public string InvoiceId { get; set; }
    }
}
