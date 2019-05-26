using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// AlipayMarketingCampaignDiscountBudgetAppendResponse.
    /// </summary>
    public class AlipayMarketingCampaignDiscountBudgetAppendResponse : AliApiResponse
    {
        /// <summary>
        /// 预算ID
        /// </summary>
        [XmlElement("budget_id")]
        public string BudgetId { get; set; }
    }
}
