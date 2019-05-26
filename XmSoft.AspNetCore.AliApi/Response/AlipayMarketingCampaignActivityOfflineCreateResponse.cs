using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// AlipayMarketingCampaignActivityOfflineCreateResponse.
    /// </summary>
    public class AlipayMarketingCampaignActivityOfflineCreateResponse : AliApiResponse
    {
        /// <summary>
        /// 创建成功的活动id
        /// </summary>
        [XmlElement("camp_id")]
        public string CampId { get; set; }

        /// <summary>
        /// 创建成功的券模版id
        /// </summary>
        [XmlElement("prize_id")]
        public string PrizeId { get; set; }
    }
}
