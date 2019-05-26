using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// AlipayInsAutoAutoinsprodUserCertifyResponse.
    /// </summary>
    public class AlipayInsAutoAutoinsprodUserCertifyResponse : AliApiResponse
    {
        /// <summary>
        /// 验证结果
        /// </summary>
        [XmlElement("agent_cert_result")]
        public string AgentCertResult { get; set; }
    }
}
