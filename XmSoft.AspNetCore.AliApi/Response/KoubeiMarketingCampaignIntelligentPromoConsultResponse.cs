using System;
using System.Xml.Serialization;
using XmSoft.AspNetCore.AliApi.Model;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// KoubeiMarketingCampaignIntelligentPromoConsultResponse.
    /// </summary>
    public class KoubeiMarketingCampaignIntelligentPromoConsultResponse : AliApiResponse
    {
        /// <summary>
        /// 智能营销方案咨询的模型
        /// </summary>
        [XmlElement("promo")]
        public IntelligentPromo Promo { get; set; }
    }
}
