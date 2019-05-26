using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// AlipayOpenEchoOfflineSendResponse.
    /// </summary>
    public class AlipayOpenEchoOfflineSendResponse : AliApiResponse
    {
        /// <summary>
        /// 10000
        /// </summary>
        [XmlElement("word")]
        public string Word { get; set; }
    }
}
