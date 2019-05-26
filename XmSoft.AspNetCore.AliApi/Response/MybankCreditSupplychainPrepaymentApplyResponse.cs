using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// MybankCreditSupplychainPrepaymentApplyResponse.
    /// </summary>
    public class MybankCreditSupplychainPrepaymentApplyResponse : AliApiResponse
    {
        /// <summary>
        /// 预付申请单编号。
        /// </summary>
        [XmlElement("prepayment_apply_no")]
        public string PrepaymentApplyNo { get; set; }
    }
}
