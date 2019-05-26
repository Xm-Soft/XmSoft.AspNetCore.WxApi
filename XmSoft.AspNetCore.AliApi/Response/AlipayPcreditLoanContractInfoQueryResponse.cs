using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// AlipayPcreditLoanContractInfoQueryResponse.
    /// </summary>
    public class AlipayPcreditLoanContractInfoQueryResponse : AliApiResponse
    {
        /// <summary>
        /// 合同内容
        /// </summary>
        [XmlElement("content")]
        public string Content { get; set; }
    }
}
