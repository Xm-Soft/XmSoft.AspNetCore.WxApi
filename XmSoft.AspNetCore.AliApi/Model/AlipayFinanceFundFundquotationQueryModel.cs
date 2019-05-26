using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Model
{
    /// <summary>
    /// AlipayFinanceFundFundquotationQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayFinanceFundFundquotationQueryModel : AliApiObject
    {
        /// <summary>
        /// 基金编号：基金产品编号
        /// </summary>
        [XmlElement("fund_code")]
        public string FundCode { get; set; }
    }
}
