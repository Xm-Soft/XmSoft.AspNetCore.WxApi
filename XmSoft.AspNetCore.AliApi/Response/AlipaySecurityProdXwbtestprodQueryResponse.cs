using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// AlipaySecurityProdXwbtestprodQueryResponse.
    /// </summary>
    public class AlipaySecurityProdXwbtestprodQueryResponse : AliApiResponse
    {
        /// <summary>
        /// 11000
        /// </summary>
        [XmlElement("out_a")]
        public string OutA { get; set; }

        /// <summary>
        /// xxxx
        /// </summary>
        [XmlElement("out_b")]
        public long OutB { get; set; }
    }
}
