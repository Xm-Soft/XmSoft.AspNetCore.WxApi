using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// AlipayMobileBeaconMessageSendResponse.
    /// </summary>
    public class AlipayMobileBeaconMessageSendResponse : AliApiResponse
    {
        /// <summary>
        /// 操作返回码
        /// </summary>
        [XmlElement("code")]
        public string Code { get; set; }

        /// <summary>
        /// 操作提示文案
        /// </summary>
        [XmlElement("msg")]
        public string Msg { get; set; }
    }
}
