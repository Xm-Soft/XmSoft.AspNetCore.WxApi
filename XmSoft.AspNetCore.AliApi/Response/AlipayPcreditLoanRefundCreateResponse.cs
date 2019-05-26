using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// AlipayPcreditLoanRefundCreateResponse.
    /// </summary>
    public class AlipayPcreditLoanRefundCreateResponse : AliApiResponse
    {
        /// <summary>
        /// 受理的还款申请单号
        /// </summary>
        [XmlElement("loan_repay_no")]
        public string LoanRepayNo { get; set; }
    }
}
