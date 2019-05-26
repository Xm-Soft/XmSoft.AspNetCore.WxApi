using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// KoubeiMarketingCampaignBenefitSendResponse.
    /// </summary>
    public class KoubeiMarketingCampaignBenefitSendResponse : AliApiResponse
    {
        /// <summary>
        /// 领取的权益列表
        /// </summary>
        [XmlArray("benefit_ids")]
        [XmlArrayItem("string")]
        public List<string> BenefitIds { get; set; }
    }
}
