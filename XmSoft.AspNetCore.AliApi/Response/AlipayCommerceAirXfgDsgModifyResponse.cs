using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// AlipayCommerceAirXfgDsgModifyResponse.
    /// </summary>
    public class AlipayCommerceAirXfgDsgModifyResponse : AliApiResponse
    {
        /// <summary>
        /// 用户级别
        /// </summary>
        [XmlElement("level")]
        public string Level { get; set; }
    }
}
