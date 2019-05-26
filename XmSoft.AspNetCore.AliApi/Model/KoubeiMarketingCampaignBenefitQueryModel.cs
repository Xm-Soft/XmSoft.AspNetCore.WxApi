using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Model
{
    /// <summary>
    /// KoubeiMarketingCampaignBenefitQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiMarketingCampaignBenefitQueryModel : AliApiObject
    {
        /// <summary>
        /// 权益id
        /// </summary>
        [XmlElement("benefit_id")]
        public string BenefitId { get; set; }
    }
}
