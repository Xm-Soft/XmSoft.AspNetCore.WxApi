using System;
using System.Xml.Serialization;
using XmSoft.AspNetCore.AliApi.Model;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// AlipayOpenEchoSendResponse.
    /// </summary>
    public class AlipayOpenEchoSendResponse : AliApiResponse
    {
        /// <summary>
        /// DDDD
        /// </summary>
        [XmlElement("obj")]
        public MyObjectDdd Obj { get; set; }

        /// <summary>
        /// hello world
        /// </summary>
        [XmlElement("out_a")]
        public string OutA { get; set; }

        /// <summary>
        /// Number
        /// </summary>
        [XmlElement("out_b")]
        public long OutB { get; set; }

        /// <summary>
        /// Price
        /// </summary>
        [XmlElement("out_c")]
        public string OutC { get; set; }

        /// <summary>
        /// xxx
        /// </summary>
        [XmlElement("out_d")]
        public string OutD { get; set; }

        /// <summary>
        /// hello world
        /// </summary>
        [XmlElement("word")]
        public string Word { get; set; }
    }
}
