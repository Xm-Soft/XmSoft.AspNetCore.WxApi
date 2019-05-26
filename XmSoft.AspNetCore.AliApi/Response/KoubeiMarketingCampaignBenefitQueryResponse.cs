using System;
using System.Xml.Serialization;
using XmSoft.AspNetCore.AliApi.Model;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// KoubeiMarketingCampaignBenefitQueryResponse.
    /// </summary>
    public class KoubeiMarketingCampaignBenefitQueryResponse : AliApiResponse
    {
        /// <summary>
        /// benefitQueryInfo: 权益查询接口返回的具体权益信息
        /// </summary>
        [XmlElement("benefit_query_info")]
        public BenefitQueryInfo BenefitQueryInfo { get; set; }
    }
}
