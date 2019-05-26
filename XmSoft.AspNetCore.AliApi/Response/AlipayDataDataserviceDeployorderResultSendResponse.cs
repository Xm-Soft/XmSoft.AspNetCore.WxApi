using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// AlipayDataDataserviceDeployorderResultSendResponse.
    /// </summary>
    public class AlipayDataDataserviceDeployorderResultSendResponse : AliApiResponse
    {
        /// <summary>
        /// 处理是否成功
        /// </summary>
        [XmlElement("success")]
        public bool Success { get; set; }
    }
}
