using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Model
{
    /// <summary>
    /// KoubeiMarketingCampaignItemMerchantactivityCloseModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiMarketingCampaignItemMerchantactivityCloseModel : AliApiObject
    {
        /// <summary>
        /// 活动id
        /// </summary>
        [XmlElement("activity_id")]
        public string ActivityId { get; set; }
    }
}
