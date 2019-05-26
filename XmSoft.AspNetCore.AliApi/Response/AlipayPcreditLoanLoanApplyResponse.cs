using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// AlipayPcreditLoanLoanApplyResponse.
    /// </summary>
    public class AlipayPcreditLoanLoanApplyResponse : AliApiResponse
    {
        /// <summary>
        /// 贷款申请受理单号
        /// </summary>
        [XmlElement("apply_receipt_no")]
        public string ApplyReceiptNo { get; set; }

        /// <summary>
        /// 跳转至支付宝地址
        /// </summary>
        [XmlElement("redirect_url")]
        public string RedirectUrl { get; set; }
    }
}
