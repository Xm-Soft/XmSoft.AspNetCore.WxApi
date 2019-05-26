using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// AlipayMarketingExchangevoucherTemplateCreateResponse.
    /// </summary>
    public class AlipayMarketingExchangevoucherTemplateCreateResponse : AliApiResponse
    {
        /// <summary>
        /// 模板ID
        /// </summary>
        [XmlElement("template_id")]
        public string TemplateId { get; set; }
    }
}
