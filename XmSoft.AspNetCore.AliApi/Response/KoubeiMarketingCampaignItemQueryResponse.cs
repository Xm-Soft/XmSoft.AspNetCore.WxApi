using System;
using System.Xml.Serialization;
using XmSoft.AspNetCore.AliApi.Model;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// KoubeiMarketingCampaignItemQueryResponse.
    /// </summary>
    public class KoubeiMarketingCampaignItemQueryResponse : AliApiResponse
    {
        /// <summary>
        /// 商品详情，包含门店信息
        /// </summary>
        [XmlElement("item")]
        public PromoItemInfo Item { get; set; }
    }
}
