using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// AlipayUserAntarchiveFaceIdentifyResponse.
    /// </summary>
    public class AlipayUserAntarchiveFaceIdentifyResponse : AliApiResponse
    {
        /// <summary>
        /// 比对分值
        /// </summary>
        [XmlElement("score")]
        public string Score { get; set; }
    }
}
