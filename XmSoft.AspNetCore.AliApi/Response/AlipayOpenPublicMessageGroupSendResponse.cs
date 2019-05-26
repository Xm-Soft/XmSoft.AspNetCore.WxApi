using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// AlipayOpenPublicMessageGroupSendResponse.
    /// </summary>
    public class AlipayOpenPublicMessageGroupSendResponse : AliApiResponse
    {
        /// <summary>
        /// 2013121100055554f1000b64-3f05-4581-a5e1-16e29d242950
        /// </summary>
        [XmlElement("message_id")]
        public string MessageId { get; set; }
    }
}
