using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// MybankCreditLoantradeLoanarRepayResponse.
    /// </summary>
    public class MybankCreditLoantradeLoanarRepayResponse : AliApiResponse
    {
        /// <summary>
        /// 受理事件编号
        /// </summary>
        [XmlElement("ev_seq_no")]
        public string EvSeqNo { get; set; }

        /// <summary>
        /// 合约编号
        /// </summary>
        [XmlElement("loan_ar_no")]
        public string LoanArNo { get; set; }
    }
}
