using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Model
{
    /// <summary>
    /// AlipayPcreditLoanRefundCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayPcreditLoanRefundCreateModel : AliApiObject
    {
        /// <summary>
        /// 蚂蚁借呗贷款申请编号
        /// </summary>
        [XmlElement("loan_apply_no")]
        public string LoanApplyNo { get; set; }

        /// <summary>
        /// 商户还款订单号
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 商户还款金额
        /// </summary>
        [XmlElement("repay_amt")]
        public string RepayAmt { get; set; }

        /// <summary>
        /// 请求流水号，用于控制幂等
        /// </summary>
        [XmlElement("req_id")]
        public string ReqId { get; set; }
    }
}
