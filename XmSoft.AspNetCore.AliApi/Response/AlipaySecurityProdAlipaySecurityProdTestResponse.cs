using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// AlipaySecurityProdAlipaySecurityProdTestResponse.
    /// </summary>
    public class AlipaySecurityProdAlipaySecurityProdTestResponse : AliApiResponse
    {
        /// <summary>
        /// ddd
        /// </summary>
        [XmlElement("admin")]
        public string Admin { get; set; }
    }
}
