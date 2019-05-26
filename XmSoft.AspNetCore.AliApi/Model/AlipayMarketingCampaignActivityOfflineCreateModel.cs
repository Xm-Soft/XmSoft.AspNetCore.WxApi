using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Model
{
    /// <summary>
    /// AlipayMarketingCampaignActivityOfflineCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayMarketingCampaignActivityOfflineCreateModel : AliApiObject
    {
        /// <summary>
        /// 预算信息
        /// </summary>
        [XmlElement("budget")]
        public OpenPromoBudget Budget { get; set; }

        /// <summary>
        /// 活动信息
        /// </summary>
        [XmlElement("camp")]
        public OpenPromoCamp Camp { get; set; }

        /// <summary>
        /// 活动创建单号
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 奖品信息
        /// </summary>
        [XmlElement("prize")]
        public OpenPromoPrize Prize { get; set; }
    }
}
