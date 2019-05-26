using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// KoubeiMarketingCampaignItemMerchantactivityCreateResponse.
    /// </summary>
    public class KoubeiMarketingCampaignItemMerchantactivityCreateResponse : AliApiResponse
    {
        /// <summary>
        /// 运营活动id
        /// </summary>
        [XmlElement("activity_id")]
        public string ActivityId { get; set; }
    }
}
