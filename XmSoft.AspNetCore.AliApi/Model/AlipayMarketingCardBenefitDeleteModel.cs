using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Model
{
    /// <summary>
    /// AlipayMarketingCardBenefitDeleteModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayMarketingCardBenefitDeleteModel : AliApiObject
    {
        /// <summary>
        /// 权益ID
        /// </summary>
        [XmlElement("benefit_id")]
        public string BenefitId { get; set; }

        /// <summary>
        /// 会员卡模板ID
        /// </summary>
        [XmlElement("template_id")]
        public string TemplateId { get; set; }
    }
}
