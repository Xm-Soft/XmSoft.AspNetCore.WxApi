using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// AlipayMobilePublicMenuUpdateResponse.
    /// </summary>
    public class AlipayMobilePublicMenuUpdateResponse : AliApiResponse
    {
        /// <summary>
        /// 结果码
        /// </summary>
        [XmlElement("code")]
        public string Code { get; set; }

        /// <summary>
        /// 成功
        /// </summary>
        [XmlElement("msg")]
        public string Msg { get; set; }
    }
}
