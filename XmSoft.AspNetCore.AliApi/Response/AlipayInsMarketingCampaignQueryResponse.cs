using System;
using System.Xml.Serialization;
using XmSoft.AspNetCore.AliApi.Model;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// AlipayInsMarketingCampaignQueryResponse.
    /// </summary>
    public class AlipayInsMarketingCampaignQueryResponse : AliApiResponse
    {
        /// <summary>
        /// 保险营销活动信息
        /// </summary>
        [XmlElement("mkt_campaign")]
        public InsMktCampaignDTO MktCampaign { get; set; }
    }
}
