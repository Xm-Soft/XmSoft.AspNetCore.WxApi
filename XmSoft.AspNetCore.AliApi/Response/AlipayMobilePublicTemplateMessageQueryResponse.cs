using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// AlipayMobilePublicTemplateMessageQueryResponse.
    /// </summary>
    public class AlipayMobilePublicTemplateMessageQueryResponse : AliApiResponse
    {
        /// <summary>
        /// 结果值
        /// </summary>
        [XmlElement("result")]
        public string Result { get; set; }
    }
}
