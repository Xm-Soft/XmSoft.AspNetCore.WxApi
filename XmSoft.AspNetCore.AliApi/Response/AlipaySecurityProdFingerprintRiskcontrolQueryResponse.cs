using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// AlipaySecurityProdFingerprintRiskcontrolQueryResponse.
    /// </summary>
    public class AlipaySecurityProdFingerprintRiskcontrolQueryResponse : AliApiResponse
    {
        /// <summary>
        /// IFAA服务端查询结果，true为支持指纹功能，false为不支持
        /// </summary>
        [XmlElement("check_result")]
        public bool CheckResult { get; set; }
    }
}
