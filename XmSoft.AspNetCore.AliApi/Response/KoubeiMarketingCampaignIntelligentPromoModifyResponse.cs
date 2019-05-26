using System;
using System.Xml.Serialization;
using XmSoft.AspNetCore.AliApi.Model;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// KoubeiMarketingCampaignIntelligentPromoModifyResponse.
    /// </summary>
    public class KoubeiMarketingCampaignIntelligentPromoModifyResponse : AliApiResponse
    {
        /// <summary>
        /// 修改后返回的智能活动模型
        /// </summary>
        [XmlElement("promo")]
        public IntelligentPromo Promo { get; set; }
    }
}
