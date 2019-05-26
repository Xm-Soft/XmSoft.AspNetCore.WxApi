using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// AlipayMarketingCampaignRuleCrowdCountResponse.
    /// </summary>
    public class AlipayMarketingCampaignRuleCrowdCountResponse : AliApiResponse
    {
        /// <summary>
        /// 统计规则或标签所圈定的人群数目
        /// </summary>
        [XmlElement("crowdcount")]
        public string Crowdcount { get; set; }
    }
}
