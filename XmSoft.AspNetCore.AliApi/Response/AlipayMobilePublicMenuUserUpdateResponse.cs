using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// AlipayMobilePublicMenuUserUpdateResponse.
    /// </summary>
    public class AlipayMobilePublicMenuUserUpdateResponse : AliApiResponse
    {
        /// <summary>
        /// 结果码
        /// </summary>
        [XmlElement("code")]
        public string Code { get; set; }

        /// <summary>
        /// 结果描述
        /// </summary>
        [XmlElement("msg")]
        public string Msg { get; set; }
    }
}
