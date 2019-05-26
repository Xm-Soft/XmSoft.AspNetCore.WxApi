using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// AlipayMobilePublicMessagePushResponse.
    /// </summary>
    public class AlipayMobilePublicMessagePushResponse : AliApiResponse
    {
        /// <summary>
        /// 成功
        /// </summary>
        [XmlElement("code")]
        public string Code { get; set; }

        /// <summary>
        /// 消息ID
        /// </summary>
        [XmlElement("data")]
        public string Data { get; set; }

        /// <summary>
        /// 成功
        /// </summary>
        [XmlElement("msg")]
        public string Msg { get; set; }
    }
}
