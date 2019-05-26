using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// AlipayPlatformUseridGetResponse.
    /// </summary>
    public class AlipayPlatformUseridGetResponse : AliApiResponse
    {
        /// <summary>
        /// id字典，key为openId，value为userId
        /// </summary>
        [XmlElement("dict")]
        public string Dict { get; set; }
    }
}
