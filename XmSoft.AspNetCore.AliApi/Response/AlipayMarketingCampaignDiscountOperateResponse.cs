using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// AlipayMarketingCampaignDiscountOperateResponse.
    /// </summary>
    public class AlipayMarketingCampaignDiscountOperateResponse : AliApiResponse
    {
        /// <summary>
        /// 123
        /// </summary>
        [XmlElement("camp_id")]
        public string CampId { get; set; }
    }
}
