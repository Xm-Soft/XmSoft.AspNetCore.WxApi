using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// AlipayMarketingCampaignPrizeAmountQueryResponse.
    /// </summary>
    public class AlipayMarketingCampaignPrizeAmountQueryResponse : AliApiResponse
    {
        /// <summary>
        /// 奖品剩余数量，数值
        /// </summary>
        [XmlElement("remain_amount")]
        public string RemainAmount { get; set; }
    }
}
