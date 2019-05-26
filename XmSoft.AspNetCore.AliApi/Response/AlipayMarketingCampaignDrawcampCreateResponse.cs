using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// AlipayMarketingCampaignDrawcampCreateResponse.
    /// </summary>
    public class AlipayMarketingCampaignDrawcampCreateResponse : AliApiResponse
    {
        /// <summary>
        /// 抽奖活动id
        /// </summary>
        [XmlElement("camp_id")]
        public string CampId { get; set; }
    }
}
