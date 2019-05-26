using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// AlipaySecurityRiskReconfirmVerificatecallbackSendResponse.
    /// </summary>
    public class AlipaySecurityRiskReconfirmVerificatecallbackSendResponse : AliApiResponse
    {
        /// <summary>
        /// 额外返回信息
        /// </summary>
        [XmlElement("extend_info")]
        public string ExtendInfo { get; set; }
    }
}
