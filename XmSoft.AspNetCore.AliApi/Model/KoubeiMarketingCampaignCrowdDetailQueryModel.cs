using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Model
{
    /// <summary>
    /// KoubeiMarketingCampaignCrowdDetailQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiMarketingCampaignCrowdDetailQueryModel : AliApiObject
    {
        /// <summary>
        /// 人群组ID，人群组创建成功时返回的ID
        /// </summary>
        [XmlElement("crowd_group_id")]
        public string CrowdGroupId { get; set; }
    }
}
