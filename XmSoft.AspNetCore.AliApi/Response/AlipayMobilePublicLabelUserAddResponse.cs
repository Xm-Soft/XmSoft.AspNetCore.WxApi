using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// AlipayMobilePublicLabelUserAddResponse.
    /// </summary>
    public class AlipayMobilePublicLabelUserAddResponse : AliApiResponse
    {
        /// <summary>
        /// 结果码
        /// </summary>
        [XmlElement("code")]
        public string Code { get; set; }

        /// <summary>
        /// 结果信息
        /// </summary>
        [XmlElement("msg")]
        public string Msg { get; set; }
    }
}
