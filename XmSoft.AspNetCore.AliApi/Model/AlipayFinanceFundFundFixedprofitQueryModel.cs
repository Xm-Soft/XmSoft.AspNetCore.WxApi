using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Model
{
    /// <summary>
    /// AlipayFinanceFundFundFixedprofitQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayFinanceFundFundFixedprofitQueryModel : AliApiObject
    {
        /// <summary>
        /// 基金代码
        /// </summary>
        [XmlElement("fund_code")]
        public string FundCode { get; set; }
    }
}
