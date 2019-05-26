using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Model
{
    /// <summary>
    /// AlipayMarketingCampaignCashDetailQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayMarketingCampaignCashDetailQueryModel : AliApiObject
    {
        /// <summary>
        /// 要查询的现金红包活动号
        /// </summary>
        [XmlElement("crowd_no")]
        public string CrowdNo { get; set; }
    }
}
