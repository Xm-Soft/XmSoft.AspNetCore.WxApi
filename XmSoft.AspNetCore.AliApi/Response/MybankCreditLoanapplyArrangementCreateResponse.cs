using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// MybankCreditLoanapplyArrangementCreateResponse.
    /// </summary>
    public class MybankCreditLoanapplyArrangementCreateResponse : AliApiResponse
    {
        /// <summary>
        /// 合约编号
        /// </summary>
        [XmlElement("ar_no")]
        public string ArNo { get; set; }
    }
}
