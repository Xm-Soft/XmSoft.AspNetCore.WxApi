using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Model
{
    /// <summary>
    /// AlipayMarketingCardBenefitCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayMarketingCardBenefitCreateModel : AliApiObject
    {
        /// <summary>
        /// 会员卡模板外部权益
        /// </summary>
        [XmlElement("mcard_template_benefit")]
        public McardTemplateBenefit McardTemplateBenefit { get; set; }
    }
}
