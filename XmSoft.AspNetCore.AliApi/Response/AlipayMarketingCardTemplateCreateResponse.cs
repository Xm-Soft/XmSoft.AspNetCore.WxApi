using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// AlipayMarketingCardTemplateCreateResponse.
    /// </summary>
    public class AlipayMarketingCardTemplateCreateResponse : AliApiResponse
    {
        /// <summary>
        /// 支付宝卡模板ID
        /// </summary>
        [XmlElement("template_id")]
        public string TemplateId { get; set; }
    }
}
