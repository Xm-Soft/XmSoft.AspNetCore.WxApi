using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// AlipayCreditAutofinanceLoanPlanQueryResponse.
    /// </summary>
    public class AlipayCreditAutofinanceLoanPlanQueryResponse : AliApiResponse
    {
        /// <summary>
        /// 贷款方案列表，是一个List结构,针对不同的业务平台有不同的返回值，目前大搜车业务只支持的返回值有：firstpayamt 首付租金，firstpayprop 首付比例，lastpayamt 回购尾款，loantenor 贷款期数，monthpayamt 每月还款额度
        /// </summary>
        [XmlElement("loanplan")]
        public string Loanplan { get; set; }
    }
}
