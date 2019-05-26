using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// AlipayMobilePublicFollowAddResponse.
    /// </summary>
    public class AlipayMobilePublicFollowAddResponse : AliApiResponse
    {
        /// <summary>
        /// 成功与否的标志
        /// </summary>
        [XmlElement("code")]
        public string Code { get; set; }
    }
}
