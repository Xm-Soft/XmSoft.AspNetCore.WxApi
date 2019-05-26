using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// AlipayMobileStdPublicExpressUserQueryResponse.
    /// </summary>
    public class AlipayMobileStdPublicExpressUserQueryResponse : AliApiResponse
    {
        /// <summary>
        /// 证件号
        /// </summary>
        [XmlElement("cert_no")]
        public string CertNo { get; set; }

        /// <summary>
        /// 证件类型，身份证
        /// </summary>
        [XmlElement("cert_type")]
        public string CertType { get; set; }
    }
}
