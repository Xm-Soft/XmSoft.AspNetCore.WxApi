using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// AlipayMobilePublicMessageGroupResponse.
    /// </summary>
    public class AlipayMobilePublicMessageGroupResponse : AliApiResponse
    {
        /// <summary>
        /// code
        /// </summary>
        [XmlElement("code")]
        public string Code { get; set; }

        /// <summary>
        /// 消息ID
        /// </summary>
        [XmlElement("data")]
        public string Data { get; set; }

        /// <summary>
        /// 结果描述
        /// </summary>
        [XmlElement("msg")]
        public string Msg { get; set; }
    }
}
