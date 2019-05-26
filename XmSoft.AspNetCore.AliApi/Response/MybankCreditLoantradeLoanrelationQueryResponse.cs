using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// MybankCreditLoantradeLoanrelationQueryResponse.
    /// </summary>
    public class MybankCreditLoantradeLoanrelationQueryResponse : AliApiResponse
    {
        /// <summary>
        /// 是否有融资关系的标志
        /// </summary>
        [XmlElement("loan_relation_flag")]
        public bool LoanRelationFlag { get; set; }
    }
}
