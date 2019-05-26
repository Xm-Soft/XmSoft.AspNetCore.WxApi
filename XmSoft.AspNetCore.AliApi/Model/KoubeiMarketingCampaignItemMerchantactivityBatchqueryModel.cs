using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Model
{
    /// <summary>
    /// KoubeiMarketingCampaignItemMerchantactivityBatchqueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiMarketingCampaignItemMerchantactivityBatchqueryModel : AliApiObject
    {
        /// <summary>
        /// 页码
        /// </summary>
        [XmlElement("page_no")]
        public long PageNo { get; set; }

        /// <summary>
        /// 每页显示内容数
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 活动状态
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }
    }
}
