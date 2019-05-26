using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Model
{
    /// <summary>
    /// KoubeiMarketingCampaignItemMerchantactivityQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiMarketingCampaignItemMerchantactivityQueryModel : AliApiObject
    {
        /// <summary>
        /// 运营活动id
        /// </summary>
        [XmlElement("activity_id")]
        public string ActivityId { get; set; }

        /// <summary>
        /// 外部id
        /// </summary>
        [XmlElement("external_unique_id")]
        public string ExternalUniqueId { get; set; }
    }
}
