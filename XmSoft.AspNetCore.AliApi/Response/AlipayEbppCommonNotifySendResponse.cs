using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// AlipayEbppCommonNotifySendResponse.
    /// </summary>
    public class AlipayEbppCommonNotifySendResponse : AliApiResponse
    {
        /// <summary>
        /// 通知的执行结果
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }
    }
}
