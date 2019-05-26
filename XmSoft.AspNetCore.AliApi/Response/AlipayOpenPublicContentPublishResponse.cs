using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// AlipayOpenPublicContentPublishResponse.
    /// </summary>
    public class AlipayOpenPublicContentPublishResponse : AliApiResponse
    {
        /// <summary>
        /// message_id 用于描述生成的消息id
        /// </summary>
        [XmlElement("message_id")]
        public string MessageId { get; set; }
    }
}
