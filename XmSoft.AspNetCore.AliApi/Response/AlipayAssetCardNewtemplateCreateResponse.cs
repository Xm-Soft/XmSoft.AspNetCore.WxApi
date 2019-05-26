using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// AlipayAssetCardNewtemplateCreateResponse.
    /// </summary>
    public class AlipayAssetCardNewtemplateCreateResponse : AliApiResponse
    {
        /// <summary>
        /// 模板id
        /// </summary>
        [XmlElement("template_id")]
        public string TemplateId { get; set; }
    }
}
