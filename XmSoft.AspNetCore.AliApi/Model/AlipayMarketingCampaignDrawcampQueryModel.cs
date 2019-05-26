using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Model
{
    /// <summary>
    /// AlipayMarketingCampaignDrawcampQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayMarketingCampaignDrawcampQueryModel : AliApiObject
    {
        /// <summary>
        /// 抽奖活动id，通过alipay.marketing.campaign.drawcamp.create接口返回
        /// </summary>
        [XmlElement("camp_id")]
        public string CampId { get; set; }
    }
}
