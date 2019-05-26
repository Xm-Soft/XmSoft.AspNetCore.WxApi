using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// AlipaySecurityProdUmidQueryResponse.
    /// </summary>
    public class AlipaySecurityProdUmidQueryResponse : AliApiResponse
    {
        /// <summary>
        /// umid:客户端对应的UMID值，从UMID系统获取。
        /// </summary>
        [XmlElement("umid")]
        public string Umid { get; set; }
    }
}
