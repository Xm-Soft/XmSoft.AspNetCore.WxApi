using System;
using System.Xml.Serialization;
using XmSoft.AspNetCore.AliApi.Model;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// KoubeiMarketingCampaignActivityQueryResponse.
    /// </summary>
    public class KoubeiMarketingCampaignActivityQueryResponse : AliApiResponse
    {
        /// <summary>
        /// 活动详情
        /// </summary>
        [XmlElement("camp_detail")]
        public CampDetail CampDetail { get; set; }
    }
}
