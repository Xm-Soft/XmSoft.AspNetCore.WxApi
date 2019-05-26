using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Model
{
    /// <summary>
    /// KoubeiAdvertCommissionBillQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiAdvertCommissionBillQueryModel : AliApiObject
    {
        /// <summary>
        /// 账期(格式为yyyyMM)
        /// </summary>
        [XmlElement("date")]
        public string Date { get; set; }

        /// <summary>
        /// 账单类型  deal-交易账单  settle-结算账单
        /// </summary>
        [XmlElement("type")]
        public string Type { get; set; }
    }
}
