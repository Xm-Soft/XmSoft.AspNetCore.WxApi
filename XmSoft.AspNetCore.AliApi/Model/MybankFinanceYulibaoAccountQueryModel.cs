using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Model
{
    /// <summary>
    /// MybankFinanceYulibaoAccountQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class MybankFinanceYulibaoAccountQueryModel : AliApiObject
    {
        /// <summary>
        /// 基金代码，必填。目前默认填001529，代表余利宝
        /// </summary>
        [XmlElement("fund_code")]
        public string FundCode { get; set; }
    }
}
