using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// AlipayPcreditLoanCreditApplyResponse.
    /// </summary>
    public class AlipayPcreditLoanCreditApplyResponse : AliApiResponse
    {
        /// <summary>
        /// 授信申请受理单号
        /// </summary>
        [XmlElement("credit_receipt_no")]
        public string CreditReceiptNo { get; set; }

        /// <summary>
        /// 支付宝授权成功后跳转至借呗服务的地址
        /// </summary>
        [XmlElement("redirect_url")]
        public string RedirectUrl { get; set; }
    }
}
