using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Model
{
    /// <summary>
    /// AlipayMarketingVoucherTemplateDeleteModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayMarketingVoucherTemplateDeleteModel : AliApiObject
    {
        /// <summary>
        /// 券模板ID
        /// </summary>
        [XmlElement("template_id")]
        public string TemplateId { get; set; }
    }
}
