using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// KoubeiMarketingCampaignCrowdCreateResponse.
    /// </summary>
    public class KoubeiMarketingCampaignCrowdCreateResponse : AliApiResponse
    {
        /// <summary>
        /// 返回的人群组的唯一标识
        /// </summary>
        [XmlElement("crowd_group_id")]
        public string CrowdGroupId { get; set; }
    }
}
