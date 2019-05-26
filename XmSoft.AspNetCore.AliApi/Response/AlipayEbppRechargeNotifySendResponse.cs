using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// AlipayEbppRechargeNotifySendResponse.
    /// </summary>
    public class AlipayEbppRechargeNotifySendResponse : AliApiResponse
    {
        /// <summary>
        /// 操作状态
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }
    }
}
