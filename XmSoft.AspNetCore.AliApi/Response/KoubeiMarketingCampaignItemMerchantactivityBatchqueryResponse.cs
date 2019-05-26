using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using XmSoft.AspNetCore.AliApi.Model;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// KoubeiMarketingCampaignItemMerchantactivityBatchqueryResponse.
    /// </summary>
    public class KoubeiMarketingCampaignItemMerchantactivityBatchqueryResponse : AliApiResponse
    {
        /// <summary>
        /// 活动信息
        /// </summary>
        [XmlArray("activities")]
        [XmlArrayItem("merchant_online_activity_open_model")]
        public List<MerchantOnlineActivityOpenModel> Activities { get; set; }
    }
}
