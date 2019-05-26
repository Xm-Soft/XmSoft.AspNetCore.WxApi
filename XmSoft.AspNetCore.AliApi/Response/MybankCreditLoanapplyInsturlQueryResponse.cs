using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// MybankCreditLoanapplyInsturlQueryResponse.
    /// </summary>
    public class MybankCreditLoanapplyInsturlQueryResponse : AliApiResponse
    {
        /// <summary>
        /// 机构目标跳转链接地址
        /// </summary>
        [XmlElement("target_url")]
        public string TargetUrl { get; set; }
    }
}
