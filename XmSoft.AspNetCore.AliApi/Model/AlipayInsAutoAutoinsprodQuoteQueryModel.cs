using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Model
{
    /// <summary>
    /// AlipayInsAutoAutoinsprodQuoteQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayInsAutoAutoinsprodQuoteQueryModel : AliApiObject
    {
        /// <summary>
        /// 询价ID
        /// </summary>
        [XmlElement("enquiry_biz_id")]
        public string EnquiryBizId { get; set; }

        /// <summary>
        /// 报价ID
        /// </summary>
        [XmlElement("quote_biz_id")]
        public string QuoteBizId { get; set; }
    }
}
