using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Model
{
    /// <summary>
    /// AlipayMarketingCampaignDiscountQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayMarketingCampaignDiscountQueryModel : AliApiObject
    {
        /// <summary>
        /// 活动id
        /// </summary>
        [XmlElement("camp_id")]
        public string CampId { get; set; }
    }
}
