using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using XmSoft.AspNetCore.AliApi.Model;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// KoubeiMarketingCampaignItemBatchqueryResponse.
    /// </summary>
    public class KoubeiMarketingCampaignItemBatchqueryResponse : AliApiResponse
    {
        /// <summary>
        /// 返回商品券集合信息
        /// </summary>
        [XmlArray("items")]
        [XmlArrayItem("promo_item_info")]
        public List<PromoItemInfo> Items { get; set; }
    }
}
