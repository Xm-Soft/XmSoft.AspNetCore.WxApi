using System;
using System.Xml.Serialization;
using XmSoft.AspNetCore.AliApi.Model;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// KoubeiMarketingCampaignIntelligentPromoQueryResponse.
    /// </summary>
    public class KoubeiMarketingCampaignIntelligentPromoQueryResponse : AliApiResponse
    {
        /// <summary>
        /// 查询返回的营销活动模型
        /// </summary>
        [XmlElement("promo")]
        public IntelligentPromo Promo { get; set; }
    }
}
