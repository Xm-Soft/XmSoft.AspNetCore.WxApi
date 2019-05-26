using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// AlipayMarketingCampaignCertCreateResponse.
    /// </summary>
    public class AlipayMarketingCampaignCertCreateResponse : AliApiResponse
    {
        /// <summary>
        /// 凭证id
        /// </summary>
        [XmlElement("lot_number")]
        public string LotNumber { get; set; }
    }
}
