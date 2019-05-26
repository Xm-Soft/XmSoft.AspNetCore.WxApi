using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// ZhimaCustomerEpCertificationQueryResponse.
    /// </summary>
    public class ZhimaCustomerEpCertificationQueryResponse : AliApiResponse
    {
        /// <summary>
        /// 认证不通过的原因
        /// </summary>
        [XmlElement("failed_reason")]
        public string FailedReason { get; set; }

        /// <summary>
        /// 认证是否通过，通过为true，不通过为false
        /// </summary>
        [XmlElement("passed")]
        public string Passed { get; set; }
    }
}
