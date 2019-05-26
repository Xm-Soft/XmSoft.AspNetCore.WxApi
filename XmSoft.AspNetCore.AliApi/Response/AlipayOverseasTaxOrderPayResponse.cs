using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// AlipayOverseasTaxOrderPayResponse.
    /// </summary>
    public class AlipayOverseasTaxOrderPayResponse : AliApiResponse
    {
        /// <summary>
        /// 支付宝的退税流水号
        /// </summary>
        [XmlElement("tax_no")]
        public string TaxNo { get; set; }
    }
}
