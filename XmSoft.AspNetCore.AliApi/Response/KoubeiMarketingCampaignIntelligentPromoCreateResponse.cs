using System;
using System.Xml.Serialization;
using XmSoft.AspNetCore.AliApi.Model;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// KoubeiMarketingCampaignIntelligentPromoCreateResponse.
    /// </summary>
    public class KoubeiMarketingCampaignIntelligentPromoCreateResponse : AliApiResponse
    {
        /// <summary>
        /// 智能营销活动信息
        /// </summary>
        [XmlElement("promo")]
        public IntelligentPromo Promo { get; set; }
    }
}
