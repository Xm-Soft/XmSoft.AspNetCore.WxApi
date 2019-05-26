using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// AlipayMobileMovieActivityNotifyResponse.
    /// </summary>
    public class AlipayMobileMovieActivityNotifyResponse : AliApiResponse
    {
        /// <summary>
        /// 是否成功
        /// </summary>
        [XmlElement("success")]
        public bool Success { get; set; }
    }
}
