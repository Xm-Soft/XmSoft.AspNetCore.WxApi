using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// AlipayMarketingCardBenefitCreateResponse.
    /// </summary>
    public class AlipayMarketingCardBenefitCreateResponse : AliApiResponse
    {
        /// <summary>
        /// 权益ID
        /// </summary>
        [XmlElement("benefit_id")]
        public string BenefitId { get; set; }
    }
}
