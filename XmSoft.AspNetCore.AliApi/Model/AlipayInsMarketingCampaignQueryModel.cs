using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Model
{
    /// <summary>
    /// AlipayInsMarketingCampaignQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayInsMarketingCampaignQueryModel : AliApiObject
    {
        /// <summary>
        /// 保险营销活动Id
        /// </summary>
        [XmlElement("campaign_id")]
        public string CampaignId { get; set; }

        /// <summary>
        /// 请求流水Id
        /// </summary>
        [XmlElement("request_id")]
        public string RequestId { get; set; }
    }
}
