using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Model
{
    /// <summary>
    /// InteligentBudgetInfo Data Structure.
    /// </summary>
    [Serializable]
    public class InteligentBudgetInfo : AliApiObject
    {
        /// <summary>
        /// 预算数量
        /// </summary>
        [XmlElement("budget_total")]
        public string BudgetTotal { get; set; }

        /// <summary>
        /// 预算类型，枚举（QUANTITY：数量预算）
        /// </summary>
        [XmlElement("budget_type")]
        public string BudgetType { get; set; }
    }
}
