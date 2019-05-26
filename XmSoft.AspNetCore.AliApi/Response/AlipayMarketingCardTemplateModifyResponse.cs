using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// AlipayMarketingCardTemplateModifyResponse.
    /// </summary>
    public class AlipayMarketingCardTemplateModifyResponse : AliApiResponse
    {
        /// <summary>
        /// 模板ID
        /// </summary>
        [XmlElement("template_id")]
        public string TemplateId { get; set; }
    }
}
