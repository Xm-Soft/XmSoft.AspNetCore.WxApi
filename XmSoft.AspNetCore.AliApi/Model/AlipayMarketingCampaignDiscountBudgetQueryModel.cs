using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Model
{
    /// <summary>
    /// AlipayMarketingCampaignDiscountBudgetQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayMarketingCampaignDiscountBudgetQueryModel : AliApiObject
    {
        /// <summary>
        /// 预算名称
        /// </summary>
        [XmlElement("budget_id")]
        public string BudgetId { get; set; }
    }
}
