using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// AlipayDataDataserviceVerificationResultSendResponse.
    /// </summary>
    public class AlipayDataDataserviceVerificationResultSendResponse : AliApiResponse
    {
        /// <summary>
        /// 反馈是否成功
        /// </summary>
        [XmlElement("success")]
        public bool Success { get; set; }
    }
}
