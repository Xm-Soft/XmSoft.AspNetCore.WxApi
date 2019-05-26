using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// AlipayUserIdenticalAuthbaseQueryResponse.
    /// </summary>
    public class AlipayUserIdenticalAuthbaseQueryResponse : AliApiResponse
    {
        /// <summary>
        /// 是否是同人账号
        /// </summary>
        [XmlElement("identical")]
        public bool Identical { get; set; }
    }
}
