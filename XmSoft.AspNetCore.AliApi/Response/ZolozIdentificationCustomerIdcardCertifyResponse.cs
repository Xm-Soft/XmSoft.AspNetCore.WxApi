using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using XmSoft.AspNetCore.AliApi.Model;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// ZolozIdentificationCustomerIdcardCertifyResponse.
    /// </summary>
    public class ZolozIdentificationCustomerIdcardCertifyResponse : AliApiResponse
    {
        /// <summary>
        /// 证件宝审核结果
        /// </summary>
        [XmlArray("cert_audit_result")]
        [XmlArrayItem("cert_audit_result")]
        public List<CertAuditResult> CertAuditResult { get; set; }

        /// <summary>
        /// 业务校验是否通过
        /// </summary>
        [XmlElement("passed")]
        public bool Passed { get; set; }

        /// <summary>
        /// 全流程上下文唯一id
        /// </summary>
        [XmlElement("token")]
        public string Token { get; set; }
    }
}
