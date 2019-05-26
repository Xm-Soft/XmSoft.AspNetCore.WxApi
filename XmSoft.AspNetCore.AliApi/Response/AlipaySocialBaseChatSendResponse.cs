using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// AlipaySocialBaseChatSendResponse.
    /// </summary>
    public class AlipaySocialBaseChatSendResponse : AliApiResponse
    {
        /// <summary>
        /// msg_index:msgid+sessionId
        /// </summary>
        [XmlElement("msg_index")]
        public string MsgIndex { get; set; }
    }
}
