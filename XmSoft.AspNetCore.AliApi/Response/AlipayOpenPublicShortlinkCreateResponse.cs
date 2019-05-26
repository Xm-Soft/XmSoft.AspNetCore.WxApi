using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// AlipayOpenPublicShortlinkCreateResponse.
    /// </summary>
    public class AlipayOpenPublicShortlinkCreateResponse : AliApiResponse
    {
        /// <summary>
        /// 生成的带参推广短链接
        /// </summary>
        [XmlElement("shortlink")]
        public string Shortlink { get; set; }
    }
}
