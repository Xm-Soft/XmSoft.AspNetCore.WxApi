using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Model
{
    /// <summary>
    /// AlipayOpenPublicLifeMsgRecallModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenPublicLifeMsgRecallModel : AliApiObject
    {
        /// <summary>
        /// 消息id
        /// </summary>
        [XmlElement("message_id")]
        public string MessageId { get; set; }
    }
}
