using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// AlipayOpenAppMsgDingSendResponse.
    /// </summary>
    public class AlipayOpenAppMsgDingSendResponse : AliApiResponse
    {
        /// <summary>
        /// 企业消息的id
        /// </summary>
        [XmlElement("msg_id")]
        public string MsgId { get; set; }
    }
}
