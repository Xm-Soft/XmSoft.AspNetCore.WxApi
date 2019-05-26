using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// AlipayMarketingCampaignRuleCrowdCreateResponse.
    /// </summary>
    public class AlipayMarketingCampaignRuleCrowdCreateResponse : AliApiResponse
    {
        /// <summary>
        /// 圈人规则id
        /// </summary>
        [XmlElement("ruleid")]
        public string Ruleid { get; set; }
    }
}
