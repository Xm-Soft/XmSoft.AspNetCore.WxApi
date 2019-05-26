using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// KoubeiMarketingCampaignDetailInfoQueryResponse.
    /// </summary>
    public class KoubeiMarketingCampaignDetailInfoQueryResponse : AliApiResponse
    {
        /// <summary>
        /// 适用门店:门店与门店之间用“,”隔开
        /// </summary>
        [XmlElement("limit_shops")]
        public string LimitShops { get; set; }
    }
}
