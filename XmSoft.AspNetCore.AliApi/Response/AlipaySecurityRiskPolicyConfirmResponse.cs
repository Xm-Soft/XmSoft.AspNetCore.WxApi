using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// AlipaySecurityRiskPolicyConfirmResponse.
    /// </summary>
    public class AlipaySecurityRiskPolicyConfirmResponse : AliApiResponse
    {
        /// <summary>
        /// 确认结果
        /// </summary>
        [XmlElement("confirm_success")]
        public bool ConfirmSuccess { get; set; }

        /// <summary>
        /// 成功或失败，本版本废弃
        /// </summary>
        [XmlElement("success")]
        public bool Success { get; set; }
    }
}
