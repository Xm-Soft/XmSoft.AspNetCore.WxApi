using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// AlipayOpenAppXwbsssQueryResponse.
    /// </summary>
    public class AlipayOpenAppXwbsssQueryResponse : AliApiResponse
    {
        /// <summary>
        /// 1
        /// </summary>
        [XmlElement("a")]
        public string A { get; set; }
    }
}
