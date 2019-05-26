using System;
using System.Xml.Serialization;
using XmSoft.AspNetCore.AliApi.Model;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// KoubeiAdvertCommissionBillQueryResponse.
    /// </summary>
    public class KoubeiAdvertCommissionBillQueryResponse : AliApiResponse
    {
        /// <summary>
        /// 账期(格式为yyyyMM)
        /// </summary>
        [XmlElement("date")]
        public string Date { get; set; }

        /// <summary>
        /// 交易账单  只有type=deal才会有值
        /// </summary>
        [XmlElement("deal_bill")]
        public KbAdvertDealBillResponse DealBill { get; set; }

        /// <summary>
        /// 结算账单  只有type=settle才会有值
        /// </summary>
        [XmlElement("settle_bill")]
        public KbAdvertSettleBillResponse SettleBill { get; set; }

        /// <summary>
        /// 账单类型  deal-交易账单  settle-结算账单
        /// </summary>
        [XmlElement("type")]
        public string Type { get; set; }
    }
}
