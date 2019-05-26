using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// AlipayOpenPublicLifeMsgSendResponse.
    /// </summary>
    public class AlipayOpenPublicLifeMsgSendResponse : AliApiResponse
    {
        /// <summary>
        /// 生活号消息唯一标识
        /// </summary>
        [XmlElement("alipay_msg_id")]
        public string AlipayMsgId { get; set; }
    }
}
